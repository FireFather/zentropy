using Zentropy.Model;
using Zentropy.ViewModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Zentropy.View
{
    public partial class FormAboutZentropy : Form
    {

        #region Fields
        #endregion

        #region Events

        #endregion

        #region Constructors

        public FormAboutZentropy()
        {
            InitializeComponent();
            LoadInfo();
        }

        #endregion

        #region Event Methods
    
        private void OnButtonOkClick(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Other Methods
        private void LoadInfo()

        {
        }
        #endregion

        private void _labelDescription1_Click(object sender, EventArgs e)
        {

        }

        private void FormAboutZentropy_Load(object sender, EventArgs e)
        {

        }
    }
}
