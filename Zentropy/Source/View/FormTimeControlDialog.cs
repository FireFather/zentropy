using Zentropy.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Zentropy.View
{
    public partial class FormTimeControlDialog : Form
    {
        public TimeControl TimeControl { get; }

        private TimeControlType _selectedTimeControlType = TimeControlType.Infinite;
        private readonly Panel[] _panels;

        public FormTimeControlDialog(TimeControl initialTimeControl)
        {
            TimeControl = initialTimeControl;

            InitializeComponent();

            var radioButtons = new[]
            {
                _radioButtonDepthLimit,
                _radioButtonTimePerMove,
                _radioButtonTimeInc,
                _radioButtonInfinite,
                _radioButtonNodeLimit
            };

            _panels = new[]
            {
                _panelFixedDepth,
                _panelTimePerMove,
                _panelTotalTime,
                null,
                _panelNodes,
            };

            for (var i = 0; i < radioButtons.Length; i++)
            {
                radioButtons[i].Tag = i;

                if (_panels[i] != null)
                {
                    _panels[i].Tag = i;
                }
            }

            var totalTime = TimeSpan.FromMilliseconds(TimeControl.TotalTime);

            _textBoxPlies.Text = TimeControl.Plies.ToString();
            _textBoxTimePerMove.Text = TimeSpan.FromMilliseconds(TimeControl.TimePerMove).TotalSeconds.ToString(CultureInfo.CurrentCulture);
            _textBoxTotalTimeMinutes.Text = Math.Floor(totalTime.TotalMinutes).ToString(CultureInfo.CurrentCulture);
            _textBoxTotalTimeSeconds.Text = totalTime.Seconds.ToString();
            _textBoxIncrement.Text = TimeSpan.FromMilliseconds(TimeControl.Increment).TotalSeconds.ToString(CultureInfo.CurrentCulture);
            _Nodes.Value = TimeControl.Nodes;

            radioButtons[(int)TimeControl.SelectedTimeControlType].Checked = true;
        }

        private void HidePanels()
        {
            for (int i = 0; i < _panels.Length; i++)
            {
                if (_panels[i] != null)
                {
                    _panels[i].Visible = false;
                }
            }
        }

        private void RadioButtonTimeControlsCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                HidePanels();
                _groupBoxModeSetting.Text = radioButton.Text;
                _selectedTimeControlType = (TimeControlType)(int)radioButton.Tag;

                if (_panels[(int)radioButton.Tag] == null)
                {
                    return;
                }

                _panels[(int)radioButton.Tag].Visible = true;
            }
        }

        private void OnButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnButtonOkClick(object sender, EventArgs e)
        {

            if (int.TryParse(_textBoxPlies.Text, out int plies))
            {
                TimeControl.Plies = plies;
            }

            if (double.TryParse(_textBoxTimePerMove.Text, out double timePerMove))
            {
                TimeControl.TimePerMove = (int)TimeSpan.FromSeconds(timePerMove).TotalMilliseconds;
            }

            if(int.TryParse(_textBoxTotalTimeMinutes.Text, out int totalMinutes) &&
                int.TryParse(_textBoxTotalTimeSeconds.Text, out int totalSeconds))
            {
                TimeSpan totalTime = new TimeSpan(0, totalMinutes, totalSeconds);
                TimeControl.TotalTime = (int)totalTime.TotalMilliseconds;
            }

            if(double.TryParse(_textBoxIncrement.Text, out double increment))
            {
                TimeControl.Increment = (int)TimeSpan.FromSeconds(increment).TotalMilliseconds;
            }

            TimeControl.Nodes = (int)_Nodes.Value;
            TimeControl.SelectedTimeControlType = _selectedTimeControlType;

            DialogResult = DialogResult.OK;
        }
    }
}
