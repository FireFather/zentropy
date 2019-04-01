using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ChessEngineInterface
{
    public class Engine : IDisposable
    {
        #region Fields

        private Process _engine;
        private StreamWriter _writer;
        private AutoResetEvent _autoResetEvent;
        private string[] _infoTypeNames;
        private List<string> _options = new List<string>();

        #endregion

        #region Properties

        public int TimeoutDuration { get; set; } = 1000;

        public string ExecutablePath { get; } = "";
        public string Name { get; private set; }
        public string Author { get; private set; }
        public string Description { get; private set; } = "";

        public string[] Options
        {
            get
            {
                return _options.ToArray();
            }
        }

        public bool IsReady
        {
            get
            {
                return IsResponding("isready");
            }
        }

        #endregion

        #region Events

        public event BestMoveFound BestMoveFound;
        public event EvaluationReceived EvaluationReceived;
        public event OutputInfoReceived OutputDataInfoReceived;

        #endregion

        #region Constructors

        public Engine(string executablePath)
        {
            if (string.IsNullOrWhiteSpace(executablePath))
            {
                throw new ArgumentException($"Parameter '{nameof(executablePath)}' must not be null or white space");
            }

            FileInfo executable = new FileInfo(executablePath);

            if (!executable.Exists)
            {
                throw new ArgumentException("Given path doesn't exist");
            }

            if (executable.Extension != ".exe")
            {
                throw new ArgumentException("Given path doesn't lead to an executable file '.exe'");
            }

            ExecutablePath = executablePath;

            _autoResetEvent = new AutoResetEvent(false);
            _infoTypeNames = Enum.GetNames(typeof(InfoType));

            for (int i = 0; i < _infoTypeNames.Length; i++)
            {
                _infoTypeNames[i] = _infoTypeNames[i].ToLowerInvariant();
            }

            InitializeEngine();
            Query("uci");
        }

        #endregion

        #region Methods

        public void RequestStop()
        {
            Query("stop");
        }

        public void Query(string input)
        {
            _writer.WriteLine(input);
            _writer.Flush();
        }

        private bool IsResponding(string query)
        {
            _autoResetEvent.Reset();
            Query(query);
            return _autoResetEvent.WaitOne(TimeoutDuration);
        }

        private void InitializeEngine()
        {
            _engine = new Process();
            _engine.StartInfo.FileName = ExecutablePath;
            _engine.StartInfo.UseShellExecute = false;
            _engine.StartInfo.CreateNoWindow = true;
            _engine.StartInfo.RedirectStandardInput = true;
            _engine.StartInfo.RedirectStandardOutput = true;
            _engine.OutputDataReceived += OnOutputDataReceived;
            _engine.Start();
            _engine.BeginOutputReadLine();

            _writer = _engine.StandardInput;
        }

        private void OnOutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(e.Data))
            {
                return;
            }

            string command;
            string[] output;

            if (e.Data.Contains(" "))
            {
                int indexOfSpace = e.Data.IndexOf(' ');
                command = e.Data.Substring(0, indexOfSpace);

                string data = e.Data.Substring(indexOfSpace + 1);

                if (data.Contains(" "))
                {
                    output = data.Split(' ');
                }
                else
                {
                    output = new string[1];
                    output[0] = data;
                }
            }
            else
            {
                command = e.Data;
                output = null;
            }

            switch (command)
            {
                case "id":

                    switch (output[0])
                    {
                        case "name":
                            Name = e.Data.Substring(8);
                            break;

                        case "author":
                            Author = e.Data.Substring(10);
                            break;
                    }

                    break;

                case "uciok":

                    _autoResetEvent.Set();
                    break;

                case "readyok":

                    _autoResetEvent.Set();
                    break;

                case "bestmove":

                    BestMoveFound?.Invoke(e.Data.Substring(9));
                    break;

                case "copyregistration":
                    break;

                case "registration":
                    break;

                case "info":

                    string[] infoComponents = output;

                    List<InfoType> types = new List<InfoType>();
                    List<string> values = new List<string>();

                    bool isCurrMove = true;

                    for (int i = 0; i < infoComponents.Length; i++)
                    {
                        if (infoComponents[i] == "pv")
                        {
                            isCurrMove = false;
                            break;
                        }
                    }

                    int currentType = -1;
                    string currentInfoData = "";

                    for (int i = 0; i < infoComponents.Length; i++)
                    {
                        bool infoType = false;

                        for (int typeI = 0; typeI < _infoTypeNames.Length; typeI++)
                        {
                            if (infoComponents[i] == _infoTypeNames[typeI])
                            {
                                if (currentInfoData != "" && currentType != -1)
                                {
                                    OutputDataInfoReceived?.Invoke(isCurrMove, currentInfoData, (InfoType)currentType);
                                }

                                if (!isCurrMove)
                                {
                                    types.Add((InfoType)currentType);
                                    values.Add(currentInfoData);
                                }

                                currentType = typeI;
                                currentInfoData = "";
                                infoType = true;
                                break;
                            }
                        }

                        if (!infoType)
                        {
                            currentInfoData += $"{infoComponents[i]} ";
                        }
                    }

                    OutputDataInfoReceived?.Invoke(isCurrMove, currentInfoData, (InfoType)currentType);

                    if (!isCurrMove)
                    {
                        types.Add((InfoType)currentType);
                        values.Add(currentInfoData);

                        Evaluation evaluation = new Evaluation(types.ToArray(), values.ToArray());
                        EvaluationReceived?.Invoke(evaluation);
                    }

                    break;

                case "option":

                    string option = e.Data.Substring(12);

                    if (!_options.Contains(option))
                    {
                        _options.Add(e.Data.Substring(12));
                    }

                    break;
            }
        }

        public void Dispose()
        {
            try
            {
                _engine.Kill();
            }
            catch
            { }

            _engine = null;
        }

        #endregion
    }
}
