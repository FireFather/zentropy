namespace Zentropy.View
{
    partial class FormEngineManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEngineManagement));
            this._listBoxSettings = new System.Windows.Forms.ListBox();
            this._textBoxUciOptions = new System.Windows.Forms.TextBox();
            this._labelName = new System.Windows.Forms.Label();
            this._textBoxName = new System.Windows.Forms.TextBox();
            this._labelExecutablePath = new System.Windows.Forms.Label();
            this._comboBoxExePath = new System.Windows.Forms.ComboBox();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonRemove = new System.Windows.Forms.Button();
            this._comboBoxEngine1 = new System.Windows.Forms.ComboBox();
            this._comboBoxEngine2 = new System.Windows.Forms.ComboBox();
            this._buttonExePathBrowseDialog = new System.Windows.Forms.Button();
            this._groupBoxProperties = new System.Windows.Forms.GroupBox();
            this._buttonLogoPathBrowseDialog = new System.Windows.Forms.Button();
            this._comboBoxLogoPath = new System.Windows.Forms.ComboBox();
            this._labelLogoPath = new System.Windows.Forms.Label();
            this._buttonApply = new System.Windows.Forms.Button();
            this._groupBoxEngineMode = new System.Windows.Forms.GroupBox();
            this._labelEngine0 = new System.Windows.Forms.Label();
            this._labelEngine1 = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this._textBoxMultiPv = new System.Windows.Forms.TextBox();
            this._labelMultiPv = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._groupBoxUciOptions = new System.Windows.Forms.GroupBox();
            this._toolTipName = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipExePath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipLogoPath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipExePathBrowseDialog = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipAdd = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipLogoPathBrowseDialog = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipRemove = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipUciOptions = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipEngine1 = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipEngine2 = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipMultiPv = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipApply = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipSettings = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxProperties.SuspendLayout();
            this._groupBoxEngineMode.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this._groupBoxUciOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _listBoxSettings
            // 
            this._listBoxSettings.BackColor = System.Drawing.Color.White;
            this._listBoxSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._listBoxSettings.FormattingEnabled = true;
            this._listBoxSettings.ItemHeight = 18;
            this._listBoxSettings.Location = new System.Drawing.Point(20, 29);
            this._listBoxSettings.Margin = new System.Windows.Forms.Padding(0);
            this._listBoxSettings.Name = "_listBoxSettings";
            this._listBoxSettings.Size = new System.Drawing.Size(231, 346);
            this._listBoxSettings.TabIndex = 0;
            this._toolTipSettings.SetToolTip(this._listBoxSettings, "List of available engines...\r\nclick to select for confguration changes");
            this._listBoxSettings.SelectedIndexChanged += new System.EventHandler(this.OnListBoxSettingsSelectedIndexChanged);
            // 
            // _textBoxUciOptions
            // 
            this._textBoxUciOptions.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxUciOptions.Location = new System.Drawing.Point(20, 33);
            this._textBoxUciOptions.Margin = new System.Windows.Forms.Padding(0);
            this._textBoxUciOptions.Multiline = true;
            this._textBoxUciOptions.Name = "_textBoxUciOptions";
            this._textBoxUciOptions.Size = new System.Drawing.Size(335, 231);
            this._textBoxUciOptions.TabIndex = 3;
            this._toolTipUciOptions.SetToolTip(this._textBoxUciOptions, "Add UCI options for selected engine here, and click \'Apply\'");
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelName.Location = new System.Drawing.Point(17, 27);
            this._labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(47, 17);
            this._labelName.TabIndex = 21;
            this._labelName.Text = "Name";
            // 
            // _textBoxName
            // 
            this._textBoxName.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxName.Location = new System.Drawing.Point(19, 50);
            this._textBoxName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._textBoxName.Name = "_textBoxName";
            this._textBoxName.Size = new System.Drawing.Size(335, 24);
            this._textBoxName.TabIndex = 0;
            this._toolTipName.SetToolTip(this._textBoxName, "Engine name (short)");
            // 
            // _labelExecutablePath
            // 
            this._labelExecutablePath.AutoSize = true;
            this._labelExecutablePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelExecutablePath.Location = new System.Drawing.Point(16, 85);
            this._labelExecutablePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelExecutablePath.Name = "_labelExecutablePath";
            this._labelExecutablePath.Size = new System.Drawing.Size(120, 17);
            this._labelExecutablePath.TabIndex = 22;
            this._labelExecutablePath.Text = "Executable Path";
            // 
            // _comboBoxExePath
            // 
            this._comboBoxExePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxExePath.FormattingEnabled = true;
            this._comboBoxExePath.Location = new System.Drawing.Point(19, 108);
            this._comboBoxExePath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._comboBoxExePath.Name = "_comboBoxExePath";
            this._comboBoxExePath.Size = new System.Drawing.Size(285, 24);
            this._comboBoxExePath.TabIndex = 1;
            this._toolTipExePath.SetToolTip(this._comboBoxExePath, "Path of engine executable");
            // 
            // _buttonAdd
            // 
            this._buttonAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAdd.Location = new System.Drawing.Point(19, 216);
            this._buttonAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(104, 30);
            this._buttonAdd.TabIndex = 5;
            this._buttonAdd.Text = "Add";
            this._toolTipAdd.SetToolTip(this._buttonAdd, "Add engine to list");
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.OnButtonAddNewClick);
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(587, 605);
            this._buttonOk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(105, 30);
            this._buttonOk.TabIndex = 4;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _buttonRemove
            // 
            this._buttonRemove.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonRemove.Location = new System.Drawing.Point(251, 216);
            this._buttonRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonRemove.Name = "_buttonRemove";
            this._buttonRemove.Size = new System.Drawing.Size(104, 30);
            this._buttonRemove.TabIndex = 6;
            this._buttonRemove.Text = "Remove";
            this._toolTipRemove.SetToolTip(this._buttonRemove, "Remove engine from list");
            this._buttonRemove.UseVisualStyleBackColor = true;
            this._buttonRemove.Click += new System.EventHandler(this.OnButtonRemoveClick);
            // 
            // _comboBoxEngine1
            // 
            this._comboBoxEngine1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxEngine1.FormattingEnabled = true;
            this._comboBoxEngine1.ItemHeight = 18;
            this._comboBoxEngine1.Location = new System.Drawing.Point(20, 44);
            this._comboBoxEngine1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._comboBoxEngine1.Name = "_comboBoxEngine1";
            this._comboBoxEngine1.Size = new System.Drawing.Size(231, 26);
            this._comboBoxEngine1.TabIndex = 10;
            this._toolTipEngine1.SetToolTip(this._comboBoxEngine1, "Select Engine 1");
            this._comboBoxEngine1.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxEngine1SelectedIndexChanged);
            // 
            // _comboBoxEngine2
            // 
            this._comboBoxEngine2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxEngine2.FormattingEnabled = true;
            this._comboBoxEngine2.ItemHeight = 18;
            this._comboBoxEngine2.Location = new System.Drawing.Point(17, 109);
            this._comboBoxEngine2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._comboBoxEngine2.Name = "_comboBoxEngine2";
            this._comboBoxEngine2.Size = new System.Drawing.Size(231, 26);
            this._comboBoxEngine2.TabIndex = 11;
            this._toolTipEngine2.SetToolTip(this._comboBoxEngine2, "Select Engine 2");
            this._comboBoxEngine2.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxEngine2SelectedIndexChanged);
            // 
            // _buttonExePathBrowseDialog
            // 
            this._buttonExePathBrowseDialog.Location = new System.Drawing.Point(312, 107);
            this._buttonExePathBrowseDialog.Margin = new System.Windows.Forms.Padding(0);
            this._buttonExePathBrowseDialog.Name = "_buttonExePathBrowseDialog";
            this._buttonExePathBrowseDialog.Size = new System.Drawing.Size(43, 26);
            this._buttonExePathBrowseDialog.TabIndex = 2;
            this._buttonExePathBrowseDialog.Text = "...";
            this._toolTipExePathBrowseDialog.SetToolTip(this._buttonExePathBrowseDialog, "Browse file system for engine executable");
            this._buttonExePathBrowseDialog.UseVisualStyleBackColor = true;
            this._buttonExePathBrowseDialog.Click += new System.EventHandler(this.OnButtonExePathDialogClick);
            // 
            // _groupBoxProperties
            // 
            this._groupBoxProperties.Controls.Add(this._buttonLogoPathBrowseDialog);
            this._groupBoxProperties.Controls.Add(this._comboBoxLogoPath);
            this._groupBoxProperties.Controls.Add(this._labelLogoPath);
            this._groupBoxProperties.Controls.Add(this._labelName);
            this._groupBoxProperties.Controls.Add(this._buttonExePathBrowseDialog);
            this._groupBoxProperties.Controls.Add(this._comboBoxExePath);
            this._groupBoxProperties.Controls.Add(this._labelExecutablePath);
            this._groupBoxProperties.Controls.Add(this._textBoxName);
            this._groupBoxProperties.Controls.Add(this._buttonRemove);
            this._groupBoxProperties.Controls.Add(this._buttonAdd);
            this._groupBoxProperties.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._groupBoxProperties.Location = new System.Drawing.Point(317, 17);
            this._groupBoxProperties.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._groupBoxProperties.Name = "_groupBoxProperties";
            this._groupBoxProperties.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._groupBoxProperties.Size = new System.Drawing.Size(375, 267);
            this._groupBoxProperties.TabIndex = 35;
            this._groupBoxProperties.TabStop = false;
            this._groupBoxProperties.Text = "Details";
            // 
            // _buttonLogoPathBrowseDialog
            // 
            this._buttonLogoPathBrowseDialog.Location = new System.Drawing.Point(312, 165);
            this._buttonLogoPathBrowseDialog.Margin = new System.Windows.Forms.Padding(0);
            this._buttonLogoPathBrowseDialog.Name = "_buttonLogoPathBrowseDialog";
            this._buttonLogoPathBrowseDialog.Size = new System.Drawing.Size(43, 26);
            this._buttonLogoPathBrowseDialog.TabIndex = 24;
            this._buttonLogoPathBrowseDialog.Text = "...";
            this._toolTipLogoPathBrowseDialog.SetToolTip(this._buttonLogoPathBrowseDialog, "Browse file system for engine logo (100x50)");
            this._buttonLogoPathBrowseDialog.UseVisualStyleBackColor = true;
            this._buttonLogoPathBrowseDialog.Click += new System.EventHandler(this.OnButtonLogoPathDialogClick);
            // 
            // _comboBoxLogoPath
            // 
            this._comboBoxLogoPath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxLogoPath.FormattingEnabled = true;
            this._comboBoxLogoPath.Location = new System.Drawing.Point(20, 166);
            this._comboBoxLogoPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._comboBoxLogoPath.Name = "_comboBoxLogoPath";
            this._comboBoxLogoPath.Size = new System.Drawing.Size(285, 24);
            this._comboBoxLogoPath.TabIndex = 23;
            this._toolTipExePath.SetToolTip(this._comboBoxLogoPath, "Path of engine logo (100 x 50)");
            // 
            // _labelLogoPath
            // 
            this._labelLogoPath.AutoSize = true;
            this._labelLogoPath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLogoPath.Location = new System.Drawing.Point(17, 144);
            this._labelLogoPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelLogoPath.Name = "_labelLogoPath";
            this._labelLogoPath.Size = new System.Drawing.Size(79, 17);
            this._labelLogoPath.TabIndex = 25;
            this._labelLogoPath.Text = "Logo Path";
            // 
            // _buttonApply
            // 
            this._buttonApply.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonApply.Location = new System.Drawing.Point(317, 605);
            this._buttonApply.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonApply.Name = "_buttonApply";
            this._buttonApply.Size = new System.Drawing.Size(104, 30);
            this._buttonApply.TabIndex = 38;
            this._buttonApply.Text = "Apply";
            this._toolTipApply.SetToolTip(this._buttonApply, "Apply UCI options, and other configuration changes");
            this._buttonApply.UseVisualStyleBackColor = true;
            this._buttonApply.Click += new System.EventHandler(this.OnButtonApplyClick);
            // 
            // _groupBoxEngineMode
            // 
            this._groupBoxEngineMode.Controls.Add(this._labelEngine0);
            this._groupBoxEngineMode.Controls.Add(this._labelEngine1);
            this._groupBoxEngineMode.Controls.Add(this._comboBoxEngine1);
            this._groupBoxEngineMode.Controls.Add(this._comboBoxEngine2);
            this._groupBoxEngineMode.Location = new System.Drawing.Point(23, 426);
            this._groupBoxEngineMode.Margin = new System.Windows.Forms.Padding(0);
            this._groupBoxEngineMode.Name = "_groupBoxEngineMode";
            this._groupBoxEngineMode.Padding = new System.Windows.Forms.Padding(0);
            this._groupBoxEngineMode.Size = new System.Drawing.Size(271, 156);
            this._groupBoxEngineMode.TabIndex = 36;
            this._groupBoxEngineMode.TabStop = false;
            // 
            // _labelEngine0
            // 
            this._labelEngine0.AutoSize = true;
            this._labelEngine0.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEngine0.Location = new System.Drawing.Point(17, 19);
            this._labelEngine0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelEngine0.Name = "_labelEngine0";
            this._labelEngine0.Size = new System.Drawing.Size(71, 18);
            this._labelEngine0.TabIndex = 34;
            this._labelEngine0.Text = "Engine 1";
            // 
            // _labelEngine1
            // 
            this._labelEngine1.AutoSize = true;
            this._labelEngine1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelEngine1.Location = new System.Drawing.Point(17, 85);
            this._labelEngine1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelEngine1.Name = "_labelEngine1";
            this._labelEngine1.Size = new System.Drawing.Size(71, 18);
            this._labelEngine1.TabIndex = 35;
            this._labelEngine1.Text = "Engine 2";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSettings.Controls.Add(this._listBoxSettings);
            this.groupBoxSettings.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSettings.Location = new System.Drawing.Point(23, 17);
            this.groupBoxSettings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBoxSettings.Size = new System.Drawing.Size(271, 396);
            this.groupBoxSettings.TabIndex = 37;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Engines";
            // 
            // _textBoxMultiPv
            // 
            this._textBoxMultiPv.Location = new System.Drawing.Point(86, 609);
            this._textBoxMultiPv.Name = "_textBoxMultiPv";
            this._textBoxMultiPv.Size = new System.Drawing.Size(52, 26);
            this._textBoxMultiPv.TabIndex = 38;
            this._toolTipMultiPv.SetToolTip(this._textBoxMultiPv, "Select number of primary variations to display");
            // 
            // _labelMultiPv
            // 
            this._labelMultiPv.AutoSize = true;
            this._labelMultiPv.Location = new System.Drawing.Point(18, 613);
            this._labelMultiPv.Name = "_labelMultiPv";
            this._labelMultiPv.Size = new System.Drawing.Size(61, 18);
            this._labelMultiPv.TabIndex = 39;
            this._labelMultiPv.Text = "MultiPV";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(477, 605);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(105, 30);
            this._buttonCancel.TabIndex = 40;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _groupBoxUciOptions
            // 
            this._groupBoxUciOptions.Controls.Add(this._textBoxUciOptions);
            this._groupBoxUciOptions.Location = new System.Drawing.Point(317, 297);
            this._groupBoxUciOptions.Name = "_groupBoxUciOptions";
            this._groupBoxUciOptions.Size = new System.Drawing.Size(375, 285);
            this._groupBoxUciOptions.TabIndex = 41;
            this._groupBoxUciOptions.TabStop = false;
            this._groupBoxUciOptions.Text = "UCI Options";
            // 
            // FormEngineManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(714, 656);
            this.Controls.Add(this._groupBoxUciOptions);
            this.Controls.Add(this._labelMultiPv);
            this.Controls.Add(this._textBoxMultiPv);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this._groupBoxEngineMode);
            this.Controls.Add(this._groupBoxProperties);
            this.Controls.Add(this._buttonApply);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._buttonCancel);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEngineManagement";
            this.Text = "Engine Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormEngineManagementClosing);
            this._groupBoxProperties.ResumeLayout(false);
            this._groupBoxProperties.PerformLayout();
            this._groupBoxEngineMode.ResumeLayout(false);
            this._groupBoxEngineMode.PerformLayout();
            this.groupBoxSettings.ResumeLayout(false);
            this._groupBoxUciOptions.ResumeLayout(false);
            this._groupBoxUciOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listBoxSettings;
        private System.Windows.Forms.TextBox _textBoxUciOptions;
        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.TextBox _textBoxName;
        private System.Windows.Forms.Label _labelExecutablePath;
        private System.Windows.Forms.ComboBox _comboBoxExePath;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonApply;		
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Button _buttonCancel;		
        private System.Windows.Forms.Button _buttonRemove;
        private System.Windows.Forms.ComboBox _comboBoxEngine1;
        private System.Windows.Forms.ComboBox _comboBoxEngine2;
        private System.Windows.Forms.Button _buttonExePathBrowseDialog;
        private System.Windows.Forms.GroupBox _groupBoxProperties;
        private System.Windows.Forms.GroupBox _groupBoxEngineMode;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label _labelEngine0;
        private System.Windows.Forms.Label _labelEngine1;
        private System.Windows.Forms.TextBox _textBoxMultiPv;
        private System.Windows.Forms.Label _labelMultiPv;
        private System.Windows.Forms.Button _buttonLogoPathBrowseDialog;
        private System.Windows.Forms.ComboBox _comboBoxLogoPath;
        private System.Windows.Forms.Label _labelLogoPath;
        private System.Windows.Forms.GroupBox _groupBoxUciOptions;
        private System.Windows.Forms.ToolTip _toolTipName;
        private System.Windows.Forms.ToolTip _toolTipExePath;
        private System.Windows.Forms.ToolTip _toolTipLogoPath;
        private System.Windows.Forms.ToolTip _toolTipExePathBrowseDialog;
        private System.Windows.Forms.ToolTip _toolTipAdd;
        private System.Windows.Forms.ToolTip _toolTipLogoPathBrowseDialog;
        private System.Windows.Forms.ToolTip _toolTipRemove;
        private System.Windows.Forms.ToolTip _toolTipUciOptions;
        private System.Windows.Forms.ToolTip _toolTipEngine1;
        private System.Windows.Forms.ToolTip _toolTipEngine2;
        private System.Windows.Forms.ToolTip _toolTipMultiPv;
        private System.Windows.Forms.ToolTip _toolTipApply;
        private System.Windows.Forms.ToolTip _toolTipSettings;
    }
}