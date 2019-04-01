namespace Zentropy.View
{
    partial class FormMatchOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
//        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMatchOptions));
            this._buttonOk = new System.Windows.Forms.Button();
            this._labelMatchGames = new System.Windows.Forms.Label();
            this._textBoxMatchGames = new System.Windows.Forms.TextBox();
            this._textBoxRound = new System.Windows.Forms.TextBox();
            this._labelRound = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._textBoxPause = new System.Windows.Forms.TextBox();
            this._labelGames = new System.Windows.Forms.Label();
            this._labelBetween = new System.Windows.Forms.Label();
            this._labelSeconds = new System.Windows.Forms.Label();
            this._groupBox1Match = new System.Windows.Forms.GroupBox();
            this._label1Pause = new System.Windows.Forms.Label();
            this._toolTipMatchGames = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipRound = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipPause = new System.Windows.Forms.ToolTip(this.components);
            this._groupBox1Match.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(342, 238);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(114, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _labelMatchGames
            // 
            this._labelMatchGames.AutoSize = true;
            this._labelMatchGames.Location = new System.Drawing.Point(17, 35);
            this._labelMatchGames.Margin = new System.Windows.Forms.Padding(0);
            this._labelMatchGames.Name = "_labelMatchGames";
            this._labelMatchGames.Size = new System.Drawing.Size(62, 17);
            this._labelMatchGames.TabIndex = 6;
            this._labelMatchGames.Text = "Games:";
            // 
            // _textBoxMatchGames
            // 
            this._textBoxMatchGames.Location = new System.Drawing.Point(93, 32);
            this._textBoxMatchGames.Margin = new System.Windows.Forms.Padding(0);
            this._textBoxMatchGames.Name = "_textBoxMatchGames";
            this._textBoxMatchGames.Size = new System.Drawing.Size(54, 24);
            this._textBoxMatchGames.TabIndex = 8;
            this._toolTipMatchGames.SetToolTip(this._textBoxMatchGames, "Number of games to play");
            // 
            // _textBoxRound
            // 
            this._textBoxRound.Location = new System.Drawing.Point(93, 82);
            this._textBoxRound.Name = "_textBoxRound";
            this._textBoxRound.Size = new System.Drawing.Size(54, 24);
            this._textBoxRound.TabIndex = 10;
            this._toolTipRound.SetToolTip(this._textBoxRound, "Set Match round #");
            // 
            // _labelRound
            // 
            this._labelRound.AutoSize = true;
            this._labelRound.Location = new System.Drawing.Point(17, 84);
            this._labelRound.Margin = new System.Windows.Forms.Padding(0);
            this._labelRound.Name = "_labelRound";
            this._labelRound.Size = new System.Drawing.Size(60, 17);
            this._labelRound.TabIndex = 11;
            this._labelRound.Text = "Round:";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(219, 238);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(114, 30);
            this._buttonCancel.TabIndex = 27;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _textBoxPause
            // 
            this._textBoxPause.Location = new System.Drawing.Point(93, 136);
            this._textBoxPause.Name = "_textBoxPause";
            this._textBoxPause.Size = new System.Drawing.Size(54, 24);
            this._textBoxPause.TabIndex = 28;
            this._toolTipPause.SetToolTip(this._textBoxPause, "Wait <secs> before starting next game");
            // 
            // _labelGames
            // 
            this._labelGames.AutoSize = true;
            this._labelGames.Location = new System.Drawing.Point(17, 159);
            this._labelGames.Margin = new System.Windows.Forms.Padding(0);
            this._labelGames.Name = "_labelGames";
            this._labelGames.Size = new System.Drawing.Size(56, 17);
            this._labelGames.TabIndex = 29;
            this._labelGames.Text = "Games";
            // 
            // _labelBetween
            // 
            this._labelBetween.AutoSize = true;
            this._labelBetween.Location = new System.Drawing.Point(17, 140);
            this._labelBetween.Margin = new System.Windows.Forms.Padding(0);
            this._labelBetween.Name = "_labelBetween";
            this._labelBetween.Size = new System.Drawing.Size(68, 17);
            this._labelBetween.TabIndex = 31;
            this._labelBetween.Text = "Between";
            // 
            // _labelSeconds
            // 
            this._labelSeconds.AutoSize = true;
            this._labelSeconds.Location = new System.Drawing.Point(160, 139);
            this._labelSeconds.Name = "_labelSeconds";
            this._labelSeconds.Size = new System.Drawing.Size(51, 17);
            this._labelSeconds.TabIndex = 32;
            this._labelSeconds.Text = "sec(s)";
            this._labelSeconds.Click += new System.EventHandler(this._labelSeconds_Click);
            // 
            // _groupBox1Match
            // 
            this._groupBox1Match.Controls.Add(this._textBoxMatchGames);
            this._groupBox1Match.Controls.Add(this._labelSeconds);
            this._groupBox1Match.Controls.Add(this._labelMatchGames);
            this._groupBox1Match.Controls.Add(this._labelBetween);
            this._groupBox1Match.Controls.Add(this._labelRound);
            this._groupBox1Match.Controls.Add(this._label1Pause);
            this._groupBox1Match.Controls.Add(this._textBoxRound);
            this._groupBox1Match.Controls.Add(this._labelGames);
            this._groupBox1Match.Controls.Add(this._textBoxPause);
            this._groupBox1Match.Location = new System.Drawing.Point(22, 23);
            this._groupBox1Match.Name = "_groupBox1Match";
            this._groupBox1Match.Size = new System.Drawing.Size(434, 195);
            this._groupBox1Match.TabIndex = 33;
            this._groupBox1Match.TabStop = false;
            this._groupBox1Match.Text = "Match";
            // 
            // _label1Pause
            // 
            this._label1Pause.AutoSize = true;
            this._label1Pause.Location = new System.Drawing.Point(17, 121);
            this._label1Pause.Margin = new System.Windows.Forms.Padding(0);
            this._label1Pause.Name = "_label1Pause";
            this._label1Pause.Size = new System.Drawing.Size(49, 17);
            this._label1Pause.TabIndex = 30;
            this._label1Pause.Text = "Pause";
            // 
            // FormMatchOptions
            // 
            this.ClientSize = new System.Drawing.Size(480, 288);
            this.Controls.Add(this._groupBox1Match);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMatchOptions";
            this.Text = "Match Options";
            this._groupBox1Match.ResumeLayout(false);
            this._groupBox1Match.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Label _labelMatchGames;
        private System.Windows.Forms.TextBox _textBoxMatchGames;
        private System.Windows.Forms.TextBox _textBoxRound;
        private System.Windows.Forms.Label _labelRound;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.TextBox _textBoxPause;
        private System.Windows.Forms.Label _labelGames;
        private System.Windows.Forms.Label _labelBetween;
        private System.Windows.Forms.Label _labelSeconds;
        private System.Windows.Forms.GroupBox _groupBox1Match;
        private System.Windows.Forms.Label _label1Pause;
        private System.Windows.Forms.ToolTip _toolTipMatchGames;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolTip _toolTipRound;
        private System.Windows.Forms.ToolTip _toolTipPause;
    }
}