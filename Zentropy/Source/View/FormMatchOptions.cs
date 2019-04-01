using Zentropy.Model;
using Zentropy.ViewModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zentropy.View
{
    public partial class FormMatchOptions : Form
    {

        #region Fields

        #endregion

        #region Events

        #endregion

        #region Constructors

        public FormMatchOptions()
        {
            InitializeComponent();
            LoadInfo();
        }

        #endregion

        #region Event Methods
    
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
                Int32.TryParse(_textBoxMatchGames.Text, out int x);
                SerializedInfo.Instance.MatchGames = x;

                Int32.TryParse(_textBoxRound.Text, out int y);
                SerializedInfo.Instance.RoundNumber = y;

                Int32.TryParse(_textBoxPause.Text, out int z);
                SerializedInfo.Instance.Pause = z;

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
            _textBoxMatchGames.Text = SerializedInfo.Instance.MatchGames.ToString();
            _textBoxRound.Text = SerializedInfo.Instance.RoundNumber.ToString();
            _textBoxPause.Text = SerializedInfo.Instance.Pause.ToString();
        }
        #endregion

        private void _labelSeconds_Click(object sender, EventArgs e)
        {

        }
    }
}
