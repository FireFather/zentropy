namespace Zentropy.View
{
    partial class FormPgnOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPgnOptions));
            this._buttonOk = new System.Windows.Forms.Button();
            this._labelSite = new System.Windows.Forms.Label();
            this._labelEvent = new System.Windows.Forms.Label();
            this._textBoxSite = new System.Windows.Forms.TextBox();
            this._textBoxEvent = new System.Windows.Forms.TextBox();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._checkBoxSaveGames = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._toolTipSite = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipEvent = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipSaveGames = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(265, 163);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(101, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _labelSite
            // 
            this._labelSite.AutoSize = true;
            this._labelSite.Location = new System.Drawing.Point(19, 37);
            this._labelSite.Name = "_labelSite";
            this._labelSite.Size = new System.Drawing.Size(41, 17);
            this._labelSite.TabIndex = 6;
            this._labelSite.Text = "Site:";
            // 
            // _labelEvent
            // 
            this._labelEvent.AutoSize = true;
            this._labelEvent.Location = new System.Drawing.Point(19, 78);
            this._labelEvent.Name = "_labelEvent";
            this._labelEvent.Size = new System.Drawing.Size(54, 17);
            this._labelEvent.TabIndex = 7;
            this._labelEvent.Text = "Event:";
            // 
            // _textBoxSite
            // 
            this._textBoxSite.Location = new System.Drawing.Point(94, 34);
            this._textBoxSite.Name = "_textBoxSite";
            this._textBoxSite.Size = new System.Drawing.Size(223, 24);
            this._textBoxSite.TabIndex = 8;
            this._toolTipSite.SetToolTip(this._textBoxSite, "Match location (for PGN header)");
            // 
            // _textBoxEvent
            // 
            this._textBoxEvent.Location = new System.Drawing.Point(94, 75);
            this._textBoxEvent.Name = "_textBoxEvent";
            this._textBoxEvent.Size = new System.Drawing.Size(223, 24);
            this._textBoxEvent.TabIndex = 9;
            this._toolTipEvent.SetToolTip(this._textBoxEvent, "Name of event (for PGN header)");
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(158, 163);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(101, 30);
            this._buttonCancel.TabIndex = 10;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _checkBoxSaveGames
            // 
            this._checkBoxSaveGames.AutoSize = true;
            this._checkBoxSaveGames.Location = new System.Drawing.Point(26, 170);
            this._checkBoxSaveGames.Name = "_checkBoxSaveGames";
            this._checkBoxSaveGames.Size = new System.Drawing.Size(114, 21);
            this._checkBoxSaveGames.TabIndex = 11;
            this._checkBoxSaveGames.Text = "Save Games";
            this._toolTipSaveGames.SetToolTip(this._checkBoxSaveGames, "Save games to \'games.pgn\'");
            this._checkBoxSaveGames.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxEvent);
            this.groupBox1.Controls.Add(this._labelSite);
            this.groupBox1.Controls.Add(this._labelEvent);
            this.groupBox1.Controls.Add(this._textBoxSite);
            this.groupBox1.Location = new System.Drawing.Point(26, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 125);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header";
            // 
            // FormPgnOptions
            // 
            this.ClientSize = new System.Drawing.Size(392, 213);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._checkBoxSaveGames);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPgnOptions";
            this.Text = "Pgn Options";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Label _labelSite;
        private System.Windows.Forms.Label _labelEvent;
        private System.Windows.Forms.TextBox _textBoxSite;
        private System.Windows.Forms.TextBox _textBoxEvent;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.CheckBox _checkBoxSaveGames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip _toolTipSite;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolTip _toolTipEvent;
        private System.Windows.Forms.ToolTip _toolTipSaveGames;
    }
}