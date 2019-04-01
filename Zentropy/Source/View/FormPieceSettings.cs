using Zentropy.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zentropy.View
{
    public partial class FormPieceSettings : Form
    {
        private List<ChessFont> _chessFonts;
        private bool _initialGradient;
        public event Action FontSelected;
        private bool _applied;
        public event Action PieceSettingAltered;

        #region Constructors

        public FormPieceSettings(List<ChessFont> chessFonts, int selectedIndex)
        {

            _chessFonts = chessFonts;

            if (selectedIndex < 0)
            {
                selectedIndex = 0;
            }

            InitializeComponent();
            _listBoxSettings.SetDoubleBuffered();
            UpdateList(selectedIndex);

            InstalledFontCollection fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
            {
                _comboBoxSelectFont.Items.Add(fonts.Families[i].Name);
            }
        }

        #endregion

        #region Methods

        private void OnCheckBoxGradientCheckedChanged(object sender, EventArgs e)
        {
            SerializedInfo.Instance.Gradient = _checkBoxGradient.Checked;
            PieceSettingAltered?.Invoke();
        }
        private void OnPieceSettingsDialogFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_applied)
            {
                SerializedInfo.Instance.Gradient = _initialGradient;
                PieceSettingAltered?.Invoke();
            }
            else
            {
                _applied = false;
            }
        }

        private void OnPieceSettingsDialogShown(object sender, EventArgs e)
        {
            _initialGradient = SerializedInfo.Instance.Gradient;
            _checkBoxGradient.Checked = _initialGradient;
        }

        private void UpdateList(int initialSelect)
        {
            _listBoxSettings.Items.Clear();

            for (int i = 0; i < _chessFonts.Count; i++)
            {
                _listBoxSettings.Items.Add(_chessFonts[i].Name);
            }

            _listBoxSettings.SelectedIndex = initialSelect;
            OpenFontConfig(_listBoxSettings.SelectedIndex);
        }

        private void OnListBoxConfigsSelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFontConfig(_listBoxSettings.SelectedIndex);
        }

        private void OpenFontConfig(int index)
        {
            if (index < 0)
            {
                index = 0;
            }

            bool notDefault = index > 4;

            _textBoxName.Enabled = notDefault;
            _buttonRemove.Enabled = notDefault;

            ChessFont font = (ChessFont)_chessFonts[index];

            _textBoxName.Text = font.Name;
            _textBoxScaleFactor.Text = font.SizeFactor.ToString();
            _textBoxFontChars.Text = font.PieceCharacters;
            _checkBoxUnicodeFont.Checked = font.IsUnicode;
            _comboBoxSelectFont.Text = font.FontFamily;

            SerializedInfo.Instance.SelectedFontIndex = index;
            FontSelected?.Invoke();
        }

        private void OnButtonApplyClick(object sender, EventArgs e)
        {
            string name = _textBoxName.Text;
            ChessFont font = (ChessFont)_chessFonts[_listBoxSettings.SelectedIndex];
            bool nameChanged = name != font.Name;

            if (nameChanged && _listBoxSettings.Items.Contains(name))
            {
                MessageBox.Show(this, "Setting with this name already exists.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(_textBoxScaleFactor.Text, out double factor))
            {
                font.SizeFactor = factor;
            }

            if (_listBoxSettings.SelectedIndex != 0)
            {
                if (nameChanged)
                {
                    font.Name = name;
                    UpdateList(_listBoxSettings.SelectedIndex);
                }

                font.IsUnicode = _checkBoxUnicodeFont.Checked;
                font.FontFamily = _comboBoxSelectFont.Text;
                font.PieceCharacters = _textBoxFontChars.Text;
            }
            FontSelected?.Invoke();
            _applied = true;
        }

        private void OnButtonOkClick(object sender, EventArgs e)
        {
            _applied = true;
            Close();
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnCheckBoxUnicodeFontCheckedChanged(object sender, EventArgs e)
        {
            if (_checkBoxUnicodeFont.Checked)
            {
                _textBoxFontChars.Enabled = false;
            }
            else
            {
                _textBoxFontChars.Enabled = true;
            }
        }

        private void OnComboBoxFontTextChanged(object sender, EventArgs e)
        {
            if (FontExists(_comboBoxSelectFont.Text, FontStyle.Regular) && _comboBoxSelectFont.Text != "")
            {
                _textBoxFontChars.Font = new Font(_comboBoxSelectFont.Text, _textBoxFontChars.Font.Size);

                if (((ChessFont)_chessFonts[_listBoxSettings.SelectedIndex]).PieceCharacters == "")
                {
                    _textBoxFontChars.Text = (string)_textBoxFontChars.Tag;
                }
            }
            else
            {
                _textBoxFontChars.Text = "";
            }
        }

        private void OnButtonRemoveClick(object sender, EventArgs e)
        {
            int selected = _listBoxSettings.SelectedIndex;

            SerializedInfo.Instance.ChessFonts.RemoveAt(selected);

            _listBoxSettings.Items.RemoveAt(selected);
            _listBoxSettings.SelectedIndex = selected - 1;
        }

        private bool FontExists(string fontFamilyName, FontStyle fontStyle)
        {
            bool result;

            try
            {
                using (FontFamily family = new FontFamily(fontFamilyName))
                {
                    result = family.IsStyleAvailable(fontStyle);
                }
            }
            catch (ArgumentException)
            {
                result = false;
            }

            return result;
        }

        private void OnButtonAddNewClick(object sender, EventArgs e)
        {
            ChessFont newFont = new ChessFont();

            string name = _textBoxName.Text;

            bool warn = false;

            while (_listBoxSettings.Items.Contains(name))
            {
                if (warn)
                {
                    MessageBox.Show(this, "Setting with this name already exists.", "Zentropy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    warn = true;
                }

                string input = Interaction.InputBox("Enter new name for setting:", "Zentropy - Setting name");

                if (string.IsNullOrWhiteSpace(input))
                {
                    return;
                }
                else
                {
                    name = input;
                }
            }

            if (double.TryParse(_textBoxScaleFactor.Text, out double factor))
            {
                newFont.SizeFactor = factor;
            }
            else
            {
                newFont.SizeFactor = 1;
            }

            newFont.Name = name;
            newFont.IsUnicode = _checkBoxUnicodeFont.Checked;
            newFont.FontFamily = _comboBoxSelectFont.Text;
            newFont.PieceCharacters = _textBoxFontChars.Text;

            SerializedInfo.Instance.ChessFonts.Add(newFont);
            SerializedInfo.Instance.SelectedFontIndex = SerializedInfo.Instance.ChessFonts.Count - 1;

            _listBoxSettings.Items.Add(newFont.Name);
            _listBoxSettings.SelectedIndex = _listBoxSettings.Items.Count - 1;

            FontSelected?.Invoke();
        }

        #endregion

    }
}
