namespace Zentropy.View
{
    partial class FormGameOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOptions));
            this._buttonOk = new System.Windows.Forms.Button();
            this._textBoxDrawAdjudicationScore = new System.Windows.Forms.TextBox();
            this._labelDrawAdjudicationScore = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._textBoxDrawAdjudicationMoves = new System.Windows.Forms.TextBox();
            this._labelDrawAdjudicationMoves = new System.Windows.Forms.Label();
            this._groupBoxDrawAdjudication = new System.Windows.Forms.GroupBox();
            this._labelDcp = new System.Windows.Forms.Label();
            this._checkBoxDrawAdjudicationEnable = new System.Windows.Forms.CheckBox();
            this._groupBoxResignAdjudication = new System.Windows.Forms.GroupBox();
            this._labelRcp = new System.Windows.Forms.Label();
            this._checkBoxResignAdjudicationEnable = new System.Windows.Forms.CheckBox();
            this._labelResignAdjudicationMoves = new System.Windows.Forms.Label();
            this._textBoxResignAdjudicationMoves = new System.Windows.Forms.TextBox();
            this._textBoxResignAdjudicationScore = new System.Windows.Forms.TextBox();
            this._labelResignAdjudicationScore = new System.Windows.Forms.Label();
            this._toolTipDrawAdjudicationEnable = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipResignAdjudicationEnable = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipDrawAdjudicationScore = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipResignAdjudicationScore = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipDrawAdjudicationMoves = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipResignAdjudicationMoves = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxDrawAdjudication.SuspendLayout();
            this._groupBoxResignAdjudication.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(303, 236);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(114, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _textBoxDrawAdjudicationScore
            // 
            this._textBoxDrawAdjudicationScore.Location = new System.Drawing.Point(77, 87);
            this._textBoxDrawAdjudicationScore.Name = "_textBoxDrawAdjudicationScore";
            this._textBoxDrawAdjudicationScore.Size = new System.Drawing.Size(54, 24);
            this._textBoxDrawAdjudicationScore.TabIndex = 10;
            this._toolTipDrawAdjudicationScore.SetToolTip(this._textBoxDrawAdjudicationScore, "Both engine evals must be within <score> centipawns from zero");
            // 
            // _labelDrawAdjudicationScore
            // 
            this._labelDrawAdjudicationScore.AutoSize = true;
            this._labelDrawAdjudicationScore.Location = new System.Drawing.Point(19, 90);
            this._labelDrawAdjudicationScore.Margin = new System.Windows.Forms.Padding(0);
            this._labelDrawAdjudicationScore.Name = "_labelDrawAdjudicationScore";
            this._labelDrawAdjudicationScore.Size = new System.Drawing.Size(48, 17);
            this._labelDrawAdjudicationScore.TabIndex = 11;
            this._labelDrawAdjudicationScore.Text = "Score";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(180, 236);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(114, 30);
            this._buttonCancel.TabIndex = 27;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _textBoxDrawAdjudicationMoves
            // 
            this._textBoxDrawAdjudicationMoves.Location = new System.Drawing.Point(77, 125);
            this._textBoxDrawAdjudicationMoves.Name = "_textBoxDrawAdjudicationMoves";
            this._textBoxDrawAdjudicationMoves.Size = new System.Drawing.Size(54, 24);
            this._textBoxDrawAdjudicationMoves.TabIndex = 28;
            this._toolTipDrawAdjudicationMoves.SetToolTip(this._textBoxDrawAdjudicationMoves, "Number of consecutive half-moves (plies) required");
            // 
            // _labelDrawAdjudicationMoves
            // 
            this._labelDrawAdjudicationMoves.AutoSize = true;
            this._labelDrawAdjudicationMoves.Location = new System.Drawing.Point(19, 128);
            this._labelDrawAdjudicationMoves.Margin = new System.Windows.Forms.Padding(0);
            this._labelDrawAdjudicationMoves.Name = "_labelDrawAdjudicationMoves";
            this._labelDrawAdjudicationMoves.Size = new System.Drawing.Size(52, 17);
            this._labelDrawAdjudicationMoves.TabIndex = 31;
            this._labelDrawAdjudicationMoves.Text = "Moves";
            // 
            // _groupBoxDrawAdjudication
            // 
            this._groupBoxDrawAdjudication.Controls.Add(this._labelDcp);
            this._groupBoxDrawAdjudication.Controls.Add(this._checkBoxDrawAdjudicationEnable);
            this._groupBoxDrawAdjudication.Controls.Add(this._labelDrawAdjudicationMoves);
            this._groupBoxDrawAdjudication.Controls.Add(this._textBoxDrawAdjudicationMoves);
            this._groupBoxDrawAdjudication.Controls.Add(this._textBoxDrawAdjudicationScore);
            this._groupBoxDrawAdjudication.Controls.Add(this._labelDrawAdjudicationScore);
            this._groupBoxDrawAdjudication.Location = new System.Drawing.Point(25, 24);
            this._groupBoxDrawAdjudication.Name = "_groupBoxDrawAdjudication";
            this._groupBoxDrawAdjudication.Size = new System.Drawing.Size(182, 191);
            this._groupBoxDrawAdjudication.TabIndex = 33;
            this._groupBoxDrawAdjudication.TabStop = false;
            this._groupBoxDrawAdjudication.Text = "Draw Adjudication";
            // 
            // _labelDcp
            // 
            this._labelDcp.AutoSize = true;
            this._labelDcp.Location = new System.Drawing.Point(141, 89);
            this._labelDcp.Name = "_labelDcp";
            this._labelDcp.Size = new System.Drawing.Size(24, 17);
            this._labelDcp.TabIndex = 33;
            this._labelDcp.Text = "cp";
            // 
            // _checkBoxDrawAdjudicationEnable
            // 
            this._checkBoxDrawAdjudicationEnable.AutoSize = true;
            this._checkBoxDrawAdjudicationEnable.Location = new System.Drawing.Point(22, 48);
            this._checkBoxDrawAdjudicationEnable.Name = "_checkBoxDrawAdjudicationEnable";
            this._checkBoxDrawAdjudicationEnable.Size = new System.Drawing.Size(73, 21);
            this._checkBoxDrawAdjudicationEnable.TabIndex = 32;
            this._checkBoxDrawAdjudicationEnable.Text = "Enable";
            this._toolTipDrawAdjudicationEnable.SetToolTip(this._checkBoxDrawAdjudicationEnable, "Turn Draw Adjudication \'on\' or \'off\'");
            this._checkBoxDrawAdjudicationEnable.UseVisualStyleBackColor = true;
            // 
            // _groupBoxResignAdjudication
            // 
            this._groupBoxResignAdjudication.Controls.Add(this._labelRcp);
            this._groupBoxResignAdjudication.Controls.Add(this._checkBoxResignAdjudicationEnable);
            this._groupBoxResignAdjudication.Controls.Add(this._labelResignAdjudicationMoves);
            this._groupBoxResignAdjudication.Controls.Add(this._textBoxResignAdjudicationMoves);
            this._groupBoxResignAdjudication.Controls.Add(this._textBoxResignAdjudicationScore);
            this._groupBoxResignAdjudication.Controls.Add(this._labelResignAdjudicationScore);
            this._groupBoxResignAdjudication.Location = new System.Drawing.Point(235, 24);
            this._groupBoxResignAdjudication.Name = "_groupBoxResignAdjudication";
            this._groupBoxResignAdjudication.Size = new System.Drawing.Size(182, 191);
            this._groupBoxResignAdjudication.TabIndex = 34;
            this._groupBoxResignAdjudication.TabStop = false;
            this._groupBoxResignAdjudication.Text = "Resign Adjudication";
            // 
            // _labelRcp
            // 
            this._labelRcp.AutoSize = true;
            this._labelRcp.Location = new System.Drawing.Point(143, 90);
            this._labelRcp.Name = "_labelRcp";
            this._labelRcp.Size = new System.Drawing.Size(24, 17);
            this._labelRcp.TabIndex = 34;
            this._labelRcp.Text = "cp";
            // 
            // _checkBoxResignAdjudicationEnable
            // 
            this._checkBoxResignAdjudicationEnable.AutoSize = true;
            this._checkBoxResignAdjudicationEnable.Location = new System.Drawing.Point(22, 48);
            this._checkBoxResignAdjudicationEnable.Name = "_checkBoxResignAdjudicationEnable";
            this._checkBoxResignAdjudicationEnable.Size = new System.Drawing.Size(73, 21);
            this._checkBoxResignAdjudicationEnable.TabIndex = 32;
            this._checkBoxResignAdjudicationEnable.Text = "Enable";
            this._toolTipResignAdjudicationEnable.SetToolTip(this._checkBoxResignAdjudicationEnable, "Turn Resign Adjudication \'on\' or \'off\'");
            this._checkBoxResignAdjudicationEnable.UseVisualStyleBackColor = true;
            // 
            // _labelResignAdjudicationMoves
            // 
            this._labelResignAdjudicationMoves.AutoSize = true;
            this._labelResignAdjudicationMoves.Location = new System.Drawing.Point(19, 128);
            this._labelResignAdjudicationMoves.Margin = new System.Windows.Forms.Padding(0);
            this._labelResignAdjudicationMoves.Name = "_labelResignAdjudicationMoves";
            this._labelResignAdjudicationMoves.Size = new System.Drawing.Size(52, 17);
            this._labelResignAdjudicationMoves.TabIndex = 31;
            this._labelResignAdjudicationMoves.Text = "Moves";
            // 
            // _textBoxResignAdjudicationMoves
            // 
            this._textBoxResignAdjudicationMoves.Location = new System.Drawing.Point(78, 125);
            this._textBoxResignAdjudicationMoves.Name = "_textBoxResignAdjudicationMoves";
            this._textBoxResignAdjudicationMoves.Size = new System.Drawing.Size(54, 24);
            this._textBoxResignAdjudicationMoves.TabIndex = 28;
            this._toolTipResignAdjudicationMoves.SetToolTip(this._textBoxResignAdjudicationMoves, "Number of consecutive half-moves (plies) required");
            // 
            // _textBoxResignAdjudicationScore
            // 
            this._textBoxResignAdjudicationScore.Location = new System.Drawing.Point(78, 87);
            this._textBoxResignAdjudicationScore.Name = "_textBoxResignAdjudicationScore";
            this._textBoxResignAdjudicationScore.Size = new System.Drawing.Size(54, 24);
            this._textBoxResignAdjudicationScore.TabIndex = 10;
            this._toolTipResignAdjudicationScore.SetToolTip(this._textBoxResignAdjudicationScore, "Both engine evals must be within +-  <score> centipawns from zero");
            // 
            // _labelResignAdjudicationScore
            // 
            this._labelResignAdjudicationScore.AutoSize = true;
            this._labelResignAdjudicationScore.Location = new System.Drawing.Point(19, 90);
            this._labelResignAdjudicationScore.Margin = new System.Windows.Forms.Padding(0);
            this._labelResignAdjudicationScore.Name = "_labelResignAdjudicationScore";
            this._labelResignAdjudicationScore.Size = new System.Drawing.Size(48, 17);
            this._labelResignAdjudicationScore.TabIndex = 11;
            this._labelResignAdjudicationScore.Text = "Score";
            // 
            // FormGameOptions
            // 
            this.ClientSize = new System.Drawing.Size(442, 288);
            this.Controls.Add(this._groupBoxResignAdjudication);
            this.Controls.Add(this._groupBoxDrawAdjudication);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGameOptions";
            this.Text = "Game Options";
            this._groupBoxDrawAdjudication.ResumeLayout(false);
            this._groupBoxDrawAdjudication.PerformLayout();
            this._groupBoxResignAdjudication.ResumeLayout(false);
            this._groupBoxResignAdjudication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.TextBox _textBoxDrawAdjudicationScore;
        private System.Windows.Forms.Label _labelDrawAdjudicationScore;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.TextBox _textBoxDrawAdjudicationMoves;
        private System.Windows.Forms.Label _labelDrawAdjudicationMoves;
        private System.Windows.Forms.GroupBox _groupBoxDrawAdjudication;
        private System.Windows.Forms.CheckBox _checkBoxDrawAdjudicationEnable;
        private System.Windows.Forms.GroupBox _groupBoxResignAdjudication;
        private System.Windows.Forms.CheckBox _checkBoxResignAdjudicationEnable;
        private System.Windows.Forms.Label _labelResignAdjudicationMoves;
        private System.Windows.Forms.TextBox _textBoxResignAdjudicationMoves;
        private System.Windows.Forms.TextBox _textBoxResignAdjudicationScore;
        private System.Windows.Forms.Label _labelResignAdjudicationScore;
        private System.Windows.Forms.Label _labelDcp;
        private System.Windows.Forms.Label _labelRcp;
        private System.Windows.Forms.ToolTip _toolTipDrawAdjudicationScore;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolTip _toolTipDrawAdjudicationEnable;
        private System.Windows.Forms.ToolTip _toolTipResignAdjudicationEnable;
        private System.Windows.Forms.ToolTip _toolTipResignAdjudicationScore;
        private System.Windows.Forms.ToolTip _toolTipDrawAdjudicationMoves;
        private System.Windows.Forms.ToolTip _toolTipResignAdjudicationMoves;
    }
}