using Zentropy.Model;
using Zentropy.ViewModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zentropy.View
{
    public partial class FormGameOptions : Form
    {

        #region Fields

        #endregion

        #region Events

        #endregion

        #region Constructors

        public FormGameOptions()
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
                SerializedInfo.Instance.DrawAdjudicationEnable = _checkBoxDrawAdjudicationEnable.Checked;

                Int32.TryParse(_textBoxDrawAdjudicationScore.Text, out int u);
                SerializedInfo.Instance.DrawAdjudicationScore = u;

                Int32.TryParse(_textBoxDrawAdjudicationMoves.Text, out int w);
                SerializedInfo.Instance.DrawAdjudicationMoves = w;


                SerializedInfo.Instance.ResignAdjudicationEnable = _checkBoxResignAdjudicationEnable.Checked;

                Int32.TryParse(_textBoxResignAdjudicationScore.Text, out int x);
                SerializedInfo.Instance.ResignAdjudicationScore = x;

                Int32.TryParse(_textBoxResignAdjudicationMoves.Text, out int z);
                SerializedInfo.Instance.ResignAdjudicationMoves = z;


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
            _checkBoxDrawAdjudicationEnable.Checked = SerializedInfo.Instance.DrawAdjudicationEnable;
            _textBoxDrawAdjudicationScore.Text = SerializedInfo.Instance.DrawAdjudicationScore.ToString();
            _textBoxDrawAdjudicationMoves.Text = SerializedInfo.Instance.DrawAdjudicationMoves.ToString();

            _checkBoxResignAdjudicationEnable.Checked = SerializedInfo.Instance.ResignAdjudicationEnable;
            _textBoxResignAdjudicationScore.Text = SerializedInfo.Instance.ResignAdjudicationScore.ToString();
            _textBoxResignAdjudicationMoves.Text = SerializedInfo.Instance.ResignAdjudicationMoves.ToString();
        }
        #endregion
    }
}
