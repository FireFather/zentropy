using Zentropy.Model;
using Zentropy.Properties;
using Zentropy.ViewModel;
using ChessDotNet;
using ChessDotNet.Pieces;
using ChessEngineInterface;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.RegularExpressions;
using System.Timers;
using System.Data;

namespace Zentropy.View
{
    public partial class FormMain : Form
    {
        #region Fields
        System.Timers.Timer pauseTimer = null;
        private bool _totalChartView = false;
        private volatile bool _evaluationEnabled = true;
        private volatile bool _analyzingMode = true;
        private volatile bool _movePlayed = true;
        private int _mainPvReference;
        private const int _centipawnTolerance = 85;
        private const int _chartShownPlies = 1024;
        private const double _defaultSizeFactor = 1;
        private ChessPlayer _computerPlayer = ChessPlayer.None;
        private InfoType[] _columnOrder;
        private Random _random = new Random();
        private Color _lastMoveArrowColor = Color.FromArgb(SerializedInfo.Instance.Opacity, 255, 255, 128);
        private Color _darkModeColor = Color.FromArgb(32, 32, 32);
        private Color _selectionColor = Color.FromArgb(250, 222, 227, 230); 
        private ChessPanel _chessPanel;
        private Stopwatch[] _playerTimes = new Stopwatch[] { new Stopwatch(), new Stopwatch() };
        private SoundPlayer _movePlayer = new SoundPlayer(Resources.Move);
        private SoundPlayer _castlingPlayer = new SoundPlayer(Resources.Castling);
        private SoundPlayer _capturePlayer = new SoundPlayer(Resources.Capture);
        private SoundPlayer _checkPlayer = new SoundPlayer(Resources.Check);
        private FormMainViewModel _vm;
        private FormPieceSettings _pieceDialog;
        private FormBoardSetting _boardDialog;
        private FormEngineManagement _engineDialog;
        private FormPgnOptions _pgnoptionsDialog;
        private FormMatchOptions _matchoptionsDialog;
        private FormBookOptions _bookoptionsDialog;
        private FormGameOptions _gameoptionsDialog;
        private FormAboutZentropy _aboutzentropyDialog;

        private double[] _engineWins = new double[2];
        private double[] _engineDraws = new double[2];
        private double[] _engineLosses = new double[2];
        private double[] _enginePoints = new double[2];
        private double[] _engineWinPercent = new double[2];
        private double[] _engineLOS = new double[2];
        private string[] _engineExePaths = new string[2];
        private string[] _engineLogoPaths = new string[2];

        private volatile Evaluation[] _evaluations;
        private Control[] _engineViewElements;
        private bool _switched = false;
        private int _lastBookLine = 0;
        private int _currBookLine = 1;
        private int _totalBookLines = 0;
        private readonly List<MoveArrow> _engineEvalArrows = new List<MoveArrow>();
        private MoveArrow _lastMoveArrow = null;
        private bool _gameOver = false;
        private string pgnMoveString = null;
        private int _drawMoves = 0;
        private int _resignMoves = 0;
        private bool _resignAdjudicationWhite = false;
        private bool _resignAdjudicationBlack = false;

        #endregion

        #region Constructors

        public FormMain()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            InitializeComponent();
            _panelEvaluationChart.SetDoubleBuffered();
            _dataGridViewMoves.SetDoubleBuffered();

            _vm = new FormMainViewModel();
            InitializeChessBoard();
            InitializeFormAndControls();

            DeserializeInfo();
            LoadInfo();

            InitializeEvaluationGrid();
            InitializeEngine();

            if (SerializedInfo.Instance.UseBook == true)
            {
                ChessGame gameFromFen = null;
                string fenString = GetOpeningFen();
                if (fenString != null)
                {
                    try
                    {
                        gameFromFen = new ChessGame(fenString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Debug.WriteLine(ex.ToString());
                        return;
                    }
                    NewGame(gameFromFen);
                }
                else
                    NewGame(new ChessGame());
            }
            else
                NewGame(new ChessGame());
        }

        #endregion

        #region Initialization Methods

        private void InitializeEngine()
        {
            ClearEngines();

            _switched = false;
            _engineWins = new double[2];
            _engineDraws = new double[2];
            _engineLosses = new double[2];
            _enginePoints = new double[2];
            _engineWinPercent = new double[2];
            _engineLOS = new double[2];

            bool _validEngines = true;

            if (!SetupEngine(SerializedInfo.Instance.EngineList.SelectedSetting, 0, false))
                {
                _validEngines = false;
                }

            if (SerializedInfo.Instance.EngineList.SelectedSetting != null)
                {
                _engineExePaths[0] = SerializedInfo.Instance.EngineList.SelectedSetting.ExecutablePath;
                _engineLogoPaths[0] = SerializedInfo.Instance.EngineList.SelectedSetting.LogoPath;
                }

            if (!SetupEngine(SerializedInfo.Instance.EngineList.SelectedOpponentSetting, 1, false))
                {
                _validEngines = false;
                }

            if (SerializedInfo.Instance.EngineList.SelectedOpponentSetting != null)
                {
                _engineExePaths[1] = SerializedInfo.Instance.EngineList.SelectedOpponentSetting.ExecutablePath;
                _engineLogoPaths[1] = SerializedInfo.Instance.EngineList.SelectedOpponentSetting.LogoPath;
                }

            if (_validEngines)
                {
                _vm.Engines[(int)_vm.Game.WhoseTurn].Query($"position fen {_vm.Game.GetFen()}");
                _vm.Engines[(int)_vm.Game.WhoseTurn].Query("go infinite");
                }

            SetEngineViewElementsVisible(_validEngines);

            if (!_validEngines)
                {
                ClearEngines();
                }

            _evaluationEnabled = true;
        }

        private void InitializeChessBoard()
        {
            _chessPanel = new ChessPanel
            {
                Cursor = Cursors.Hand,
                BackColor = SystemColors.Control,
                Dock = DockStyle.Fill,
                Location = new Point(0, 0),
                Size = new Size(787, 403),
                Game = _vm.Game
            };
            _chessPanel.Select();
            _chessPanel.PieceMoved += OnPieceMoved;
            _splitContainerBoard.Panel2.Controls.Add(_chessPanel);
        }

        private void InitializeEvaluationGrid()
        {
            _columnOrder = new InfoType[]
            {
                InfoType.MultiPV,
                InfoType.Depth,
                InfoType.Score,
                InfoType.Time,
                InfoType.Nodes,
                InfoType.NPS,
                InfoType.TBHits,
                InfoType.PV,
            };

            ResetEvaluationGridColumns(_columnOrder);
            ResetEvaluationData(SerializedInfo.Instance.MultiPv);
            ResetEvaluationGridRows(SerializedInfo.Instance.MultiPv);
        }

        private void InitializeFormAndControls()
        {
            Icon = Resources.ZentropyIcon;
            Text = "Zentropy";

            _movePlayer.Load();
            _capturePlayer.Load();
            _castlingPlayer.Load();

            Tag = BackColor;

            foreach (Control control in GetAllChildControls(this))
            {
                control.Tag = control.BackColor;
            }

            _engineViewElements = new Control[]
            {
                _tableLayoutPanelEvalInfo,
                _labelScore,
                _panelEvaluationChart
            };
        }

        #endregion

        #region Event Methods
        
        private void OnbuttonCopyFENClick(object sender, EventArgs e)
        {
            Clipboard.SetText(_vm.CurrentPly.Fen);
        }

        private void OnbuttonPasteFENClick(object sender, System.EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();

            if (iData.GetDataPresent(DataFormats.Text))
            {
                ChessGame gameFromFen;

                try
                {
                    gameFromFen = new ChessGame((String)iData.GetData(DataFormats.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Debug.WriteLine(ex.ToString());
                    return;
                }
                NewGame(gameFromFen);
            }
        }

        public void BreakPause()
        {
            if (pauseTimer != null)
            {
                pauseTimer.Stop();
                pauseTimer.Enabled = false;
            }
        }
 
        public bool Pause(int miliseconds)
        {
            ThreadPriority CurrentPriority = Thread.CurrentThread.Priority;

            if (miliseconds > 0)
            {
                Thread.CurrentThread.Priority = ThreadPriority.Lowest;

                pauseTimer = new System.Timers.Timer();
                pauseTimer.Elapsed += new ElapsedEventHandler(PauseTimer_Elapsed);

                pauseTimer.Interval = miliseconds;
                pauseTimer.Enabled = true;

                while (pauseTimer.Enabled)
                {
                    Thread.Sleep(10);
                    Application.DoEvents();
                }

                pauseTimer.Elapsed -= new ElapsedEventHandler(PauseTimer_Elapsed);
            }

            Thread.CurrentThread.Priority = CurrentPriority;

            return true;
        }

        private void PauseTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            pauseTimer.Enabled = false;
        }

        private void OnEngineSelected()
        {
            InitializeEngine();
        }

        private void OnDataGridViewMovesResize(object sender, EventArgs e)
        {
            _dataGridViewMoves.DefaultCellStyle.Font = new Font(_dataGridViewMoves.DefaultCellStyle.Font.FontFamily, _dataGridViewMoves.Width / 22.5F);
        }

        private void OnBestMoveFound(string move)
        {
            if (!_movePlayed)
            {
                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        PlayMove(move);
                    });
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            OnEngineStopped();

            if (_gameOver == true)
            {
            Pause(SerializedInfo.Instance.Pause * 1000);

                if (SerializedInfo.Instance.UseBook == true)
                {
                    ChessGame gameFromFen = null;
                    string fenString = GetOpeningFen();
                    if (fenString != null)
                    {
	                    string pgnSetupString = "SetUp " + "\"" + "1" + "\"";
	                    string pgnFenString = "FEN " + "\"" + fenString + "\"";
	                    WriteInfoToPGN("setup", pgnSetupString);
	                    WriteInfoToPGN("fen", pgnFenString);
                        try
                        {
                            gameFromFen = new ChessGame(fenString);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Debug.WriteLine(ex.ToString());
                            return;
                        }
                        NewGame(gameFromFen);
                    }
                    else
                        NewGame(new ChessGame());
                }
                else
                    NewGame(new ChessGame());

                if (SerializedInfo.Instance.RoundNumber <= SerializedInfo.Instance.MatchGames)
                    OnMenuItemAutoPlayClick(null, null);
                else
                    SerializedInfo.Instance.RoundNumber = SerializedInfo.Instance.MatchGames;
            }
        }

        private void CalcWinPercentage()
        {
            double engine1GamesPlayed = _engineWins[0] + _engineLosses[0];
            double engine2GamesPlayed = _engineWins[1] + _engineLosses[1];

            if (engine1GamesPlayed != 0)
                _engineWinPercent[0] = _engineWins[0] / engine1GamesPlayed * 100;
            if (engine2GamesPlayed != 0)
                _engineWinPercent[1] = _engineWins[1] / engine2GamesPlayed * 100;
        }

        double Erf(double x)
        {
            const double a1 = 0.254829592;
            const double a2 = -0.284496736;
            const double a3 = 1.421413741;
            const double a4 = -1.453152027;
            const double a5 = 1.061405429;
            const double p = 0.3275911;
            double t = 1.0 / (1.0 + p * Math.Abs(x));
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);
            return (x < 0.0 ? -y : y);
        }

        private void CalcLOS()
        {
            _engineLOS[0] = (.5 + .5 * Erf((_engineWins[0] - _engineLosses[0]) / Math.Sqrt(2.0 * (_engineWins[0] + _engineLosses[0])))) * 100;
            _engineLOS[1] = (.5 + .5 * Erf((_engineWins[1] - _engineLosses[1]) / Math.Sqrt(2.0 * (_engineWins[1] + _engineLosses[1])))) * 100;
        }

        private void OnEngineStopped()
        {
            if (InvokeRequired)
            {
                Invoke((Action)OnEngineStopped);
                return;
            }

            EmptyEvaluationGrid();

            _chessPanel.Arrows.Clear();
            _chessPanel.Invalidate();

            bool gameOver = false;
            string terminationText = null;
            string resultText = null;
            string pgnResultString = null;

            Adjudication reason = 0;

            if (_vm.Game.IsCheckmated(_vm.Game.WhoseTurn))
            {
                if (_vm.Game.WhoseTurn == ChessPlayer.Black)
                {
                    if (!_switched)
                    {
                        _engineWins[0]++;
                        _engineLosses[1]++;
                        _enginePoints[0]++;
                        resultText = "1-0";
                    }
                    else
                    {
                        _engineWins[1]++;
                        _engineLosses[0]++;
                        _enginePoints[1]++;
                        resultText = "1-0";
                    }
                }
                else
                {
                    if (!_switched)
                    {
                        _engineWins[1]++;
                        _engineLosses[0]++;
                        _enginePoints[1]++;
                        resultText = "0-1";
                    }
                    else
                    {
                        _engineWins[0]++;
                        _engineLosses[1]++;
                        _enginePoints[0]++;
                        resultText = "0-1";
                    }
                }
                terminationText = "Checkmate";
                gameOver = true;
            }
            else if (_vm.Game.IsStalemated(_vm.Game.WhoseTurn))
            {
                _engineDraws[0]++;
                _engineDraws[1]++;
                _enginePoints[0] = _enginePoints[0] + 0.5;
                _enginePoints[1] = _enginePoints[1] + 0.5;

                terminationText = "Stalemate";
                resultText = "1/2-1/2";
                gameOver = true;
            }
            else if (_vm.Game.CheckforAdjudication(ref reason))
            {
                if (_vm.Game.resignAdjudication == true)
                {
                    if (_resignAdjudicationWhite == true)
                    {
                        if (!_switched)
                        {
                            _engineWins[0]++;
                            _engineLosses[1]++;
                            _enginePoints[0]++;
                            resultText = "1-0";
                        }
                        else
                        {
                            _engineWins[1]++;
                            _engineLosses[0]++;
                            _enginePoints[1]++;
                            resultText = "1-0";
                        }
                    }
                    else if (_resignAdjudicationBlack == true)
                    {
                        if (!_switched)
                        {
                            _engineWins[1]++;
                            _engineLosses[0]++;
                            _enginePoints[1]++;
                            resultText = "0-1";
                        }
                        else
                        {
                            _engineWins[0]++;
                            _engineLosses[1]++;
                            _enginePoints[0]++;
                            resultText = "0-1";
                        }
                    }
                }
                else
                {
                    _engineDraws[0]++;
                    _engineDraws[1]++;
                    _enginePoints[0] = _enginePoints[0] + 0.5;
                    _enginePoints[1] = _enginePoints[1] + 0.5;
                    resultText = "1/2-1/2";
                }

                terminationText = GetFormattedDrawReason(reason);
                gameOver = true;
            }

            if (gameOver)
            {
                _gameOver = true;
                _labelGameTermination.Text = terminationText;
                _labelGameResult.Text = resultText;
                DisplayResultBox(true);
                WriteMoveToPGN("{" + terminationText + "} ");
                WriteMoveToPGN(resultText);
                pgnResultString = "Result " + "\"" + resultText + "\"";
                WriteInfoToPGN("result", pgnResultString);

                for (int i = 0; i < _playerTimes.Length; i++)
                {
                    _playerTimes[i].Stop();
                }
                CalcWinPercentage();
                CalcLOS();
                SerializedInfo.Instance.RoundNumber++;
            }
            else
            {
                int engineIndex = 0;
                ChessPlayer onTurn = _vm.Game.WhoseTurn;
                engineIndex = (int)onTurn;

                _vm.Engines[engineIndex].Query($"position fen {_vm.Game.GetFen()}");

                if (_analyzingMode && (_computerPlayer == ChessPlayer.None || _computerPlayer != _vm.Game.WhoseTurn))
                {
                    _vm.Engines[engineIndex].Query("go infinite");
                }
                else
                {
                    switch (SerializedInfo.Instance.TimeControl.SelectedTimeControlType)
                    {
                        case TimeControlType.FixedDepth:

                            _vm.Engines[engineIndex].Query($"go depth {SerializedInfo.Instance.TimeControl.Plies}");
                            break;

                        case TimeControlType.TimePerMove:

                            _vm.Engines[engineIndex].Query($"go movetime {SerializedInfo.Instance.TimeControl.TimePerMove}");
                            break;

                        case TimeControlType.TotalTime:

                            long increment = SerializedInfo.Instance.TimeControl.Increment;
                            _vm.Engines[engineIndex].Query($"go wtime {GetRemainingTotalTime(0)} btime {GetRemainingTotalTime(1)} winc {increment} binc{increment}");
                            break;

                        case TimeControlType.Infinite:

                            _vm.Engines[engineIndex].Query("go infinite");
                            break;

                        case TimeControlType.Nodes:

                            _vm.Engines[engineIndex].Query($"go nodes {SerializedInfo.Instance.TimeControl.Nodes}");
                            break;
                    }
                }

                _movePlayed = false;
                _evaluationEnabled = true;
            }
        }

        private void OnDialogFontSelected()
        {
            ChessFont currentFont = (ChessFont)SerializedInfo.Instance.SelectedChessFont;
            _chessPanel.IsUnicodeFont = currentFont.IsUnicode;
            _chessPanel.ChessFontChars = currentFont.PieceCharacters;
            _chessPanel.PieceSizeFactor = currentFont.SizeFactor;
            _chessPanel.PieceFontFamily = currentFont.FontFamily;

            _chessPanel.InvalidateRender();
        }

        private void OnBoardSettingAltered()
        {
            _chessPanel.DarkSquareColor = SerializedInfo.Instance.DarkSquareColor;
            _chessPanel.LightSquareColor = SerializedInfo.Instance.LightSquareColor;
            _chessPanel.HighlightLastmoveColor = SerializedInfo.Instance.HighlightLastmoveColor;
            _chessPanel.BorderHighlight = SerializedInfo.Instance.BorderHighlight;
            _chessPanel.UseSquareImages = SerializedInfo.Instance.UseSquareImages;

            ApplyLastMoveHighlight();

            if (SerializedInfo.Instance.UseSquareImages)
            {
                TryApplyBoardImages();
            }

            _chessPanel.InvalidateRender();
        }

        private void OnPieceSettingAltered()
        {
            _chessPanel.Gradient = SerializedInfo.Instance.Gradient;
            _chessPanel.InvalidateRender();
        }

        private void AddMoveArrow(string move)
        {
            _lastMoveArrow = new MoveArrow(move, 1.2, SerializedInfo.Instance.HighlightLastmoveColor, true, true);
        }

        private void AddLastMoveArrow()
        {
            string currentMoveString = _vm.CurrentPly.Move;

            if (!string.IsNullOrEmpty(currentMoveString))
            {
                AddMoveArrow(currentMoveString);
            }
        }

        private void RemoveLastMoveArrow()
        {
            if (_lastMoveArrow != null)
            {
                _chessPanel.Arrows.Remove(_lastMoveArrow);
            }

            _lastMoveArrow = null;
        }

        private void ApplyLastMoveHighlight()
        {
            if (SerializedInfo.Instance.ArrowHighlight)
            {
                _chessPanel.HighlightedSquares.Clear();
                AddLastMoveArrow();
            }
            else
            {
                RemoveLastMoveArrow();

                if (_chessPanel.HighlightedSquares.Count == 0)
                {
                    string currentMoveString = _vm.CurrentPly.Move;

                    if (!string.IsNullOrEmpty(currentMoveString))
                    {
                        Point[] squareLocations = _chessPanel.GetRelPositionsFromMoveString(currentMoveString);
                        _chessPanel.HighlightedSquares.AddRange(squareLocations);
                    }
                }
            }

            if (SerializedInfo.Instance.NoHighlight)
            {
                _chessPanel.NoHighlight = true;
            }
            else if (SerializedInfo.Instance.BorderHighlight)
            {
                _chessPanel.NoHighlight = false;
                _chessPanel.BorderHighlight = true;
            }
            else
            {
                _chessPanel.NoHighlight = false;
                _chessPanel.BorderHighlight = false;
            }
        }

        private void TryApplyBoardImages()
        {
            Image lightSquareImage = TryGetImage(SerializedInfo.Instance.LightSquarePath);
            Image darkSquareImage = TryGetImage(SerializedInfo.Instance.DarkSquarePath);

            _chessPanel.DarkSquareImage = darkSquareImage;
            _chessPanel.LightSquareImage = lightSquareImage;
        }

        private Image TryGetImage(string path)
        {
            Image image;

            try
            {
                image = new Bitmap(path);
            }
            catch
            {
                image = null;
            }

            return image;
        }

        private void OnEvaluationReceived(Evaluation evaluation)
        {
            if (_evaluationEnabled)
            {
                ProcessEvaluation(evaluation);
            }
        }

        private void OnPieceMoved(object sender, PieceMovedEventArgs e)
        {
            Engine playingEngine = GetPlayingEngine();

            if (PlayMove(e))
            {
                playingEngine?.RequestStop();
            }
        }

        private void OnFormMainLoad(object sender, EventArgs e)
        {
            if (SerializedInfo.Instance.IsMaximized)
            {
                WindowState = FormWindowState.Maximized;
            }

            if (SerializedInfo.Instance.SplitterDistanceMain != null)
            {
                _splitContainerMain.SplitterDistance = (int)SerializedInfo.Instance.SplitterDistanceMain;
            }
            if (SerializedInfo.Instance.SplitterDistance1 != null)
            {
                _splitContainer1.SplitterDistance = (int)SerializedInfo.Instance.SplitterDistance1;
            }
            if (SerializedInfo.Instance.SplitterDistance2 != null)
            {
                _splitContainer2.SplitterDistance = (int)SerializedInfo.Instance.SplitterDistance2;
            }
        }

        private void OnTimerValidationTick(object sender, EventArgs e)
        {
            if (SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TotalTime)
            {
                var format = SerializedInfo.Instance.TimeControl.TotalTime >= 3600000 ? @"h\:mm\:ss" : @"mm\:ss\.ff";
                _labelWhiteTime.Text = TimeSpan.FromMilliseconds(GetRemainingTotalTime(0)).ToString(format);
                _labelBlackTime.Text = TimeSpan.FromMilliseconds(GetRemainingTotalTime(1)).ToString(format);
            }
            else
            if (SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TimePerMove)
            {
                var format = SerializedInfo.Instance.TimeControl.TimePerMove >= 3600000 ? @"h\:mm\:ss" : @"mm\:ss\.ff";
                _labelWhiteTime.Text = TimeSpan.FromMilliseconds(GetRemainingTimePerMove(0)).ToString(format);
                _labelBlackTime.Text = TimeSpan.FromMilliseconds(GetRemainingTimePerMove(1)).ToString(format);
            }

            if (!_vm.GameFinished && _evaluationEnabled)
            {
                UpdateUI();
            }

            UpdateArrows();
            _panelEvaluationChart.Invalidate();
            _chessPanel.Invalidate();
        }

        private void UpdateArrows()
        {
            _chessPanel.Arrows.Clear();

            if (!_menuItemHideArrows.Checked)
            {
                _chessPanel.Arrows.AddRange(_engineEvalArrows);
            }

            if (_lastMoveArrow != null)
            {
                _chessPanel.Arrows.Add(_lastMoveArrow);
            }
        }

        private void OnTimerAutoCheckTick(object sender, EventArgs e)
        {
            if (!_analyzingMode && _vm.GameFinished)
            {
                _analyzingMode = true;
            }

            if (!_analyzingMode)
            {
                _computerPlayer = _vm.Game.WhoseTurn;
            }
        }

        private void OnMenuItemCoordinatesCheckedChanged(object sender, EventArgs e)
        {
            _chessPanel.Coordinates = _menuItemCoordinates.Checked;
            _chessPanel.Invalidate();
        }

        private void OnMenuItemBoardBorderCheckedChanged(object sender, EventArgs e)
        {
            _chessPanel.BoardBorder = _menuItemBorder.Checked;
            _chessPanel.Invalidate();
        }

        private void OnMenuItemDisplayLegalMovesCheckedChanged(object sender, EventArgs e)
        {
            _chessPanel.DisplayLegalMoves = _menuItemDisplayLegalMoves.Checked;
            _chessPanel.Invalidate();
        }

        private void OnButtonBackClick(object sender, EventArgs e)
        {
            if (_vm.NavigationIndex > 0)
            {
                Navigate(_vm.NavigationIndex - 1);
            }
        }

        private void OnButtonForwardClick(object sender, EventArgs e)
        {
            if (_vm.NavigationIndex != _vm.PlyList.Count - 1)
            {
                Navigate(_vm.NavigationIndex + 1);
            }
        }

        private void OnButtonStartClick(object sender, EventArgs e)
        {
            Navigate(0);
        }

        private void OnButtonEndClick(object sender, EventArgs e)
        {
            Navigate(_vm.PlyList.Count - 1);
        }

        private void OnButtonExitClick(object sender, EventArgs e) => Application.Exit();

        private void OnFormMainClosing(object sender, FormClosingEventArgs e)
        {
            SerializeInfo();
            ClearEngines();
        }

        private void OnMenuItemFlipBoardCheckedChanged(object sender, EventArgs e)
        {
            _chessPanel.IsFlipped = _menuItemFlipBoard.Checked;
            _chessPanel.Invalidate();
        }

        private void OnButtonFlipBoardClick(object sender, EventArgs e)
        {
            if (_chessPanel.IsFlipped)
                _chessPanel.IsFlipped = false;
            else 
                _chessPanel.IsFlipped = true;

            _menuItemFlipBoard.Checked = _chessPanel.IsFlipped;
            _chessPanel.Invalidate();
        }

        private void OnButtonSoundClick(object sender, EventArgs e)
        {
            if (_menuItemSound.Checked == true)
                _menuItemSound.Checked = false;
            else
                _menuItemSound.Checked = true;
        }

        private void OnMenuItemSquareOutlineCheckedChanged(object sender, EventArgs e)
        {
            _chessPanel.SquareOutline = _menuItemOutlines.Checked;
            _chessPanel.Invalidate();
        }

        private void OnMenuItemHideBottomPanelCheckedChanged(object sender, EventArgs e)
        {
            _splitContainer1.Panel2Collapsed = _menuItemHideOutputPanel.Checked;
        }

        private void OnMenuItemHideLeftPanelCheckedChanged(object sender, EventArgs e)
        {
            _splitContainer2.Panel1Collapsed = _menuItemHideControlPanel.Checked;
        }

        private void OnMenuItemHideRightPanelCheckedChanged(object sender, EventArgs e)
        {
            _splitContainerMain.Panel2Collapsed = _menuItemHideEvalPanel.Checked;
        }

        private void OnMenuItemNewGameClick(object sender, EventArgs e)
        {
            if (SerializedInfo.Instance.UseBook == true)
            {
                ChessGame gameFromFen = null;
                string fenString = GetOpeningFen();
                if (fenString != null)
                {
                    try
                    {
                        gameFromFen = new ChessGame(fenString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Debug.WriteLine(ex.ToString());
                        return;
                    }
                    NewGame(gameFromFen);
                }
                else
                    NewGame(new ChessGame());
            }
            else
                NewGame(new ChessGame());
        }

        private void OnMenuItemComputerMoveClick(object sender, EventArgs e)
        {
            if (GetPlayingEngine() != null)
            {
                if (_computerPlayer != ChessPlayer.None)
                {
                    _computerPlayer = ChessPlayer.None;
                    GetPlayingEngine().RequestStop();
                }
                else
                {
                    _computerPlayer = _vm.Game.WhoseTurn;
                    GetPlayingEngine().RequestStop();
                }
            }
        }

        private void OnMenuItemAutoPlayClick(object sender, EventArgs e)
        {
            if (_buttonAutoPlay.Text == "Start")
            {
                ToggleButtonAutoPlay ("Stop");

                if (SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TotalTime
                    || SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TimePerMove)
                {
                    if (_vm.Game.WhoseTurn == ChessPlayer.White)
                    {
                        _playerTimes[0].Start();
                    }
                    else
                    {
                        _playerTimes[1].Start();
                    }
                }
            }

            else if (_buttonAutoPlay.Text == "Stop")
            {
                ToggleButtonAutoPlay("Start");

                if (SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TotalTime
                   || SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TimePerMove)
                {
                    if (_vm.Game.WhoseTurn == ChessPlayer.White)
                    {
                         _playerTimes[0].Stop();
                    }
                    else
                    {
                        _playerTimes[1].Stop();
                    }
                }
            }

            if (GetPlayingEngine() != null)
            {
                _analyzingMode = !_analyzingMode;
                _computerPlayer = _vm.Game.WhoseTurn;

                _movePlayed = true;
                GetPlayingEngine().RequestStop();
            }
        }

        private void OnMenuItemAlterPiecesClick(object sender, EventArgs e)
        {
            _pieceDialog.ShowDialog();
        }

        private void OnMenuItemAlterBoardClick(object sender, EventArgs e)
        {
            _boardDialog.ShowDialog();
        }

        private void OnMenuItemPgnOptionsClick(object sender, EventArgs e)
        {
            _pgnoptionsDialog.ShowDialog();
        }

        private void OnMenuItemMatchOptionsClick(object sender, EventArgs e)
        {
            _matchoptionsDialog.ShowDialog();
        }

        private void OnMenuItemBookOptionsClick(object sender, EventArgs e)
        {
            _bookoptionsDialog.ShowDialog();
        }

        private void OnMenuItemAboutZentropyClick(object sender, EventArgs e)
        {
            _aboutzentropyDialog.ShowDialog();
        }

        private void OnMenuItemGameOptionsClick(object sender, EventArgs e)
        {
            _gameoptionsDialog.ShowDialog();
        }

        private void OnMenuItemEngineManagementClick(object sender, EventArgs e)
        {
            _engineDialog.ShowDialog();

            for (int i = 0; i < _vm.Engines.Length; i++)
            {
                if (_vm.Engines[i] != null)
                {
                int _multiPv = SerializedInfo.Instance.MultiPv;

                    if (_multiPv > 0 && _multiPv <= 250)
                    {
                        _evaluationEnabled = false;
                        _movePlayed = true;
                        _vm.Engines[i].Query($"setoption name MultiPv value {_multiPv}");
                        _vm.Engines[i].RequestStop();
                        _chessPanel.Invalidate();
                        ResetEvaluationData(_multiPv);
                        ResetEvaluationGridRows(_multiPv);
                        _evaluationEnabled = true;
                    }
				}
            }
        }

        private void OnMenuItemMatchNewClick(object sender, EventArgs e)
        {
            _engineWins[0] = 0;
            _engineWins[1] = 0;
            _engineDraws[0] = 0;
            _engineDraws[1] = 0;
            _engineLosses[0] = 0;
            _engineLosses[1] = 0;
            _enginePoints[0] = 0;
            _enginePoints[1] = 0;
            _engineWinPercent[0] = 0;
            _engineWinPercent[1] = 0;
            _engineLOS[0] = 0;
            _engineLOS[1] = 0;

            if (SerializedInfo.Instance.UseBook == true)
            {
                ChessGame gameFromFen = null;
                _lastBookLine = 0;
                string fenString = GetOpeningFen();
                if (fenString != null)
                {
                    try
                    {
                        gameFromFen = new ChessGame(fenString);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Debug.WriteLine(ex.ToString());
                        return;
                    }
                    NewGame(gameFromFen);
                }
                else
                    NewGame(new ChessGame());
            }
            else
                NewGame(new ChessGame());
            SerializedInfo.Instance.RoundNumber = 1;
        }

        private void OnPanelEvaluationChartPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.Default;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            Pen gridPen = new Pen(_panelEvaluationChart.ForeColor.AlterRgb(200, !SerializedInfo.Instance.DarkMode), 1);
            Pen middleLinePen = new Pen(_panelEvaluationChart.ForeColor.AlterRgb(120, !SerializedInfo.Instance.DarkMode), 1);
            Pen chartBorderPen = new Pen(_panelEvaluationChart.ForeColor, 1);

            Font labelFont = new Font("Verdana", 11);
            
            SolidBrush fontBrush = new SolidBrush(_panelEvaluationChart.ForeColor);
            SolidBrush chartLightBrush = new SolidBrush(_chessPanel.LightSquareColor);
            SolidBrush chartDarkBrush = new SolidBrush(_chessPanel.DarkSquareColor);
            SolidBrush selectionBrush = new SolidBrush(_selectionColor);

            int peak;
            int chartYMiddle = (int)(_panelEvaluationChart.Height / 2.0);

            List<ChessPly> positions = _vm.PlyList.ToList();

            while (positions.Count < 8)
            {
                positions.Add(new ChessPly(""));
            }

            if (!_totalChartView && positions.Count > _chartShownPlies)
            {
                positions.RemoveRange(0, positions.Count - _chartShownPlies);
            }

            int playStartIndex;

            if (_totalChartView)
            {
                playStartIndex = 0;
            }
            else
            {
                playStartIndex = _vm.PlyList.Count - positions.Count;
            }

            double highestValue = 0;
            double lowestValue = 0;

            foreach (var position in positions)
            {
                if (position.Evaluation > highestValue)
                {
                    highestValue = position.Evaluation;
                }
                else if (position.Evaluation < lowestValue)
                {
                    lowestValue = position.Evaluation;
                }
            }

            if (highestValue > Math.Abs(lowestValue))
            {
                peak = (int)Math.Ceiling(highestValue * 1.05);
            }
            else
            {
                peak = (int)Math.Ceiling(Math.Abs(lowestValue) * 1.05);
            }

            if (peak < 2)
            {
                peak = 2;
            }
            else if (peak > 10)
            {
                peak = 10;
            }

            int rowCount = peak * 2;
            int lineCount = 8;

            double xPart = _panelEvaluationChart.Width / (double)lineCount;
            double yPart = _panelEvaluationChart.Height / (double)rowCount;

            for (int i = 1; i < rowCount; i++)
            {
                g.DrawLine(gridPen, 0, (float)(yPart * i), _panelEvaluationChart.Width, (float)(yPart * i));
            }

            for (int i = 1; i < lineCount; i++)
            {
                g.DrawLine(gridPen, (float)(xPart * i), 0, (float)(xPart * i), _panelEvaluationChart.Height);
            }

            float lineWidth = (float)_panelEvaluationChart.Width / lineCount;
            float yCapHeight = _panelEvaluationChart.Height - labelFont.Size * 2.25F;

            for (int i = 1; i <= lineCount; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                int valueX = (int)((positions.Count - 1) / (double)lineCount * i);

                if (!_totalChartView && _vm.PlyList.Count > _chartShownPlies)
                {
                    valueX += _vm.PlyList.Count - _chartShownPlies;
                }

                string text = valueX.ToString();
                SizeF size = g.MeasureString(text, labelFont);
                size.Width *= 2.25F;

                g.DrawString(text, labelFont, fontBrush, lineWidth * i - size.Width / 2, yCapHeight);
            }

            for (int i = 1; i < rowCount; i++)
            {
                if (peak > 5 && i % 2 == 1)
                {
                    continue;
                }

                if (i == rowCount / 2)
                {
                    continue;
                }

                int valueY = peak - i;
                string text = valueY.ToString("+0;-0");
                float offSet = g.MeasureString(text, labelFont).Height / 1.99F;

                g.DrawString(text, labelFont, fontBrush, labelFont.Size / 2, (int)(_panelEvaluationChart.Height / (double)rowCount * i) - offSet);
            }

            g.DrawLine(middleLinePen, 0, chartYMiddle, _panelEvaluationChart.Width, chartYMiddle);

            double yUnitLength = _panelEvaluationChart.Height / (double)rowCount;
            double xUnitLength = (double)(_panelEvaluationChart.Width) / positions.Count;

            if (peak != 0)
            {
                for (int i = 0; i < positions.Count; i++)
                {
                    double evaluation = positions[i].Evaluation;

                    float x = (float)(i * xUnitLength);
                    int y;

                    int height = Round(Math.Abs((evaluation * yUnitLength)));
                    float width = (float)(((i + 1) * xUnitLength - i * xUnitLength));

                    if (evaluation >= 0)
                    {
                        y = chartYMiddle - height;
                        g.FillRectangle(chartLightBrush, x, y, width, height);
                    }
                    else
                    {
                        y = chartYMiddle;
                        g.FillRectangle(chartDarkBrush, x, y, width, height);
                    }
                }
            }
        }

        private void OnPanelEvaluationChartMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_vm.PlyList.Count > 0)
                {
                    double xUnitLength;
                    int navIndex;

                    if (!_totalChartView && _vm.PlyList.Count > _chartShownPlies)
                    {
                        xUnitLength = (double)_panelEvaluationChart.Width / _chartShownPlies;
                        navIndex = (int)(e.X / xUnitLength) + (_vm.PlyList.Count - _chartShownPlies);
                    }
                    else
                    {
                        xUnitLength = (double)_panelEvaluationChart.Width / _vm.PlyList.Count;
                        navIndex = (int)(e.X / xUnitLength);
                    }

                    Navigate(navIndex);
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                _totalChartView = !_totalChartView;
                _panelEvaluationChart.Invalidate();
            }
        }

        private void OnDataGridViewMovesKeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void OnDataGridViewMovesCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int navigationIndex = e.RowIndex * 2 + e.ColumnIndex + 1;

            if ((navigationIndex >= _vm.PlyList.Count || navigationIndex == _vm.NavigationIndex))
            {
                SelectMovesCell(navigationIndex);
                return;
            }

            Navigate(e.RowIndex * 2 + e.ColumnIndex + 1);
        }

        private void OnTableLayoutPanelModulesResize(object sender, EventArgs e)
        {
            _tableEvaluationChart.Height = Round(_tableEvaluationChart.Width * 1.942196);
        }

        private void OnLabelTextValidate(object sender, EventArgs e)
        {
            Control source = (Control)sender;
            source.FitFont(0.9, 0.9);
        }

        private void OnLabelEvaluationTextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Other Methods

        private void LoadInfo()
        {
            if (SerializedInfo.Instance.Bounds != null)
            {
                Bounds = (Rectangle)SerializedInfo.Instance.Bounds;
            }

            _chessPanel.PieceSizeFactor = SerializedInfo.Instance.PieceSizeFactor;

            if (SerializedInfo.Instance.ChessFonts.Count > 0 &&
                SerializedInfo.Instance.SelectedFontIndex >= 0 &&
                SerializedInfo.Instance.SelectedFontIndex <
                SerializedInfo.Instance.ChessFonts.Count)
            {
                OnDialogFontSelected();
            }
            else
            {
                _chessPanel.PieceFontFamily = "";
                _chessPanel.PieceSizeFactor = _defaultSizeFactor;
            }

            _chessPanel.DarkSquareColor = SerializedInfo.Instance.DarkSquareColor;
            _chessPanel.LightSquareColor = SerializedInfo.Instance.LightSquareColor;
            _chessPanel.HighlightLastmoveColor = SerializedInfo.Instance.HighlightLastmoveColor;
            _chessPanel.BorderHighlight = SerializedInfo.Instance.BorderHighlight;
            _chessPanel.Gradient = SerializedInfo.Instance.Gradient;
            _chessPanel.Coordinates = SerializedInfo.Instance.Coordinates;
            _chessPanel.DisplayLegalMoves = SerializedInfo.Instance.DisplayLegalMoves;
            _chessPanel.UseSquareImages = SerializedInfo.Instance.UseSquareImages;
            _chessPanel.SquareOutline = SerializedInfo.Instance.SquareOutline;

            _lastBookLine = SerializedInfo.Instance.LastBookLine;
            _currBookLine = SerializedInfo.Instance.CurrBookLine;
            _totalBookLines = SerializedInfo.Instance.TotalBookLines;
            TryApplyBoardImages();

            ApplyLastMoveHighlight();

            _menuItemHideOutputPanel.Checked = SerializedInfo.Instance.HideBottomPanel;
            _menuItemHideArrows.Checked = SerializedInfo.Instance.HideArrows;

            _splitContainer1.Panel2Collapsed = _menuItemHideOutputPanel.Checked;
            _splitContainer1.Panel1Collapsed = _menuItemHideControlPanel.Checked;
            _splitContainer1.Panel1Collapsed = _menuItemHideEvalPanel.Checked;

            _chessPanel.SquareOutline = SerializedInfo.Instance.SquareOutline;
            _menuItemFlipBoard.Checked = SerializedInfo.Instance.BoardFlipped;
            _menuItemOutlines.Checked = SerializedInfo.Instance.SquareOutline;
            _menuItemCoordinates.Checked = SerializedInfo.Instance.Coordinates;
            _menuItemBorder.Checked = SerializedInfo.Instance.BoardBorder;
            _menuItemSound.Checked = SerializedInfo.Instance.Sound;
            _menuItemDarkMode.Checked = SerializedInfo.Instance.DarkMode;
            _menuItemDisplayLegalMoves.Checked = SerializedInfo.Instance.DisplayLegalMoves;
            _menuItemShowExtendedMoveInfo.Checked = SerializedInfo.Instance.ShowExtendedMoveInfo;

            SetTimeControl();
            SetDarkMode(this, SerializedInfo.Instance.DarkMode);

            if (SerializedInfo.Instance.ChessFonts.Count == 0)
            {
                SerializedInfo.Instance.ChessFonts.Add(new ChessFont
                {
                    Name = "Alpha",
                    FontFamily = "Alpha",
                    SizeFactor = 1,
                    IsUnicode = false,
                    PieceCharacters = ""
                });

                SerializedInfo.Instance.ChessFonts.Add(new ChessFont
                {
                    Name = "Burnett",
                    FontFamily = "Burnett",
                    SizeFactor = 1,
                    IsUnicode = false,
                    PieceCharacters = ""
                });

                SerializedInfo.Instance.ChessFonts.Add(new ChessFont
                {
                    Name = "Ivory",
                    FontFamily = "Ivory",
                    SizeFactor = 1,
                    IsUnicode = false,
                    PieceCharacters = ""
                });

                SerializedInfo.Instance.ChessFonts.Add(new ChessFont
                {
                    Name = "Merida",
                    FontFamily = "Merida",
                    SizeFactor = 1,
                    IsUnicode = false,
                    PieceCharacters = ""
                });

                SerializedInfo.Instance.ChessFonts.Add(new ChessFont
                {
                    Name = "Monk",
                    FontFamily = "Monk",
                    SizeFactor = 1,
                    IsUnicode = false,
                    PieceCharacters = ""
                });
            }
            else if (SerializedInfo.Instance.ChessFonts.Count > 2)
            {
                SerializedInfo.Instance.ChessFonts[0].Name = "Alpha";
                SerializedInfo.Instance.ChessFonts[0].FontFamily = "Alpha";
                SerializedInfo.Instance.ChessFonts[1].Name = "Burnett";
                SerializedInfo.Instance.ChessFonts[1].FontFamily = "Burnett";
                SerializedInfo.Instance.ChessFonts[2].Name = "Ivory";
                SerializedInfo.Instance.ChessFonts[2].FontFamily = "Ivory";
                SerializedInfo.Instance.ChessFonts[3].Name = "Merida";
                SerializedInfo.Instance.ChessFonts[3].FontFamily = "Merida";
                SerializedInfo.Instance.ChessFonts[4].Name = "Monk";
                SerializedInfo.Instance.ChessFonts[4].FontFamily = "Monk";
            }

            _engineDialog = new FormEngineManagement(SerializedInfo.Instance.EngineList);
            _engineDialog.EngineSelected += OnEngineSelected;

            _pieceDialog = new FormPieceSettings(SerializedInfo.Instance.ChessFonts, SerializedInfo.Instance.SelectedFontIndex);
            _pieceDialog.FontSelected += OnDialogFontSelected;
            _pieceDialog.PieceSettingAltered += OnPieceSettingAltered;

            _boardDialog = new FormBoardSetting();
            _boardDialog.BoardSettingAltered += OnBoardSettingAltered;

            _pgnoptionsDialog = new FormPgnOptions();
            _matchoptionsDialog = new FormMatchOptions();
            _bookoptionsDialog = new FormBookOptions();
            _gameoptionsDialog = new FormGameOptions();
            _aboutzentropyDialog = new FormAboutZentropy();
            _chessPanel.Invalidate();
        }

        public void WritePGNHeader()
        {
            string _event; 
            if (!File.Exists("games.pgn"))
                _event = "[Event " + "\"" + SerializedInfo.Instance.EventName +"\"" + "]\n";
            else
                _event = "\n\n[Event " + "\"" + SerializedInfo.Instance.EventName + "\"" + "]\n";
            string _site = "[Site " + "\"" + SerializedInfo.Instance.SiteName + "\"" + "]\n";
            string _date = "[Date " + "\"" + DateTime.Now.ToString("yyyy.MM.dd") + "\"" + "]\n";
            string _round = "[Round " + "\"" + SerializedInfo.Instance.RoundNumber + "\"" + "]\n";
            string _white = "[White " + "\"" + _vm.Engines[0]?.Name + "\"" + "]\n";
            string _black = "[Black " + "\"" + _vm.Engines[1]?.Name + "\"" + "]\n";
            string _setup = "[setup]\n";
            string _fen = "[fen]\n";
            string _result = "[result]\n\n";

            using (System.IO.StreamWriter file = new System.IO.StreamWriter("games.pgn", true))
            {
                file.Write(_event);
                file.Write(_site);
                file.Write(_date);
                file.Write(_round);
                file.Write(_white);
                file.Write(_black);
                if (SerializedInfo.Instance.UseBook)
                {
                    file.Write(_setup);
                    file.Write(_fen);
                }
                file.Write(_result);
            }
        }

        private void WriteMoveToPGN(string formattedMove)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("games.pgn", true))
            {
                file.Write(formattedMove);
            }
        }

        private void WriteInfoToPGN(string searchText, string replaceText)
        {
            string file_name = "games.pgn";

            if (System.IO.File.Exists(file_name) == true)
            {
                StreamReader reader = new StreamReader(file_name);
                string content = reader.ReadToEnd();
                reader.Close();

                content = Regex.Replace(content, searchText, replaceText);

                StreamWriter writer = new StreamWriter(file_name);
                writer.Write(content);
                writer.Close();
            }
            else
                return;
        }

        private void SerializeInfo()
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    SerializedInfo.Instance.Bounds = RestoreBounds;
                }
                else
                {
                    SerializedInfo.Instance.Bounds = Bounds;
                }

                SerializedInfo.Instance.SplitterDistanceMain = _splitContainerMain.SplitterDistance;
                SerializedInfo.Instance.SplitterDistance1 = _splitContainer1.SplitterDistance;
                SerializedInfo.Instance.SplitterDistance2 = _splitContainer2.SplitterDistance;

                SerializedInfo.Instance.IsMaximized = WindowState == FormWindowState.Maximized;
                SerializedInfo.Instance.BoardFlipped = _menuItemFlipBoard.Checked;
                SerializedInfo.Instance.SquareOutline = _menuItemOutlines.Checked;
                SerializedInfo.Instance.HideArrows = _menuItemHideArrows.Checked;
                SerializedInfo.Instance.HideBottomPanel = _menuItemHideOutputPanel.Checked;
                SerializedInfo.Instance.HideLeftPanel = _menuItemHideControlPanel.Checked;
                SerializedInfo.Instance.HideRightPanel = _menuItemHideEvalPanel.Checked;
                SerializedInfo.Instance.ShowExtendedMoveInfo = _menuItemShowExtendedMoveInfo.Checked;

                SerializedInfo.Instance.Sound = _menuItemSound.Checked;
                SerializedInfo.Instance.DarkMode = _menuItemDarkMode.Checked;
                SerializedInfo.Instance.DisplayLegalMoves = _menuItemDisplayLegalMoves.Checked;
                SerializedInfo.Instance.Coordinates = _menuItemCoordinates.Checked;
                SerializedInfo.Instance.BoardBorder = _menuItemBorder.Checked;

                EngineSetting selectedSetting1 = SerializedInfo.Instance.EngineList.SelectedSetting;
                EngineSetting selectedSetting2 = SerializedInfo.Instance.EngineList.SelectedOpponentSetting;

                SerializedInfo.Instance.EngineList.Settings = SerializedInfo.Instance.EngineList.Settings.OrderBy(c => c.Name).ToList();

                SerializedInfo.Instance.EngineList.SelectedIndex = SerializedInfo.Instance.EngineList.Settings.IndexOf(selectedSetting1);
                SerializedInfo.Instance.EngineList.SelectedOpponentIndex = SerializedInfo.Instance.EngineList.Settings.IndexOf(selectedSetting2);

                if (SerializedInfo.Instance.ChessFonts.Count > 5)
                {
                    ChessFont font0 = SerializedInfo.Instance.ChessFonts[0];
                    ChessFont font1 = SerializedInfo.Instance.ChessFonts[1];
                    ChessFont font2 = SerializedInfo.Instance.ChessFonts[2];
                    ChessFont font3 = SerializedInfo.Instance.ChessFonts[3];
                    ChessFont font4 = SerializedInfo.Instance.ChessFonts[4];

                    ChessFont selectedFont = SerializedInfo.Instance.SelectedChessFont;

                    SerializedInfo.Instance.ChessFonts.RemoveRange(0, 5);

                    SerializedInfo.Instance.ChessFonts = SerializedInfo.Instance.ChessFonts.OrderBy(c => c.Name).ToList();

                    SerializedInfo.Instance.ChessFonts.Insert(0, font0);
                    SerializedInfo.Instance.ChessFonts.Insert(0, font1);
                    SerializedInfo.Instance.ChessFonts.Insert(0, font2);
                    SerializedInfo.Instance.ChessFonts.Insert(0, font3);
                    SerializedInfo.Instance.ChessFonts.Insert(0, font4);

                    SerializedInfo.Instance.SelectedFontIndex = SerializedInfo.Instance.ChessFonts.IndexOf(selectedFont);
                }

                SerializedInfo.Instance.LastBookLine = _lastBookLine;
                SerializedInfo.Instance.CurrBookLine = _currBookLine;
                SerializedInfo.Instance.TotalBookLines = _totalBookLines;

                XmlSerializer serializer = new XmlSerializer(typeof(SerializedInfo));
                FileStream fileStream = new FileStream(FormMainViewModel.ConfigurationFileName, FileMode.Create);
                serializer.Serialize(fileStream, SerializedInfo.Instance);
                fileStream.Dispose();

                if (WindowState == FormWindowState.Maximized)
                {
                    SerializedInfo.Instance.Bounds = RestoreBounds;
                }
                else
                {
                    SerializedInfo.Instance.Bounds = Bounds;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void DeserializeInfo()
        {
            try
            {
                if (File.Exists(FormMainViewModel.ConfigurationFileName))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(SerializedInfo));
                    FileStream fileStream = new FileStream(FormMainViewModel.ConfigurationFileName, FileMode.Open);

                    SerializedInfo.Instance = (SerializedInfo)serializer.Deserialize(fileStream);
                    fileStream.Dispose();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

         private void ClearEngines()
        {
            for (int i = 0; i < _vm.Engines.Length; i++)
            {
                if (_vm.Engines[i] != null)
                {
                    _vm.Engines[i].Dispose();
                    _vm.Engines[i] = null;
                }
            }
        }

        private void EmptyEvaluationGrid()
        {
            for (int rowI = 0; rowI < _dataGridViewEvaluation.Rows.Count; rowI++)
            {
                for (int cellI = 0; cellI < _dataGridViewEvaluation.Rows[rowI].Cells.Count; cellI++)
                {
                    _dataGridViewEvaluation.Rows[rowI].Cells[cellI].Value = "";
                }
            }
        }

        private void UpdateUI()
        {
            UpdateWindowText();

            if (_evaluations == null || _evaluations[0] == null)
            {
                return;
            }

            _labelEngine0.Text = _vm.Engines[0]?.Name;
            _labelEngine1.Text = _vm.Engines[1]?.Name;

            if (File.Exists(_engineLogoPaths[0]))
            {
                Bitmap engine0bmp = new Bitmap(_engineLogoPaths[0]);
                _labelEngine0Logo.Image = engine0bmp;
            }
            else
            {
                this._labelEngine0Logo.Image = Resources.WhiteLogo;
            }

            if (File.Exists(_engineLogoPaths[1]))
            {
                Bitmap engine1bmp = new Bitmap(_engineLogoPaths[1]);
                _labelEngine1Logo.Image = engine1bmp;
            }
            else
            {
                this._labelEngine1Logo.Image = Properties.Resources.BlackLogo;
            }

            int depth = int.Parse(_evaluations[0][InfoType.Depth]);

            _labelDepth.Text = depth.ToString();
            _labelNodes.Text = FormatNumber(long.Parse(_evaluations[0][InfoType.Nodes]));
            _labelTime.Text = GetFormattedEngineInfo(InfoType.Time, _evaluations[0][InfoType.Time]);
            _labelNPS.Text = ToKiloFormat(int.Parse(_evaluations[0][InfoType.NPS]));

            string round = null;
            round = $"{SerializedInfo.Instance.RoundNumber}";
            round += $"/";
            round += $"{SerializedInfo.Instance.MatchGames}";
            _labelRound.Text = round;

            _labelBook.Text = "book.fen";

            if (SerializedInfo.Instance.Random)
                _labelOrder.Text = "Random";
            else
                _labelOrder.Text = "Sequential";

            string position = null;
            if (SerializedInfo.Instance.Random)
            {
                position = $"{_currBookLine}";
                position += $"/";
                position += $"{_totalBookLines}";
            }
            else
            {
                position = $"{_lastBookLine}";
                position += $"/";
                position += $"{_totalBookLines}";

            }
            _labelPosition.Text = position;

            _labelEngine0Name.Text = SerializedInfo.Instance.EngineList.SelectedSetting?.Name;
            _labelEngine1Name.Text = SerializedInfo.Instance.EngineList.SelectedOpponentSetting?.Name;

            _labelEngine0Wins.Text = _engineWins[0].ToString();
            _labelEngine1Wins.Text = _engineWins[1].ToString();
            _labelEngine0Draws.Text = _engineDraws[0].ToString();
            _labelEngine1Draws.Text = _engineDraws[1].ToString();
            _labelEngine0Losses.Text = _engineLosses[0].ToString();
            _labelEngine1Losses.Text = _engineLosses[1].ToString();
            _labelEngine0Points.Text = string.Format("{0:0.0}", _enginePoints[0]);
            _labelEngine1Points.Text = string.Format("{0:0.0}", _enginePoints[1]);
            _labelEngine0WinPercent.Text = string.Format("{0:0.00}", _engineWinPercent[0]);
            _labelEngine1WinPercent.Text = string.Format("{0:0.00}", _engineWinPercent[1]);

            if (double.IsNaN(0 / _engineLOS[0]) == false)
                _labelEngine0LOS.Text = string.Format("{0:0.00}", _engineLOS[0]);
            else
                _labelEngine0LOS.Text = string.Format("{0:0.00}", 0);
            if (double.IsNaN(0 / _engineLOS[1]) == false)
                _labelEngine1LOS.Text = string.Format("{0:0.00}", _engineLOS[1]);
            else
                _labelEngine1LOS.Text = string.Format("{0:0.00}", 0);

            int mateValue = -1;
            string scoreString = _evaluations[0][InfoType.Score];
            double pawnScore;

            ProcessScoreValue(scoreString, out int scoreValue, out bool isMate);

            if (isMate)
            {
                mateValue = scoreValue;

                if (mateValue > 0)
                {
                    _labelScore.Text = $"M{mateValue}";
                    _labelScore.ForeColor = Color.Green;
                }
                else
                {
                    _labelScore.Text = $"M{Math.Abs(mateValue)}";
                    _labelScore.ForeColor = Color.Red;
                }

                if (_vm.Game.WhoseTurn == ChessPlayer.Black && mateValue > 0 || _vm.Game.WhoseTurn == ChessPlayer.White && mateValue < 0)
                {
                    pawnScore = -200;
                }
                else
                {
                    pawnScore = 200;
                }
            }
            else
            {
                if (_vm.Game.WhoseTurn == ChessPlayer.Black)
                {
                    pawnScore = -(scoreValue / 100.0);
                }
                else
                {
                    pawnScore = scoreValue / 100.0;
                }

                if (pawnScore == 0)
                {
                    _labelScore.Text = " 0.00";
                }
                else
                {
                    _labelScore.Text = pawnScore.ToString("+0.00;-0.00");
                }

                _labelScore.ForeColor = CalculateEvaluationColor(-(scoreValue / 100.0));
            }

            if (!_vm.GameFinished)
            {
                if (FillPlyList(depth, pawnScore, isMate))
                {
                    UpdateMoveGridCell(isMate, pawnScore, depth);
                }
            }

            for (int iPV = 0; iPV < _evaluations.Length; iPV++)
            {
                if (_evaluations[iPV] == null)
                {
                    continue;
                }

                for (int iColumn = 0; iColumn < _columnOrder.Length; iColumn++)
                {
                    _dataGridViewEvaluation.Rows[iPV].Cells[iColumn].Value = GetFormattedEngineInfo(_columnOrder[iColumn], _evaluations[iPV][_columnOrder[iColumn]]);
                }
            }

            if (!_menuItemHideArrows.Checked)
            {
                for (int iPv = 0; iPv < _evaluations.Length; iPv++)
                {
                    if (_evaluations[iPv] == null)
                    {
                        continue;
                    }

                    scoreString = _evaluations[iPv][InfoType.Score];
                    ProcessScoreValue(scoreString, out scoreValue, out isMate);

                    if (isMate)
                    {
                        scoreValue = scoreValue * 20 + 12000;
                    }

                    if (iPv == 0 || (!isMate && _mainPvReference - scoreValue < _centipawnTolerance) || _engineEvalArrows.Count < 3)
                    {
                        if (iPv == 0)
                        {
                            _mainPvReference = scoreValue;
                        }

                        if (_engineEvalArrows.Count <= iPv)
                        {
                            _engineEvalArrows.Add(new MoveArrow(_evaluations[iPv][InfoType.PV]?.Substring(0, 4), 1.2, GetReferenceColor(scoreValue, _mainPvReference), true, true));
                        }
                        else
                        {
                            _engineEvalArrows[iPv].Move = _evaluations[iPv][InfoType.PV]?.Substring(0, 4);
                            _engineEvalArrows[iPv].Color = Color.FromArgb(100, GetReferenceColor(scoreValue, _mainPvReference));
                        }

                        if (iPv == 0)
                        {
                            _engineEvalArrows[iPv].Color = Color.FromArgb(100, Color.Green);
                        }
                    }
                }
            }
            else
                _chessPanel.Arrows.Clear();
        }

        private long GetRemainingTotalTime(int index)
        {
            long time = SerializedInfo.Instance.TimeControl.TotalTime - (int)_playerTimes[index].Elapsed.TotalMilliseconds + ((_vm.PlyList.Count - 1) / 2) * SerializedInfo.Instance.TimeControl.Increment;

            if (time < 1)
            {
                time = 1;
            }

            return time;
        }

        private long GetRemainingTimePerMove(int index)
        {
            long time = SerializedInfo.Instance.TimeControl.TimePerMove - (int)_playerTimes[index].Elapsed.TotalMilliseconds;

            if (time < 1)
            {
                time = SerializedInfo.Instance.TimeControl.TimePerMove;

                _playerTimes[0].Reset();
                _playerTimes[1].Reset();

                if (_vm.Game.WhoseTurn == ChessPlayer.White)
                {
                    _playerTimes[0].Start();
                }
                else
                {
                    _playerTimes[1].Start();
                }
            }
            return time;
        }

        private void UpdateWindowText()
        {
            string text = "Zentropy -";
                for (int i = 0; i < _vm.Engines.Length; i++)
                {
                    if (_vm.Engines[i] == null)
                    {
                        continue;
                    }

                    if (_vm.Engines[i].Name != null)
                    {
                        if (i == 0)
                            text += $" {_vm.Engines[i].Name} vs.";
                        else
                            text += $" {_vm.Engines[i].Name}";
                    }
                    else
                    {
                        text += $" {_vm.Engines[i].ExecutablePath}";
                    }
                }
            Text = text;
        }

        private void PlayMoveSound()
        {
            if (_menuItemSound.Checked)
            {
                if (_vm.Game.IsInCheck(ChessPlayer.Black) || _vm.Game.IsInCheck(ChessPlayer.White))
                    {
                    _checkPlayer.Play();
                }
                else if (_vm.Game.Moves[_vm.Game.Moves.Count - 1].IsCapture)
                {
                    _capturePlayer.Play();
                }
                else if (_vm.Game.Moves[_vm.Game.Moves.Count - 1].Castling != CastlingType.None)
                {
                    _castlingPlayer.Play();
                }
                else
                {
                    _movePlayer.Play();
                }
            }
        }

        private void PlayMove(string move)
        {
            Point[] points = _chessPanel.GetRelPositionsFromMoveString(move);
            PieceMovedEventArgs moveArgs = new PieceMovedEventArgs(points[0], points[1]);

            char? promotion = null;

            if (move.Length > 4 && move[4] != ' ')
            {
                promotion = move[4];
            }
            PlayMove(moveArgs, promotion);
        }

        private void AddMoveToPlyList(string moveString, string formattedMove)
        {
            if (_vm.NavigationIndex != _vm.PlyList.Count - 1)
            {
                _vm.PlyList.RemoveRange(_vm.NavigationIndex + 1, _vm.PlyList.Count - _vm.NavigationIndex - 1);
            }

            if (_evaluations != null && _evaluations.Length > 0 && _evaluations[0] != null)
            {
                double pawnScore;
                int depth = int.Parse(_evaluations[0][InfoType.Depth]);

                ProcessScoreValue(_evaluations[0][InfoType.Score], out int value, out bool isMate);

                if (isMate)
                {
                    if (_vm.Game.WhoseTurn == ChessPlayer.White && value > 0 || _vm.Game.WhoseTurn == ChessPlayer.Black && value < 0)
                    {
                        pawnScore = -200;
                    }
                    else
                    {
                        pawnScore = 200;
                    }
                }
                else
                {
                    if (_vm.Game.WhoseTurn == ChessPlayer.White)
                    {
                        pawnScore = -(value / 100.0);
                    }
                    else
                    {
                        pawnScore = value / 100.0;
                    }
                }

                if (!_vm.GameFinished)
                {
                    if (FillPlyList(depth, pawnScore, isMate))
                    {
                        UpdateMoveGridCell(isMate, pawnScore, depth);
                    }
                }
            }

            _vm.PlyList.Add(new ChessPly(_vm.Game.GetFen(), 0.0, moveString, formattedMove));
            _vm.NavigationIndex++;
        }

         private void ProcessEvaluation(Evaluation evaluation)
        {
            int multiPV;

            if (evaluation.Types.Contains(InfoType.MultiPV))
            {
                multiPV = int.Parse(evaluation[InfoType.MultiPV]);
            }
            else
            {
                multiPV = 1;
            }

            if (multiPV > SerializedInfo.Instance.MultiPv)
            {
                return;
            }

            for (int i = 0; i < _columnOrder.Length; i++)
            {
                if (multiPV - 1 >= 0 && multiPV - 1 < _evaluations.Length)
                {
                    _evaluations[multiPV - 1] = evaluation;
                }
            }
        }

        private void UpdateMoveGridCell(bool isMate, double pawnScore, int depth)
        {
            int cellIndex = _vm.NavigationIndex - 1;
            int rowIndex = cellIndex / 2;
            int columnIndex = cellIndex % 2;
            pgnMoveString = "";
			
            if (cellIndex >= 0 && _dataGridViewMoves.Rows.Count > rowIndex && _dataGridViewMoves.Rows[rowIndex].Cells.Count > columnIndex)
            {
                string formatEvaluation;

                if (isMate)
                {
                    formatEvaluation = "#";
                }
                else if (pawnScore == 0)
                {
                    formatEvaluation = "0.00";
                }
                else
                {
                    formatEvaluation = pawnScore.ToString("+0.00;-0.00");
                }

                string currentValue = (string)_dataGridViewMoves.Rows[rowIndex].Cells[columnIndex].Value;

                if (currentValue != null && depth > 0)
                {
                    if (_menuItemShowExtendedMoveInfo.Checked)
                    {
                        _dataGridViewMoves.Rows[rowIndex].Cells[columnIndex].Value = $"{currentValue.Substring(0, currentValue.IndexOf('{') + 1)}{formatEvaluation} D{depth}}}";
                        pgnMoveString = $"{currentValue.Substring(0, currentValue.IndexOf('{') + 1)}{formatEvaluation} D{depth}}}";
                        pgnMoveString += " ";
                    }
                    else
                    {
                        _dataGridViewMoves.Rows[rowIndex].Cells[columnIndex].Value = $"{currentValue}";
                        pgnMoveString = $"{currentValue}";
                        pgnMoveString += " ";
                    }
                }
            }
        }

        private void ProcessScoreValue(string scoreString, out int scoreValue, out bool isMate)
        {
            isMate = false;

            if (!int.TryParse(scoreString.Substring(3), out scoreValue))
            {
                if (!int.TryParse(scoreString.Substring(3, scoreString.IndexOf(' ', 3) - 3), out scoreValue))
                {
                    if (int.TryParse(scoreString.Substring(5, scoreString.IndexOf(' ', 5) - 5), out scoreValue))
                    {
                        isMate = true;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid score format.");
                    }
                }
            }
        }

        private void FillEvaluationGrid(int multiPV, Evaluation evaluation)
        {
            for (int iType = 0; iType < evaluation.Types.Length; iType++)
            {
                int columnIndex = -1;

                for (int iOrder = 0; iOrder < _columnOrder.Length; iOrder++)
                {
                    if (_columnOrder[iOrder] == evaluation.Types[iType])
                    {
                        columnIndex = iOrder;
                        break;
                    }
                }

                if (columnIndex != -1)
                {
                    if (_dataGridViewEvaluation.Rows.Count >= multiPV)
                    {
                        _dataGridViewEvaluation.Rows[multiPV - 1].Cells[columnIndex].Value = GetFormattedEngineInfo(evaluation.Types[iType], evaluation[iType]);
                    }
                }
            }
        }

        delegate void ToggleButtonAutoPlayBoxCallback(string text);

        private void ToggleButtonAutoPlay(string text)
        {
            if (_buttonAutoPlay.InvokeRequired)
            {
                ToggleButtonAutoPlayBoxCallback d = ToggleButtonAutoPlay;
                Invoke(d, new object[] { text });
            }
            else
            {
                _buttonAutoPlay.Text = text;
            }
        }

        delegate void DisplayResultBoxCallback(bool show);

        private void DisplayResultBox(bool show)
        {
            if (_panelResultBox.InvokeRequired)
            {
                DisplayResultBoxCallback d = DisplayResultBox;
                Invoke(d, new object[] { show });
            }
            else
            {
                _panelResultBox.Visible = show;
            }
        }

        private void NewGame(ChessGame newGame)
        {
            _gameOver = false;

            DisplayResultBox(false);

            bool wasFinished = _vm.GameFinished;
            _vm.Game.drawAdjudication = false;

            _evaluationEnabled = false;
            _analyzingMode = true;
            _computerPlayer = ChessPlayer.None;

            _playerTimes[0].Reset();
            _playerTimes[1].Reset();

            _vm.Game = newGame;
            _vm.PlyList.Clear();
            _vm.PlyList.Add(new ChessPly(_vm.Game.GetFen()));
            _vm.NavigationIndex = 0;
            _chessPanel.Game = _vm.Game;
            _chessPanel.HighlightedSquares.Clear();
            RemoveLastMoveArrow();
            _chessPanel.ClearIndicators();
            ClearDataGridRows();
            _movePlayed = true;

            ResetEvaluationData(SerializedInfo.Instance.MultiPv);

            Engine temp = _vm.Engines[0];
            _vm.Engines[0] = _vm.Engines[1];
            _vm.Engines[1] = temp;

            string tempPath = _engineLogoPaths[0];
            _engineLogoPaths[0] = _engineLogoPaths[1];
            _engineLogoPaths[1] = tempPath;
            
           _switched = !_switched;

            for (int i = 0; i < _vm.Engines.Length; i++)
            {
                if (_vm.Engines[i] == null)
                {
                    continue;
                }

                if (!wasFinished)
                {
                    _vm.Engines[i].RequestStop();
                }

                _vm.Engines[i].Query("ucinewgame");
            }

            if (wasFinished)
            {
                OnEngineStopped();
            }

            ToggleButtonAutoPlay("Start");
            _chessPanel.IsFlipped = _menuItemFlipBoard.Checked;
            _chessPanel.Invalidate();
        }

        private void OnMenuItemDarkModeClick(object sender, EventArgs e)
        {
            SerializedInfo.Instance.DarkMode = _menuItemDarkMode.Checked;
            SetDarkMode(this, SerializedInfo.Instance.DarkMode);
        }

        private void SetDarkMode(Control control, bool darkMode)
        {
            List<Control> controls = GetAllChildControls(control).ToList();
            controls.Add(this);

            List<ToolStripMenuItem> menuItems = GetMenuItems(_menuStripMain).ToList();

            for (int i = 0; i < controls.Count; i++)
            {
                if (darkMode)
                {
                    controls[i].BackColor = Color.Black;
                    controls[i].ForeColor = Color.White;
                }
                else
                {
                    controls[i].BackColor = (Color)controls[i].Tag;
                    controls[i].ForeColor = Color.Black;
                }

                if (controls[i] is DataGridView grid)
                {
                    if (darkMode)
                    {
                        grid.BorderStyle = BorderStyle.Fixed3D;					
                        grid.BackgroundColor = Color.Black;
                        grid.DefaultCellStyle.BackColor = Color.Black;
                        grid.DefaultCellStyle.ForeColor = Color.White;
                        grid.DefaultCellStyle.SelectionForeColor = Color.White;
                        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 227, 230).AlterRgb(150, false);
                    }
                    else
                    {
                        grid.BorderStyle = BorderStyle.FixedSingle;
                        grid.BackgroundColor = Color.White;
                        grid.DefaultCellStyle.BackColor = Color.White;
                        grid.DefaultCellStyle.ForeColor = Color.Black;
                        grid.DefaultCellStyle.SelectionForeColor = Color.Black;
                        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(222, 227, 230);
                    }
                }
            }

            if (darkMode)
            {
            }
            else
            {
                _buttonNewGame.ForeColor = Color.White;
                _buttonAutoPlay.ForeColor = Color.White;
                _buttonMoveNow.ForeColor = Color.White;
                _buttonExit.ForeColor = Color.White;
                _buttonCopyFEN.ForeColor = Color.White;
                _buttonPasteFEN.ForeColor = Color.White;
                _buttonFlipBoard.ForeColor = Color.White;
                _buttonSound.ForeColor = Color.White;
            }
            
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (darkMode)
                {
                    menuItems[i].BackColor = Color.Black;
                    menuItems[i].ForeColor = Color.White;
                }
                else
                {
                    menuItems[i].BackColor = Color.LightGray;
                    menuItems[i].ForeColor = Color.Black;
                }
            }
        }
        
        delegate void ClearDataGridRowsCallback();

        private void ClearDataGridRows()
            {
            if (_dataGridViewMoves.InvokeRequired)
                {
                ClearDataGridRowsCallback d = ClearDataGridRows;
                Invoke(d, new object[] { });
                }
            else
                {
                _dataGridViewMoves.Rows.Clear();
                }
            }

        private void ResetEvaluationData(int multiPV)
        {
            _evaluations = new Evaluation[multiPV];
        }

        private void ResetEvaluationGridRows(int newRowCount)
        {
            _dataGridViewEvaluation.Rows.Clear();

            for (int i = 0; i < newRowCount - 1; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int iCell = 0; iCell < _dataGridViewEvaluation.Columns.Count; iCell++)
                {
                    DataGridViewTextBoxCell textCell = new DataGridViewTextBoxCell
                    {
                        Value = string.Empty
                    };

                    row.Cells.Add(textCell);
                }

                _dataGridViewEvaluation.Rows.Add(row);
            }
        }

        private void ResetEvaluationGridColumns(InfoType[] columns)
        {
            _dataGridViewEvaluation.Rows.Clear();
            _dataGridViewEvaluation.Columns.Clear();

            for (int i = 0; i < columns.Length; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();

                if (columns[i] == InfoType.PV)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }

                column.HeaderText = columns[i].ToString();
                _dataGridViewEvaluation.Columns.Add(column);
            }
        }

        private void SetEngineViewElementsVisible(bool visible)
        {
            for (int i = 0; i < _engineViewElements.Length; i++)
            {
                _engineViewElements[i].Visible = visible;
            }
        }

        private void Navigate(int navigation, bool validate = true)
        {
            if (validate)
            {
                if (navigation == _vm.NavigationIndex || navigation >= _vm.PlyList.Count)
                {
                    return;
                }
            }

            bool wasFinished = _vm.GameFinished;
            _evaluationEnabled = false;
            _analyzingMode = true;

            _computerPlayer = ChessPlayer.None;

            _vm.NavigationIndex = navigation;

            _vm.Game = new ChessGame(_vm.CurrentPly.Fen);

            _chessPanel.Game = _vm.Game;
            _chessPanel.HighlightedSquares.Clear();
            RemoveLastMoveArrow();

            string currentMoveString = _vm.CurrentPly.Move;

            if (!string.IsNullOrEmpty(currentMoveString))
            {

                if (SerializedInfo.Instance.ArrowHighlight)
                {
                    AddMoveArrow(currentMoveString);
                }
                else
                {
                    Point[] squareLocations = _chessPanel.GetRelPositionsFromMoveString(currentMoveString);
                    _chessPanel.HighlightedSquares.AddRange(squareLocations);
                }
            }

            SelectMovesCell(navigation);

            _movePlayed = true;

            for (int i = 0; i < _vm.Engines.Length; i++)
            {
                if (_vm.Engines[i] == null)
                {
                    continue;
                }

                if (wasFinished)
                {
                    OnEngineStopped();
                }
                else
                {
                    _vm.Engines[i].RequestStop();
                }
            }
        }

        private void SelectMovesCell(int navIndex)
        {
            for (int i = 0; i < _dataGridViewMoves.SelectedCells.Count; i++)
            {
                _dataGridViewMoves.SelectedCells[i].Selected = false;
            }

            navIndex--;

            if (navIndex < 0)
            {
                if (_dataGridViewMoves.Rows.Count > 0 && _dataGridViewMoves.Rows[0].Cells.Count > 0)
                {
                    _dataGridViewMoves.CurrentCell = _dataGridViewMoves.Rows[0].Cells[0];
                }

                return;
            }
            else if (navIndex + 1 >= _vm.PlyList.Count)
            {
                navIndex = _vm.PlyList.Count - 2;
            }

            _dataGridViewMoves.Rows[navIndex / 2].Cells[navIndex % 2].Selected = true;
            _dataGridViewMoves.CurrentCell = _dataGridViewMoves.Rows[navIndex / 2].Cells[navIndex % 2];
        }

        private void UpdateMoveGrid(string formattedMove)
        {
            int cellCount = _dataGridViewMoves.GetCellCount(DataGridViewElementStates.None);
            int plyCount = _vm.PlyList.Count;

            for (int i = cellCount; i >= plyCount; i--)
            {
                if (i % 2 == 0)
                {
                    _dataGridViewMoves.Rows.RemoveAt(i / 2 - 1);
                }
                else
                {
                    _dataGridViewMoves.Rows[i / 2 - 1].Cells[1].Value = "";
                }
            }

            if (plyCount % 2 == 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell whiteMove = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell blackMove = new DataGridViewTextBoxCell();

                whiteMove.Value = (plyCount / 2) + ". " + formattedMove;

                if (GetPlayingEngine() != null)
                {
                    if (_menuItemShowExtendedMoveInfo.Checked)
                    {
                        whiteMove.Value += " {D0}";
                    }

                    if (SerializedInfo.Instance.SaveGames)
                    {
                        if (plyCount / 2 == 1)
                            WritePGNHeader();
                        WriteMoveToPGN(pgnMoveString);
                    }
                }

                row.Cells.Add(whiteMove);
                row.Cells.Add(blackMove);

                row.Height = 22;
                _dataGridViewMoves.Rows.Add(row);
            }
            else
            {
                _dataGridViewMoves.Rows[plyCount / 2 - 1].Cells[1].Value = formattedMove;

                if (GetPlayingEngine() != null)
                {
                    if (_menuItemShowExtendedMoveInfo.Checked)
                    {
                        _dataGridViewMoves.Rows[plyCount / 2 - 1].Cells[1].Value += " {D0}";
                    }
                    if (SerializedInfo.Instance.SaveGames)
                    {
                        WriteMoveToPGN(pgnMoveString);
                    }
                }
            }

            SelectMovesCell(_vm.NavigationIndex);
        }

        private void AddMenuItems(ToolStripMenuItem menuItem, List<ToolStripMenuItem> menuItems)
        {
            menuItems.Add(menuItem);

            foreach (ToolStripItem item in menuItem.DropDownItems)
            {
                if (item is ToolStripMenuItem)
                {
                    AddMenuItems((ToolStripMenuItem)item, menuItems);
                }
            }
        }

        private bool FillPlyList(int depth, double pawnScore, bool isMate)
        {
            if (_vm.PlyList.Count > 0 && _vm.PlyList.Count > _vm.NavigationIndex)
            {
                if (depth >= _vm.CurrentPly.EvaluationDepth || isMate)
                {
                    _vm.CurrentPly.Evaluation = pawnScore;
                    _vm.CurrentPly.EvaluationDepth = depth;

                    return true;
                }
            }

            return false;
        }

        private bool PlayMove(PieceMovedEventArgs args, char? promotion = null, bool silent = false)
        {
            BoardPosition sourcePosition = new BoardPosition((ChessFile)args.Position.X, Invert(args.Position.Y - 1, 7));
            BoardPosition destinationPosition = new BoardPosition((ChessFile)args.NewPosition.X, Invert(args.NewPosition.Y - 1, 7));
            ChessPiece movingPiece = _vm.Game.GetPieceAt(sourcePosition);

            if (movingPiece == null)
            {
                return false;
            }

            if (promotion == null)
            {
                promotion = CheckPromotion(sourcePosition, destinationPosition, movingPiece);
            }

            Move move = new Move(sourcePosition, destinationPosition, movingPiece.Owner, promotion);

            if (!_vm.Game.IsValidMove(move))
            {
                return false;
            }

            _evaluationEnabled = false;

            ReadOnlyCollection<Move> validMoves = _vm.Game.GetValidMoves(_vm.Game.WhoseTurn);
            MoveType moveType = _vm.Game.ApplyMove(move, true);

            if (SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TotalTime
                || SerializedInfo.Instance.TimeControl.SelectedTimeControlType == TimeControlType.TimePerMove)
            {
                if (_vm.Game.WhoseTurn == ChessPlayer.White)
                {
                    if (_buttonAutoPlay.Text == "Stop")
                        _playerTimes[0].Start();
                    _playerTimes[1].Stop();
                }
                else
                {
                    if (_buttonAutoPlay.Text == "Stop")
                        _playerTimes[1].Start();
                    _playerTimes[0].Stop();
                }
            }

            if (SerializedInfo.Instance.DrawAdjudicationEnable == true)
            {
                if (Math.Abs(_vm.LatestPly.Evaluation) * 100 < SerializedInfo.Instance.DrawAdjudicationScore)
                {
                    _drawMoves++;
                    if (_drawMoves == SerializedInfo.Instance.DrawAdjudicationMoves)
                    {
                        _vm.Game.drawAdjudication = true;
                    }
                }
                else
                {
                    _vm.Game.drawAdjudication = false;
                    _drawMoves = 0;
                }
            }

            if (SerializedInfo.Instance.ResignAdjudicationEnable == true)
            {
                if (_vm.LatestPly.Evaluation * 100 <= -SerializedInfo.Instance.ResignAdjudicationScore)
                {
                    _resignMoves++;
                    if (_resignMoves == SerializedInfo.Instance.ResignAdjudicationMoves)
                    {
                        _vm.Game.resignAdjudication = true;
                        _resignAdjudicationBlack = true;
                    }
                }
                else if (_vm.LatestPly.Evaluation * 100 >= SerializedInfo.Instance.ResignAdjudicationScore)
                {
                    _resignMoves++;
                    if (_resignMoves == SerializedInfo.Instance.ResignAdjudicationMoves)
                    {
                        _vm.Game.resignAdjudication = true;
                        _resignAdjudicationWhite = true;
                    }
                }
                else
                {
                    _resignMoves = 0;
                    _vm.Game.resignAdjudication = false;
                    _resignAdjudicationWhite = false;
                    _resignAdjudicationBlack = false;
                }
            }

            if (!silent)
            {
                PlayMoveSound();
            }

            _chessPanel.ClearIndicators();

            if (SerializedInfo.Instance.ArrowHighlight)
            {
                RemoveLastMoveArrow();
                AddMoveArrow(move.ToString(""));
            }
            else
            {
                _chessPanel.HighlightedSquares.Clear();
                _chessPanel.HighlightedSquares.Add(args.Position);
                _chessPanel.HighlightedSquares.Add(args.NewPosition);
            }

            string formattedMove = GetFormattedMove(move, moveType, validMoves);
            AddMoveToPlyList(move.ToString(""), formattedMove);
            UpdateMoveGrid(formattedMove);

            if (_vm.Game.IsCheckmated(_vm.Game.WhoseTurn))
            {
                _vm.LatestPly.Evaluation = _vm.Game.IsCheckmated(ChessPlayer.White) ? -120 : 120;
            }

            for (int i = 0; i < _evaluations.Length; i++)
            {
                _evaluations[i] = null;
            }

            _chessPanel.Invalidate();
            _movePlayed = true;

            return true;
        }

        private bool SetupEngine(EngineSetting engineSetting, int index, bool startAnalysis)
        {
            Engine engine = null;

            if (SerializedInfo.Instance.EngineList.SettingAvailable)
            {
                if (File.Exists(engineSetting?.ExecutablePath))
                {
                    engine = new Engine(engineSetting.ExecutablePath);

                    for (int i = 0; i < engineSetting.UciOptions.Length; i++)
                    {
                        engine.Query(engineSetting.UciOptions[i]);
                    }
                }
            }

            if (engine != null)
            {
                engine.EvaluationReceived += OnEvaluationReceived;
                engine.BestMoveFound += OnBestMoveFound;
                engine.Query($"setoption name MultiPv value {SerializedInfo.Instance.MultiPv}");
                engine.Query("ucinewgame");

                if (startAnalysis)
                {
                    engine.Query($"position fen {_vm.Game.GetFen()}");
                    engine.Query("go infinite");
                }

                _vm.Engines[index] = engine;

                return true;
            }
            else
            {
                return false;
            }
        }

        private char CheckPromotion(BoardPosition source, BoardPosition destination, ChessPiece movingPiece)
        {
            if (_vm.Game.WhoseTurn != _computerPlayer)
            {
                if (movingPiece is Pawn &&
                    source.Rank == (movingPiece.Owner == ChessPlayer.White ? 7 : 2) &&
                    destination.Rank == (movingPiece.Owner == ChessPlayer.White ? 8 : 1))
                {
                    FormPromotion dialog = new FormPromotion(movingPiece.Owner);
                    dialog.ShowDialog();

                    return dialog.PromotionCharacter;
                }
            }

            return 'q';
        }

        private int Round(double number)
        {
            return (int)Math.Round(number, 0);
        }

        private int Invert(int value, int range)
        {
            return Math.Abs(value - range);
        }

        private string GetFormattedMove(Move move, MoveType moveType, ReadOnlyCollection<Move> legalMoves)
        {
            ChessPiece piece = _vm.Game.GetPieceAt(move.NewPosition);
            char pieceCharacter = piece.GetFENLetter().ToString().ToUpperInvariant()[0];
            string formatMove = "";

            if (moveType == (MoveType.Castling | MoveType.Move))
            {
                if (move.NewPosition.File == ChessFile.G)
                {
                    formatMove = "O-O";
                }
                else
                {
                    formatMove = "O-O-O";
                }

                return formatMove;
            }

            if (pieceCharacter != 'P' && moveType != (MoveType.Move | MoveType.Promotion) && moveType != (MoveType.Move | MoveType.Capture | MoveType.Promotion))
            {
                formatMove += pieceCharacter;

                for (int i = 0; i < legalMoves.Count; i++)
                {
                    ChessPiece legalPiece = _vm.Game.GetPieceAt(legalMoves[i].OriginalPosition);

                    if (legalMoves[i].NewPosition.Equals(move.NewPosition) &&
                        !legalMoves[i].OriginalPosition.Equals(move.OriginalPosition) &&
                        legalPiece.GetFENLetter() == piece.GetFENLetter())
                    {

                        if (legalMoves[i].OriginalPosition.File != move.OriginalPosition.File)
                        {
                            formatMove += move.OriginalPosition.File.ToString().ToLowerInvariant();
                        }
                        else
                        {
                            formatMove += move.OriginalPosition.Rank.ToString();
                        }
                    }
                }
            }
            else if (moveType == (MoveType.Move | MoveType.Capture) || moveType == (MoveType.Move | MoveType.Capture | MoveType.Promotion))
            {
                formatMove += move.OriginalPosition.File.ToString().ToLowerInvariant();
            }

            if (moveType == (MoveType.Move | MoveType.Capture) || moveType == (MoveType.Move | MoveType.Capture | MoveType.Promotion))
            {
                formatMove += 'x';
            }

            formatMove += move.NewPosition.ToString();

            if (moveType == (MoveType.Move | MoveType.Promotion) || moveType == (MoveType.Move | MoveType.Capture | MoveType.Promotion))
            {
                formatMove += "=" + ((char)move.Promotion).ToString().ToUpperInvariant();
            }

            if (_vm.Game.IsCheckmated(ChessPlayer.Black) || _vm.Game.IsCheckmated(ChessPlayer.White))
            {
                formatMove += '#';
            }
            else if (_vm.Game.IsInCheck(ChessPlayer.Black) || _vm.Game.IsInCheck(ChessPlayer.White))
            {
                formatMove += '+';
            }

            return formatMove;
        }

        private string ToKiloFormat(long number)
        {
            if (number >= 10000)
            {
                return (number / 1000D).ToString("#,##0") + " k";
            }

            return number.ToString("#");
        }

        private string GetFormattedEngineInfo(InfoType type, string data)
        {
            switch (type)
            {
                case InfoType.Time:
                    return TimeSpan.FromMilliseconds(int.Parse(data)).ToString(@"m\:ss");

                case InfoType.Nodes:
                case InfoType.NPS:
                case InfoType.TBHits:
                    return ToKiloFormat(long.Parse(data));
            }

            return data;
        }

        private string GetFormattedDrawReason(Adjudication reason)
        {
            switch (reason)
            {
                case Adjudication.Repetition:
                    return "Threefold Repetition";
                case Adjudication.FiftyMoveRule:
                    return "Fifty-Move Rule";
                case Adjudication.Stalemate:
                    return "Stalemate";
                case Adjudication.InsufficientMaterial:
                    return "Insufficient Material";
                case Adjudication.Draw:
                    return "Draw Adjudication";
                case Adjudication.Resign:
                    return "Resign Adjudication";
            }

            return null;
        }

        private string FormatNumber(long number)
        {
            if (number >= 100000000000)
            {
                return (number / 1000000000).ToString("#,0 B");
            }

            if (number >= 10000000000)
            {
                return (number / 1000000000).ToString("0.#") + " B";
            }

            if (number >= 100000000)
            {
                return (number / 1000000).ToString("#,0 M");
            }

            if (number >= 10000000)
            {
                return (number / 1000000).ToString("0.#") + " M";
            }

            if (number >= 100000)
            {
                return (number / 1000).ToString("#,0 k");
            }

            if (number >= 10000)
            {
                return (number / 1000).ToString("0.#") + " k";
            }

            return number.ToString("#,0");
        }

        private Color GetReferenceColor(int centiPawn, int reference)
        {
            if (centiPawn > reference)
            {
                centiPawn = reference;
            }

            int difference = reference - centiPawn;
            double relativeDiff = difference / 45.0;

            if (relativeDiff > 2)
            {
                relativeDiff = 2;
            }

            int red = 0;
            int green = 255;

            if (relativeDiff - 1 < 0)
            {
                red += (int)(relativeDiff * 255.0);
            }
            else
            {
                red = 255;
                green -= (int)((relativeDiff - 1) * 255.0);
            }

            return Color.FromArgb(red, green, 0);
        }

        private Color CalculateEvaluationColor(double evaluation)
        {
            double range = 3;

            if (evaluation > range)
            {
                evaluation = range;
            }
            else if (evaluation < -range)
            {
                evaluation = -range;
            }

            double fraction = evaluation / range * 0.5;
            double x = 0.5 + fraction;

            return Color.FromArgb((int)(x * 255), (int)((1 - x) * 255), 0);
        }

        private Engine GetPlayingEngine()
        {
            return _vm.Engines[(int)_vm.Game.WhoseTurn];
        }

        private IEnumerable<Control> GetAllChildControls(Control control)
        {
            IEnumerable<Control> controls = control.Controls.Cast<Control>();
            return controls.SelectMany(c => GetAllChildControls(c)).Concat(controls);
        }

        private List<ToolStripMenuItem> GetMenuItems(MenuStrip menuStrip)
        {
            List<ToolStripMenuItem> myItems = new List<ToolStripMenuItem>();

            foreach (var menuItem in menuStrip.Items)
            {
                if (menuItem is ToolStripMenuItem)
                {
                    AddMenuItems((ToolStripMenuItem)menuItem, myItems);
                }
            }

            return myItems;
        }

        #endregion

        private void SetTimeControl()
        {
            switch (SerializedInfo.Instance.TimeControl.SelectedTimeControlType)
            {
                case TimeControlType.FixedDepth:
				case TimeControlType.TimePerMove:
                case TimeControlType.Infinite:
                case TimeControlType.Nodes:
                    for (int i = 0; i < _playerTimes.Length; i++)
                    {
                        _playerTimes[i].Reset();
                    }
                    break;
                case TimeControlType.TotalTime:
                    break;
            }
        }

        private void OnMenuItemAlterTimeControlClick(object sender, EventArgs e)
        {
            var levelDialog = new FormTimeControlDialog(SerializedInfo.Instance.TimeControl);
            if (levelDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            SerializedInfo.Instance.TimeControl = levelDialog.TimeControl;
            SetTimeControl();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private string GetOpeningFen()
        {
            int count = 0;
            int numLines = 0;
            int randLineNumber = 0;
            string file_name = "book.fen";
            string fen_string = null;

            if (System.IO.File.Exists(file_name) == true)
            {
                foreach (string line in File.ReadLines(@"book.fen", System.Text.Encoding.UTF8))
                    numLines++;

                if (SerializedInfo.Instance.Random)
                {
                    randLineNumber = RandomNumber(0, numLines);

                    foreach (string line in File.ReadLines(@"book.fen", System.Text.Encoding.UTF8))
                    {
                        count++;

                        if (line == "")
                        {
                            return null;
                        }

                        if (count == randLineNumber)
                        {
                            _currBookLine = count;
                            fen_string = String.Copy(line);
                            break;
                        }
                    }
                }
                else
                {
                    _lastBookLine++;
                    foreach (string line in File.ReadLines(@"book.fen", System.Text.Encoding.UTF8))
                    {
                        count++;
                        if (line == "")
                        {
                            return null;
                        }
                        if (count == _lastBookLine)
                        {
                            fen_string = String.Copy(line);
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("File not found: " + file_name + "\n\n"
                    + "Please copy " + file_name + " to the Zentropy program directory,\n"
                    + "or choose: Book - Options from the top menu\n"
                    + "to create an opening book or disable book usage.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
 
            if (_lastBookLine == numLines)
                _lastBookLine = 0;
            _totalBookLines = numLines;
            return fen_string;
        }
    }
}