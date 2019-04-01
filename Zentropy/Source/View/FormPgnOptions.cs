using Zentropy.Model;
using Zentropy.ViewModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zentropy.View
{
    public partial class FormPgnOptions : Form
    {

        #region Fields
        #endregion

        #region Events

        #endregion

        #region Constructors

        public FormPgnOptions()
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
                SerializedInfo.Instance.SiteName = _textBoxSite.Text;
                SerializedInfo.Instance.EventName = _textBoxEvent.Text;
                SerializedInfo.Instance.SaveGames = _checkBoxSaveGames.Checked;

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
            _textBoxSite.Text = SerializedInfo.Instance.SiteName;
            _textBoxEvent.Text = SerializedInfo.Instance.EventName;
            _checkBoxSaveGames.Checked = SerializedInfo.Instance.SaveGames;
        }
        #endregion
    }
}
