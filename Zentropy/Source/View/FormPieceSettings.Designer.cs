namespace Zentropy.View
{
    partial class FormPieceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPieceSettings));
            this._checkBoxGradient = new System.Windows.Forms.CheckBox();
            this._checkBoxUnicodeFont = new System.Windows.Forms.CheckBox();
            this._comboBoxSelectFont = new System.Windows.Forms.ComboBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this._textBoxFontChars = new System.Windows.Forms.TextBox();
            this._textBoxScaleFactor = new System.Windows.Forms.TextBox();
            this._labelSize = new System.Windows.Forms.Label();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._listBoxSettings = new System.Windows.Forms.ListBox();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._labelName = new System.Windows.Forms.Label();
            this._buttonAddNew = new System.Windows.Forms.Button();
            this._labelFont = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonApply = new System.Windows.Forms.Button();
            this._groupBoxFont = new System.Windows.Forms.GroupBox();
            this._groupBoxSetList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipSelectFont = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipUnicodeFont = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipGradient = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipScaleFactor = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipApply = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipAddNew = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipRemove = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipSettings = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxFont.SuspendLayout();
            this._groupBoxSetList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _checkBoxGradient
            // 
            this._checkBoxGradient.AutoSize = true;
            this._checkBoxGradient.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxGradient.Location = new System.Drawing.Point(298, 447);
            this._checkBoxGradient.Name = "_checkBoxGradient";
            this._checkBoxGradient.Size = new System.Drawing.Size(148, 21);
            this._checkBoxGradient.TabIndex = 22;
            this._checkBoxGradient.Text = "Gradient Shadow";
            this._toolTipGradient.SetToolTip(this._checkBoxGradient, "Adds a subtle gradient shadow to the chess pieces");
            this._checkBoxGradient.UseVisualStyleBackColor = true;
            this._checkBoxGradient.CheckedChanged += new System.EventHandler(this.OnCheckBoxGradientCheckedChanged);
            // 
            // _checkBoxUnicodeFont
            // 
            this._checkBoxUnicodeFont.AutoSize = true;
            this._checkBoxUnicodeFont.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxUnicodeFont.Location = new System.Drawing.Point(23, 187);
            this._checkBoxUnicodeFont.Name = "_checkBoxUnicodeFont";
            this._checkBoxUnicodeFont.Size = new System.Drawing.Size(119, 21);
            this._checkBoxUnicodeFont.TabIndex = 0;
            this._checkBoxUnicodeFont.Text = "Unicode Font";
            this._toolTipUnicodeFont.SetToolTip(this._checkBoxUnicodeFont, "Enable if selected font is a Unicode font");
            this._checkBoxUnicodeFont.UseVisualStyleBackColor = true;
            this._checkBoxUnicodeFont.CheckedChanged += new System.EventHandler(this.OnCheckBoxUnicodeFontCheckedChanged);
            // 
            // _comboBoxSelectFont
            // 
            this._comboBoxSelectFont.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxSelectFont.FormattingEnabled = true;
            this._comboBoxSelectFont.Location = new System.Drawing.Point(81, 32);
            this._comboBoxSelectFont.Name = "_comboBoxSelectFont";
            this._comboBoxSelectFont.Size = new System.Drawing.Size(184, 24);
            this._comboBoxSelectFont.TabIndex = 3;
            this._toolTipSelectFont.SetToolTip(this._comboBoxSelectFont, "Bowse installed fonts");
            this._comboBoxSelectFont.TextChanged += new System.EventHandler(this.OnComboBoxFontTextChanged);
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(487, 514);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(100, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _textBoxFontChars
            // 
            this._textBoxFontChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._textBoxFontChars.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxFontChars.Location = new System.Drawing.Point(22, 77);
            this._textBoxFontChars.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxFontChars.Multiline = true;
            this._textBoxFontChars.Name = "_textBoxFontChars";
            this._textBoxFontChars.Size = new System.Drawing.Size(244, 92);
            this._textBoxFontChars.TabIndex = 6;
            this._textBoxFontChars.Tag = "kqbnrplwvmto";
            this._textBoxFontChars.Text = "kqbnrplwvmto";
            // 
            // _textBoxScaleFactor
            // 
            this._textBoxScaleFactor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxScaleFactor.Location = new System.Drawing.Point(76, 33);
            this._textBoxScaleFactor.Name = "_textBoxScaleFactor";
            this._textBoxScaleFactor.Size = new System.Drawing.Size(58, 24);
            this._textBoxScaleFactor.TabIndex = 8;
            this._textBoxScaleFactor.Text = "1.0";
            this._toolTipScaleFactor.SetToolTip(this._textBoxScaleFactor, "Piece size scale factor (1=100%, 0.9= 90%, etc.)");
            // 
            // _labelSize
            // 
            this._labelSize.AutoSize = true;
            this._labelSize.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelSize.Location = new System.Drawing.Point(17, 35);
            this._labelSize.Name = "_labelSize";
            this._labelSize.Size = new System.Drawing.Size(50, 17);
            this._labelSize.TabIndex = 9;
            this._labelSize.Text = "Scale:";
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonRemove.Location = new System.Drawing.Point(142, 514);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(100, 30);
            this._buttonRemove.TabIndex = 10;
            this._buttonRemove.Text = "Remove";
            this._toolTipRemove.SetToolTip(this._buttonRemove, "Remove selected piece set from list");
            this._buttonRemove.UseVisualStyleBackColor = true;
            this._buttonRemove.Click += new System.EventHandler(this.OnButtonRemoveClick);
            // 
            // _listBoxSettings
            // 
            this._listBoxSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listBoxSettings.FormattingEnabled = true;
            this._listBoxSettings.ItemHeight = 18;
            this._listBoxSettings.Location = new System.Drawing.Point(21, 31);
            this._listBoxSettings.Margin = new System.Windows.Forms.Padding(0);
            this._listBoxSettings.Name = "_listBoxSettings";
            this._listBoxSettings.Size = new System.Drawing.Size(206, 418);
            this._listBoxSettings.TabIndex = 12;
            this._toolTipSettings.SetToolTip(this._listBoxSettings, "List of available piece sets, click to select");
            this._listBoxSettings.SelectedIndexChanged += new System.EventHandler(this.OnListBoxConfigsSelectedIndexChanged);
            // 
            // _textBoxName
            // 
            this._textBoxName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxName.Location = new System.Drawing.Point(359, 50);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(204, 24);
            this._textBoxName.TabIndex = 13;
            this._textBoxName.Text = "Default";
            this._toolTipName.SetToolTip(this._textBoxName, "Piece set name");
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelName.Location = new System.Drawing.Point(295, 53);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(53, 17);
            this._labelName.TabIndex = 14;
            this._labelName.Text = "Name:";
            // 
            // _buttonAddNew
            // 
            this._buttonAddNew.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAddNew.Location = new System.Drawing.Point(27, 514);
            this._buttonAddNew.Name = "_buttonAddNew";
            this._buttonAddNew.Size = new System.Drawing.Size(100, 30);
            this._buttonAddNew.TabIndex = 15;
            this._buttonAddNew.Text = "Add New";
            this._toolTipAddNew.SetToolTip(this._buttonAddNew, "Add a new piece set to list");
            this._buttonAddNew.UseVisualStyleBackColor = true;
            this._buttonAddNew.Click += new System.EventHandler(this.OnButtonAddNewClick);
            // 
            // _labelFont
            // 
            this._labelFont.AutoSize = true;
            this._labelFont.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelFont.Location = new System.Drawing.Point(17, 35);
            this._labelFont.Name = "_labelFont";
            this._labelFont.Size = new System.Drawing.Size(56, 17);
            this._labelFont.TabIndex = 16;
            this._labelFont.Text = "Select:";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(372, 514);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(100, 30);
            this._buttonCancel.TabIndex = 26;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _buttonApply
            // 
            this._buttonApply.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonApply.Location = new System.Drawing.Point(257, 514);
            this._buttonApply.Name = "_buttonApply";
            this._buttonApply.Size = new System.Drawing.Size(100, 30);
            this._buttonApply.TabIndex = 24;
            this._buttonApply.Text = "Apply";
            this._toolTipApply.SetToolTip(this._buttonApply, "Apply scale factor");
            this._buttonApply.UseVisualStyleBackColor = true;
            this._buttonApply.Click += new System.EventHandler(this.OnButtonApplyClick);
            // 
            // _groupBoxFont
            // 
            this._groupBoxFont.Controls.Add(this._textBoxFontChars);
            this._groupBoxFont.Controls.Add(this._labelFont);
            this._groupBoxFont.Controls.Add(this._comboBoxSelectFont);
            this._groupBoxFont.Controls.Add(this._checkBoxUnicodeFont);
            this._groupBoxFont.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupBoxFont.Location = new System.Drawing.Point(298, 98);
            this._groupBoxFont.Name = "_groupBoxFont";
            this._groupBoxFont.Size = new System.Drawing.Size(288, 229);
            this._groupBoxFont.TabIndex = 27;
            this._groupBoxFont.TabStop = false;
            this._groupBoxFont.Text = "Font";
            // 
            // _groupBoxSetList
            // 
            this._groupBoxSetList.Controls.Add(this._listBoxSettings);
            this._groupBoxSetList.Font = new System.Drawing.Font("Verdana", 11F);
            this._groupBoxSetList.Location = new System.Drawing.Point(27, 19);
            this._groupBoxSetList.Margin = new System.Windows.Forms.Padding(0);
            this._groupBoxSetList.Name = "_groupBoxSetList";
            this._groupBoxSetList.Size = new System.Drawing.Size(249, 470);
            this._groupBoxSetList.TabIndex = 28;
            this._groupBoxSetList.TabStop = false;
            this._groupBoxSetList.Text = "Available Sets";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._textBoxScaleFactor);
            this.groupBox1.Controls.Add(this._labelSize);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11F);
            this.groupBox1.Location = new System.Drawing.Point(298, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 74);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Piece Size";
            // 
            // FormPieceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._groupBoxSetList);
            this.Controls.Add(this._buttonApply);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._checkBoxGradient);
            this.Controls.Add(this._buttonAddNew);
            this.Controls.Add(this._groupBoxFont);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._buttonRemove);
            this.Controls.Add(this._labelName);
            this.Controls.Add(this._textBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPieceSettings";
            this.Text = "Piece Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnPieceSettingsDialogFormClosing);
            this.Shown += new System.EventHandler(this.OnPieceSettingsDialogShown);
            this._groupBoxFont.ResumeLayout(false);
            this._groupBoxFont.PerformLayout();
            this._groupBoxSetList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _checkBoxGradient;
        private System.Windows.Forms.CheckBox _checkBoxUnicodeFont;
        private System.Windows.Forms.ComboBox _comboBoxSelectFont;
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.TextBox _textBoxFontChars;
        private System.Windows.Forms.TextBox _textBoxScaleFactor;
        private System.Windows.Forms.Label _labelSize;
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.ListBox _listBoxSettings;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Button _buttonAddNew;
        private System.Windows.Forms.Label _labelFont;
        private System.Windows.Forms.Button _buttonApply;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.GroupBox _groupBoxFont;
        private System.Windows.Forms.GroupBox _groupBoxSetList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip _toolTipName;
        private System.Windows.Forms.ToolTip _toolTipSelectFont;
        private System.Windows.Forms.ToolTip _toolTipUnicodeFont;
        private System.Windows.Forms.ToolTip _toolTipGradient;
        private System.Windows.Forms.ToolTip _toolTipScaleFactor;
        private System.Windows.Forms.ToolTip _toolTipApply;
        private System.Windows.Forms.ToolTip _toolTipAddNew;
        private System.Windows.Forms.ToolTip _toolTipRemove;
        private System.Windows.Forms.ToolTip _toolTipSettings;
    }
}