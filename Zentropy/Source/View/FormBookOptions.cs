using Zentropy.Model;
using Zentropy.ViewModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Diagnostics;

namespace Zentropy.View
{
    public partial class FormBookOptions : Form
    {

        #region Fields

        #endregion

        #region Events

        #endregion

        #region Constructors

        public FormBookOptions()
        {
            InitializeComponent();
            LoadInfo();
        }

        #endregion

        #region Event Methods

        private void OnButtonPgnPathDialogClick(object sender, EventArgs e)
        {
            string initialDirectory = null;

            for (int i = 0; i < SerializedInfo.Instance.EngineList.LastExePaths.Count; i++)
            {
                string path = SerializedInfo.Instance.EngineList.LastExePaths[i];

                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    initialDirectory = fileInfo.Directory.FullName;
                    break;
                }
                else if (Directory.Exists(path))
                {
                    initialDirectory = path;
                    break;
                }
            }

            OpenFileDialog fileDialog = new OpenFileDialog();

            if (initialDirectory != null)
            {
                fileDialog.InitialDirectory = initialDirectory;
            }

            fileDialog.Filter = "PGN files (*.pgn)|*.pgn|All files (*.*)|*.*";
            fileDialog.Multiselect = false;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _comboBoxPgnPath.Text = fileDialog.FileName;
            }
        }

        private void OnButtonCreateClick(object sender, EventArgs e)
        {
            string arg1 = _comboBoxPgnPath.Text;
            string arg2 = _textBoxPgnDepth.Text;
            const string arg3 = "--nomovenumbers";
            const string arg4 = "--noresults";
            const string arg5 = "--notags";
            const string arg6 = "-C";
            const string arg7 = "-F";
            const string arg8 = "-obook.fen";
            const string arg9 = "outU.pgn";

            ProcessStartInfo startInfoTruncate = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = "truncate.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = " " + arg1 + " " + arg2
            };

            try
            {
                using (Process exeProcess = Process.Start(startInfoTruncate))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
            }

            ProcessStartInfo startInfoBook = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                FileName = "book.exe",
                WindowStyle = ProcessWindowStyle.Hidden,
                Arguments = " " + arg3 + " " + arg4 + " " + arg5 + " " + arg6 + " " + arg7 + " " + arg8 + " " + arg9
            };

            try
            {
                using (Process exeProcess = Process.Start(startInfoBook))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
            }
            MessageBox.Show("Success\n\n\n"
                + "book.fen created from " + _comboBoxPgnPath.Text + " (" + _textBoxPgnDepth.Text + " plies)",
                "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnButtonOkClick(object sender, EventArgs e)
        {
            SerializeInfo();
            Close();
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void SerializeInfo()
        {
            try
            {
                SerializedInfo.Instance.UseBook = _checkBoxUseBook.Checked;
                SerializedInfo.Instance.Random = _checkBoxRandom.Checked;

                XmlSerializer serializer = new XmlSerializer(typeof(SerializedInfo));
                FileStream fileStream = new FileStream(FormMainViewModel.ConfigurationFileName, FileMode.Create);
                serializer.Serialize(fileStream, SerializedInfo.Instance);
                fileStream.Dispose();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        #endregion

        #region Other Methods
        private void LoadInfo()
        {
            _checkBoxUseBook.Checked = SerializedInfo.Instance.UseBook;
            _checkBoxRandom.Checked = SerializedInfo.Instance.Random;
        }
        #endregion
    }
}
