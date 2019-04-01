using Zentropy.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zentropy.View
{
    public partial class FormBoardSetting : Form
    {
        private bool _initialBorderHighlight;
        private bool _initialNoHighlight;
        private bool _initialArrowHighlight;
        private bool _initialUseSquareImages;
        private bool _applied;

        private int _opacity;

        private string _initialDarkSquarePath;
        private string _initialLightSquarePath;
        private Color _initialDarkSquareColor;
        private Color _initialLightSquareColor;
        private Color _initialHighlightLastmoveColor;

        public event Action BoardSettingAltered;

        #region Constructors

        public FormBoardSetting()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void OnButtonDarkSquareColorClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog { Color = _buttonDarkSquare.BackColor };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _buttonDarkSquare.BackColor = Color.FromArgb(_opacity, colorDialog.Color);
                SerializedInfo.Instance.DarkSquareColor = Color.FromArgb(_opacity, colorDialog.Color);
                BoardSettingAltered?.Invoke();
            }
        }

        private void OnButtonLightSquareColorClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = _buttonLightSquare.BackColor
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _buttonLightSquare.BackColor = Color.FromArgb(_opacity, colorDialog.Color);
                SerializedInfo.Instance.LightSquareColor = Color.FromArgb(_opacity, colorDialog.Color);
                BoardSettingAltered?.Invoke();
            }
        }

        private void OnButtonHighlightLastmoveColorClick(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = _buttonLastmove.BackColor
            };

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _buttonLastmove.BackColor = Color.FromArgb(_opacity, colorDialog.Color);
                SerializedInfo.Instance.HighlightLastmoveColor = Color.FromArgb(_opacity, colorDialog.Color);
                BoardSettingAltered?.Invoke();
            }
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

        private void OnBoardSettingDialogFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_applied)
            {
                SerializedInfo.Instance.DarkSquareColor = _initialDarkSquareColor;
                SerializedInfo.Instance.LightSquareColor = _initialLightSquareColor;
                SerializedInfo.Instance.HighlightLastmoveColor = _initialHighlightLastmoveColor;

                SerializedInfo.Instance.BorderHighlight = _initialBorderHighlight;
                SerializedInfo.Instance.NoHighlight = _initialNoHighlight;
                SerializedInfo.Instance.ArrowHighlight = _initialArrowHighlight;
                SerializedInfo.Instance.UseSquareImages = _initialUseSquareImages;
                SerializedInfo.Instance.DarkSquarePath = _initialDarkSquarePath;
                SerializedInfo.Instance.LightSquarePath = _initialLightSquarePath;
                BoardSettingAltered?.Invoke();
            }
            else
            {
                Int32.TryParse(_textBoxOpacity.Text, out int x);
                SerializedInfo.Instance.Opacity = x;
                _applied = false;
            }
        }

        private void OnBoardSettingDialogShown(object sender, EventArgs e)
        {
            _initialDarkSquareColor = SerializedInfo.Instance.DarkSquareColor;
            _initialLightSquareColor = SerializedInfo.Instance.LightSquareColor;
            _initialHighlightLastmoveColor = SerializedInfo.Instance.HighlightLastmoveColor;
            _textBoxOpacity.Text = SerializedInfo.Instance.Opacity.ToString();
            _opacity = SerializedInfo.Instance.Opacity;

            _initialBorderHighlight = SerializedInfo.Instance.BorderHighlight;
            _initialNoHighlight = SerializedInfo.Instance.NoHighlight;
            _initialArrowHighlight = SerializedInfo.Instance.ArrowHighlight;
            _initialUseSquareImages = SerializedInfo.Instance.UseSquareImages;
            _initialLightSquarePath = SerializedInfo.Instance.LightSquarePath;
            _initialDarkSquarePath = SerializedInfo.Instance.DarkSquarePath;

            _buttonDarkSquare.BackColor = _initialDarkSquareColor;
            _buttonLightSquare.BackColor = _initialLightSquareColor;
            _buttonLastmove.BackColor = _initialHighlightLastmoveColor;
            _checkBoxUseSquareImages.Checked = _initialUseSquareImages;
            _textBoxDarkSquarePath.Text = _initialDarkSquarePath;
            _textBoxLightSquarePath.Text = _initialLightSquarePath;

            if (_initialNoHighlight)
            {
                _radioButtonNoHighlight.Checked = true;
            }
            else if (_initialBorderHighlight)
            {
                _radioButtonBorderHighlight.Checked = true;
            }
            else if (_initialArrowHighlight)
            {
                _radioButtonArrowHighlight.Checked = true;
            }
            else
            {
                _radioButtonFillHighlight.Checked = true;
            }

            ApplyUseImagesUi(_initialUseSquareImages);
        }

        #endregion

        private void OnCheckBoxUseSquareImagesCheckedChanged(object sender, EventArgs e)
        {
            bool useImages = _checkBoxUseSquareImages.Checked;

            SerializedInfo.Instance.UseSquareImages = useImages;
            BoardSettingAltered?.Invoke();

            ApplyUseImagesUi(useImages);
        }

        private void ApplyUseImagesUi(bool useImages)
        {
            _labelDarkSquarePath.Enabled = useImages;
            _labelLightSquarePath.Enabled = useImages;
            _labelShowDarkSquareColor.Enabled = !useImages;
            _labelShowLightSquareColor.Enabled = !useImages;

            _buttonDarkSquare.Enabled = !useImages;
            _buttonLightSquare.Enabled = !useImages;
            _buttonLastmove.Enabled = !useImages;
        }

        private void OnTextBoxOpacityTextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(_textBoxOpacity.Text, out int x);
            SerializedInfo.Instance.Opacity = x;
            _opacity = x;
            BoardSettingAltered?.Invoke();
        }

        private void OnTextBoxDarkSquarePathTextChanged(object sender, EventArgs e)
        {
            SerializedInfo.Instance.DarkSquarePath = _textBoxDarkSquarePath.Text;
            BoardSettingAltered?.Invoke();
        }

        private void OnTextBoxLightSquarePathTextChanged(object sender, EventArgs e)
        {
            SerializedInfo.Instance.LightSquarePath = _textBoxLightSquarePath.Text;
            BoardSettingAltered?.Invoke();
        }

        private void OnButtonDarkDialogClick(object sender, EventArgs e)
        {
            string path = RequestPath("Zentropy - Choose dark square image", _textBoxDarkSquarePath.Text);

            if (path != null)
            {
                _textBoxDarkSquarePath.Text = path;
            }
        }

        private void OnButtonLightDialogClick(object sender, EventArgs e)
        {
            string path = RequestPath("Zentropy - Choose light square image", _textBoxLightSquarePath.Text);

            if (path != null)
            {
                _textBoxLightSquarePath.Text = path;
            }
        }

        private string RequestPath(string title, string initialPath)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = initialPath,
                Multiselect = false,
                Title = title
            };

            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }

        private void OnRadioButtonNoHighlightCheckedChanged(object sender, EventArgs e)
        {
            if (!_radioButtonNoHighlight.Checked)
            {
                return;
            }

            SerializedInfo.Instance.NoHighlight = true;
            SerializedInfo.Instance.BorderHighlight = false;
            SerializedInfo.Instance.ArrowHighlight = false;
            BoardSettingAltered?.Invoke();
        }

        private void OnRadioButtonFillCheckedChanged(object sender, EventArgs e)
        {
            if (!_radioButtonFillHighlight.Checked)
            {
                return;
            }

            SerializedInfo.Instance.NoHighlight = false;
            SerializedInfo.Instance.BorderHighlight = false;
            SerializedInfo.Instance.ArrowHighlight = false;
            BoardSettingAltered?.Invoke();
        }

        private void OnRadioButtonBorderHighlightCheckedChanged(object sender, EventArgs e)
        {
            if (!_radioButtonBorderHighlight.Checked)
            {
                return;
            }

            SerializedInfo.Instance.NoHighlight = false;
            SerializedInfo.Instance.ArrowHighlight = false;
            SerializedInfo.Instance.BorderHighlight = true;
            BoardSettingAltered?.Invoke();
        }

        private void OnRadioButtonArrowCheckedChanged(object sender, EventArgs e)
        {
            if (!_radioButtonArrowHighlight.Checked)
            {
                return;
            }

            SerializedInfo.Instance.NoHighlight = false;
            SerializedInfo.Instance.ArrowHighlight = true;
            SerializedInfo.Instance.BorderHighlight = false;
            BoardSettingAltered?.Invoke();
        }
    }
}
