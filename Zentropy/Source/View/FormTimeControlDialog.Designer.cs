namespace Zentropy.View
{
    partial class FormTimeControlDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimeControlDialog));
            this._groupBoxMode = new System.Windows.Forms.GroupBox();
            this._radioButtonNodeLimit = new System.Windows.Forms.RadioButton();
            this._radioButtonInfinite = new System.Windows.Forms.RadioButton();
            this._radioButtonTimeInc = new System.Windows.Forms.RadioButton();
            this._radioButtonTimePerMove = new System.Windows.Forms.RadioButton();
            this._radioButtonDepthLimit = new System.Windows.Forms.RadioButton();
            this._groupBoxModeSetting = new System.Windows.Forms.GroupBox();
            this._panelNodes = new System.Windows.Forms.Panel();
            this._Nodes = new System.Windows.Forms.NumericUpDown();
            this._labelNodes = new System.Windows.Forms.Label();
            this._panelTimePerMove = new System.Windows.Forms.Panel();
            this._textBoxTimePerMove = new System.Windows.Forms.TextBox();
            this._labelTimePerMoveSeconds = new System.Windows.Forms.Label();
            this._labelTimePerMove = new System.Windows.Forms.Label();
            this._panelFixedDepth = new System.Windows.Forms.Panel();
            this._textBoxPlies = new System.Windows.Forms.TextBox();
            this._labelPlies = new System.Windows.Forms.Label();
            this._panelTotalTime = new System.Windows.Forms.Panel();
            this._textBoxIncrement = new System.Windows.Forms.TextBox();
            this._textBoxTotalTimeSeconds = new System.Windows.Forms.TextBox();
            this._textBoxTotalTimeMinutes = new System.Windows.Forms.TextBox();
            this._labelIncrementSeconds = new System.Windows.Forms.Label();
            this._labelIncrement = new System.Windows.Forms.Label();
            this._labelTotalTimeSeconds = new System.Windows.Forms.Label();
            this._labelTotalTimeMinutes = new System.Windows.Forms.Label();
            this._labelTotalTime = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonOk = new System.Windows.Forms.Button();
            this._toolTipTimeInc = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipDepthLimit = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipTimePerMove = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipNodeLimit = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipInfinite = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipNodes = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxMode.SuspendLayout();
            this._groupBoxModeSetting.SuspendLayout();
            this._panelNodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Nodes)).BeginInit();
            this._panelTimePerMove.SuspendLayout();
            this._panelFixedDepth.SuspendLayout();
            this._panelTotalTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // _groupBoxMode
            // 
            this._groupBoxMode.Controls.Add(this._radioButtonNodeLimit);
            this._groupBoxMode.Controls.Add(this._radioButtonInfinite);
            this._groupBoxMode.Controls.Add(this._radioButtonTimeInc);
            this._groupBoxMode.Controls.Add(this._radioButtonTimePerMove);
            this._groupBoxMode.Controls.Add(this._radioButtonDepthLimit);
            this._groupBoxMode.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupBoxMode.Location = new System.Drawing.Point(18, 14);
            this._groupBoxMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxMode.Name = "_groupBoxMode";
            this._groupBoxMode.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxMode.Size = new System.Drawing.Size(150, 223);
            this._groupBoxMode.TabIndex = 0;
            this._groupBoxMode.TabStop = false;
            this._groupBoxMode.Text = "Mode";
            // 
            // _radioButtonNodeLimit
            // 
            this._radioButtonNodeLimit.AutoSize = true;
            this._radioButtonNodeLimit.Location = new System.Drawing.Point(23, 138);
            this._radioButtonNodeLimit.Name = "_radioButtonNodeLimit";
            this._radioButtonNodeLimit.Size = new System.Drawing.Size(105, 22);
            this._radioButtonNodeLimit.TabIndex = 4;
            this._radioButtonNodeLimit.TabStop = true;
            this._radioButtonNodeLimit.Text = "Node Limit";
            this._toolTipNodeLimit.SetToolTip(this._radioButtonNodeLimit, "Nodes per move = <nodes>");
            this._radioButtonNodeLimit.UseVisualStyleBackColor = true;
            this._radioButtonNodeLimit.CheckedChanged += new System.EventHandler(this.RadioButtonTimeControlsCheckedChanged);
            // 
            // _radioButtonInfinite
            // 
            this._radioButtonInfinite.AutoSize = true;
            this._radioButtonInfinite.Location = new System.Drawing.Point(23, 169);
            this._radioButtonInfinite.Name = "_radioButtonInfinite";
            this._radioButtonInfinite.Size = new System.Drawing.Size(75, 22);
            this._radioButtonInfinite.TabIndex = 3;
            this._radioButtonInfinite.TabStop = true;
            this._radioButtonInfinite.Text = "Infinite";
            this._toolTipInfinite.SetToolTip(this._radioButtonInfinite, "No limit");
            this._radioButtonInfinite.UseVisualStyleBackColor = true;
            this._radioButtonInfinite.CheckedChanged += new System.EventHandler(this.RadioButtonTimeControlsCheckedChanged);
            // 
            // _radioButtonTimeInc
            // 
            this._radioButtonTimeInc.AutoSize = true;
            this._radioButtonTimeInc.Location = new System.Drawing.Point(23, 45);
            this._radioButtonTimeInc.Name = "_radioButtonTimeInc";
            this._radioButtonTimeInc.Size = new System.Drawing.Size(111, 22);
            this._radioButtonTimeInc.TabIndex = 2;
            this._radioButtonTimeInc.TabStop = true;
            this._radioButtonTimeInc.Text = "Time + Inc.";
            this._toolTipTimeInc.SetToolTip(this._radioButtonTimeInc, "Base time plus increment (Fischer delay)");
            this._radioButtonTimeInc.UseVisualStyleBackColor = true;
            this._radioButtonTimeInc.CheckedChanged += new System.EventHandler(this.RadioButtonTimeControlsCheckedChanged);
            // 
            // _radioButtonTimePerMove
            // 
            this._radioButtonTimePerMove.AutoSize = true;
            this._radioButtonTimePerMove.Location = new System.Drawing.Point(23, 107);
            this._radioButtonTimePerMove.Name = "_radioButtonTimePerMove";
            this._radioButtonTimePerMove.Size = new System.Drawing.Size(102, 22);
            this._radioButtonTimePerMove.TabIndex = 1;
            this._radioButtonTimePerMove.TabStop = true;
            this._radioButtonTimePerMove.Text = "Time Limit";
            this._toolTipTimePerMove.SetToolTip(this._radioButtonTimePerMove, "Time per move = <time> sec(s)");
            this._radioButtonTimePerMove.UseVisualStyleBackColor = true;
            this._radioButtonTimePerMove.CheckedChanged += new System.EventHandler(this.RadioButtonTimeControlsCheckedChanged);
            // 
            // _radioButtonDepthLimit
            // 
            this._radioButtonDepthLimit.AutoSize = true;
            this._radioButtonDepthLimit.Location = new System.Drawing.Point(23, 76);
            this._radioButtonDepthLimit.Name = "_radioButtonDepthLimit";
            this._radioButtonDepthLimit.Size = new System.Drawing.Size(110, 22);
            this._radioButtonDepthLimit.TabIndex = 0;
            this._radioButtonDepthLimit.TabStop = true;
            this._radioButtonDepthLimit.Text = "Depth Limit";
            this._toolTipDepthLimit.SetToolTip(this._radioButtonDepthLimit, "Depth per move = <depth> plies");
            this._radioButtonDepthLimit.UseVisualStyleBackColor = true;
            this._radioButtonDepthLimit.CheckedChanged += new System.EventHandler(this.RadioButtonTimeControlsCheckedChanged);
            // 
            // _groupBoxModeSetting
            // 
            this._groupBoxModeSetting.Controls.Add(this._panelNodes);
            this._groupBoxModeSetting.Controls.Add(this._panelTimePerMove);
            this._groupBoxModeSetting.Controls.Add(this._panelFixedDepth);
            this._groupBoxModeSetting.Controls.Add(this._panelTotalTime);
            this._groupBoxModeSetting.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupBoxModeSetting.Location = new System.Drawing.Point(189, 14);
            this._groupBoxModeSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxModeSetting.Name = "_groupBoxModeSetting";
            this._groupBoxModeSetting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._groupBoxModeSetting.Size = new System.Drawing.Size(247, 223);
            this._groupBoxModeSetting.TabIndex = 1;
            this._groupBoxModeSetting.TabStop = false;
            this._groupBoxModeSetting.Text = "Details";
            // 
            // _panelNodes
            // 
            this._panelNodes.Controls.Add(this._Nodes);
            this._panelNodes.Controls.Add(this._labelNodes);
            this._panelNodes.Location = new System.Drawing.Point(5, 23);
            this._panelNodes.Name = "_panelNodes";
            this._panelNodes.Size = new System.Drawing.Size(235, 190);
            this._panelNodes.TabIndex = 8;
            // 
            // _Nodes
            // 
            this._Nodes.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._Nodes.Location = new System.Drawing.Point(12, 39);
            this._Nodes.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this._Nodes.Name = "_Nodes";
            this._Nodes.Size = new System.Drawing.Size(166, 26);
            this._Nodes.TabIndex = 5;
            this._Nodes.ThousandsSeparator = true;
            // 
            // _labelNodes
            // 
            this._labelNodes.AutoSize = true;
            this._labelNodes.Location = new System.Drawing.Point(8, 13);
            this._labelNodes.Name = "_labelNodes";
            this._labelNodes.Size = new System.Drawing.Size(55, 18);
            this._labelNodes.TabIndex = 1;
            this._labelNodes.Text = "Nodes";
            // 
            // _panelTimePerMove
            // 
            this._panelTimePerMove.Controls.Add(this._textBoxTimePerMove);
            this._panelTimePerMove.Controls.Add(this._labelTimePerMoveSeconds);
            this._panelTimePerMove.Controls.Add(this._labelTimePerMove);
            this._panelTimePerMove.Location = new System.Drawing.Point(6, 23);
            this._panelTimePerMove.Name = "_panelTimePerMove";
            this._panelTimePerMove.Size = new System.Drawing.Size(235, 190);
            this._panelTimePerMove.TabIndex = 6;
            // 
            // _textBoxTimePerMove
            // 
            this._textBoxTimePerMove.Location = new System.Drawing.Point(11, 39);
            this._textBoxTimePerMove.Name = "_textBoxTimePerMove";
            this._textBoxTimePerMove.Size = new System.Drawing.Size(117, 26);
            this._textBoxTimePerMove.TabIndex = 5;
            // 
            // _labelTimePerMoveSeconds
            // 
            this._labelTimePerMoveSeconds.AutoSize = true;
            this._labelTimePerMoveSeconds.Location = new System.Drawing.Point(133, 43);
            this._labelTimePerMoveSeconds.Name = "_labelTimePerMoveSeconds";
            this._labelTimePerMoveSeconds.Size = new System.Drawing.Size(83, 18);
            this._labelTimePerMoveSeconds.TabIndex = 4;
            this._labelTimePerMoveSeconds.Text = "second(s)";
            // 
            // _labelTimePerMove
            // 
            this._labelTimePerMove.AutoSize = true;
            this._labelTimePerMove.Location = new System.Drawing.Point(7, 13);
            this._labelTimePerMove.Name = "_labelTimePerMove";
            this._labelTimePerMove.Size = new System.Drawing.Size(90, 18);
            this._labelTimePerMove.TabIndex = 3;
            this._labelTimePerMove.Text = "Move Time";
            // 
            // _panelFixedDepth
            // 
            this._panelFixedDepth.Controls.Add(this._textBoxPlies);
            this._panelFixedDepth.Controls.Add(this._labelPlies);
            this._panelFixedDepth.Location = new System.Drawing.Point(6, 23);
            this._panelFixedDepth.Name = "_panelFixedDepth";
            this._panelFixedDepth.Size = new System.Drawing.Size(235, 190);
            this._panelFixedDepth.TabIndex = 5;
            // 
            // _textBoxPlies
            // 
            this._textBoxPlies.Location = new System.Drawing.Point(11, 39);
            this._textBoxPlies.Name = "_textBoxPlies";
            this._textBoxPlies.Size = new System.Drawing.Size(117, 26);
            this._textBoxPlies.TabIndex = 6;
            // 
            // _labelPlies
            // 
            this._labelPlies.AutoSize = true;
            this._labelPlies.Location = new System.Drawing.Point(7, 13);
            this._labelPlies.Name = "_labelPlies";
            this._labelPlies.Size = new System.Drawing.Size(141, 18);
            this._labelPlies.TabIndex = 1;
            this._labelPlies.Text = "Plies (half moves)";
            // 
            // _panelTotalTime
            // 
            this._panelTotalTime.Controls.Add(this._textBoxIncrement);
            this._panelTotalTime.Controls.Add(this._textBoxTotalTimeSeconds);
            this._panelTotalTime.Controls.Add(this._textBoxTotalTimeMinutes);
            this._panelTotalTime.Controls.Add(this._labelIncrementSeconds);
            this._panelTotalTime.Controls.Add(this._labelIncrement);
            this._panelTotalTime.Controls.Add(this._labelTotalTimeSeconds);
            this._panelTotalTime.Controls.Add(this._labelTotalTimeMinutes);
            this._panelTotalTime.Controls.Add(this._labelTotalTime);
            this._panelTotalTime.Location = new System.Drawing.Point(6, 23);
            this._panelTotalTime.Name = "_panelTotalTime";
            this._panelTotalTime.Size = new System.Drawing.Size(235, 190);
            this._panelTotalTime.TabIndex = 7;
            // 
            // _textBoxIncrement
            // 
            this._textBoxIncrement.Location = new System.Drawing.Point(11, 158);
            this._textBoxIncrement.Name = "_textBoxIncrement";
            this._textBoxIncrement.Size = new System.Drawing.Size(117, 26);
            this._textBoxIncrement.TabIndex = 15;
            // 
            // _textBoxTotalTimeSeconds
            // 
            this._textBoxTotalTimeSeconds.Location = new System.Drawing.Point(11, 81);
            this._textBoxTotalTimeSeconds.Name = "_textBoxTotalTimeSeconds";
            this._textBoxTotalTimeSeconds.Size = new System.Drawing.Size(117, 26);
            this._textBoxTotalTimeSeconds.TabIndex = 14;
            // 
            // _textBoxTotalTimeMinutes
            // 
            this._textBoxTotalTimeMinutes.Location = new System.Drawing.Point(11, 39);
            this._textBoxTotalTimeMinutes.Name = "_textBoxTotalTimeMinutes";
            this._textBoxTotalTimeMinutes.Size = new System.Drawing.Size(117, 26);
            this._textBoxTotalTimeMinutes.TabIndex = 13;
            // 
            // _labelIncrementSeconds
            // 
            this._labelIncrementSeconds.AutoSize = true;
            this._labelIncrementSeconds.Location = new System.Drawing.Point(133, 161);
            this._labelIncrementSeconds.Name = "_labelIncrementSeconds";
            this._labelIncrementSeconds.Size = new System.Drawing.Size(83, 18);
            this._labelIncrementSeconds.TabIndex = 12;
            this._labelIncrementSeconds.Text = "second(s)";
            // 
            // _labelIncrement
            // 
            this._labelIncrement.AutoSize = true;
            this._labelIncrement.Location = new System.Drawing.Point(7, 132);
            this._labelIncrement.Name = "_labelIncrement";
            this._labelIncrement.Size = new System.Drawing.Size(84, 18);
            this._labelIncrement.TabIndex = 10;
            this._labelIncrement.Text = "Increment";
            // 
            // _labelTotalTimeSeconds
            // 
            this._labelTotalTimeSeconds.AutoSize = true;
            this._labelTotalTimeSeconds.Location = new System.Drawing.Point(133, 84);
            this._labelTotalTimeSeconds.Name = "_labelTotalTimeSeconds";
            this._labelTotalTimeSeconds.Size = new System.Drawing.Size(83, 18);
            this._labelTotalTimeSeconds.TabIndex = 9;
            this._labelTotalTimeSeconds.Text = "second(s)";
            // 
            // _labelTotalTimeMinutes
            // 
            this._labelTotalTimeMinutes.AutoSize = true;
            this._labelTotalTimeMinutes.Location = new System.Drawing.Point(133, 46);
            this._labelTotalTimeMinutes.Name = "_labelTotalTimeMinutes";
            this._labelTotalTimeMinutes.Size = new System.Drawing.Size(81, 18);
            this._labelTotalTimeMinutes.TabIndex = 6;
            this._labelTotalTimeMinutes.Text = "minute(s)";
            // 
            // _labelTotalTime
            // 
            this._labelTotalTime.AutoSize = true;
            this._labelTotalTime.Location = new System.Drawing.Point(7, 13);
            this._labelTotalTime.Name = "_labelTotalTime";
            this._labelTotalTime.Size = new System.Drawing.Size(85, 18);
            this._labelTotalTime.TabIndex = 1;
            this._labelTotalTime.Text = "Base Time";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(221, 256);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(104, 30);
            this._buttonCancel.TabIndex = 3;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(331, 256);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(104, 30);
            this._buttonOk.TabIndex = 4;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // FormTimeControlDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 305);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._groupBoxModeSetting);
            this.Controls.Add(this._groupBoxMode);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormTimeControlDialog";
            this.Text = "TimeControl";
            this._groupBoxMode.ResumeLayout(false);
            this._groupBoxMode.PerformLayout();
            this._groupBoxModeSetting.ResumeLayout(false);
            this._panelNodes.ResumeLayout(false);
            this._panelNodes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Nodes)).EndInit();
            this._panelTimePerMove.ResumeLayout(false);
            this._panelTimePerMove.PerformLayout();
            this._panelFixedDepth.ResumeLayout(false);
            this._panelFixedDepth.PerformLayout();
            this._panelTotalTime.ResumeLayout(false);
            this._panelTotalTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxMode;
        private System.Windows.Forms.RadioButton _radioButtonNodeLimit;
        private System.Windows.Forms.RadioButton _radioButtonInfinite;
        private System.Windows.Forms.RadioButton _radioButtonTimeInc;
        private System.Windows.Forms.RadioButton _radioButtonTimePerMove;
        private System.Windows.Forms.RadioButton _radioButtonDepthLimit;
        private System.Windows.Forms.GroupBox _groupBoxModeSetting;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Panel _panelFixedDepth;
        private System.Windows.Forms.Panel _panelTimePerMove;
        private System.Windows.Forms.Label _labelTimePerMoveSeconds;
        private System.Windows.Forms.Label _labelTimePerMove;
        private System.Windows.Forms.Label _labelPlies;
        private System.Windows.Forms.Panel _panelTotalTime;
        private System.Windows.Forms.Label _labelIncrementSeconds;
        private System.Windows.Forms.Label _labelIncrement;
        private System.Windows.Forms.Label _labelTotalTimeSeconds;
        private System.Windows.Forms.Label _labelTotalTimeMinutes;
        private System.Windows.Forms.Label _labelTotalTime;
        private System.Windows.Forms.Panel _panelNodes;
        private System.Windows.Forms.NumericUpDown _Nodes;
        private System.Windows.Forms.Label _labelNodes;
        private System.Windows.Forms.TextBox _textBoxIncrement;
        private System.Windows.Forms.TextBox _textBoxTotalTimeSeconds;
        private System.Windows.Forms.TextBox _textBoxTotalTimeMinutes;
        private System.Windows.Forms.TextBox _textBoxTimePerMove;
        private System.Windows.Forms.TextBox _textBoxPlies;
        private System.Windows.Forms.ToolTip _toolTipTimeInc;
        private System.Windows.Forms.ToolTip _toolTipDepthLimit;
        private System.Windows.Forms.ToolTip _toolTipTimePerMove;
        private System.Windows.Forms.ToolTip _toolTipNodeLimit;
        private System.Windows.Forms.ToolTip _toolTipInfinite;
        private System.Windows.Forms.ToolTip _toolTipNodes;
    }
}