namespace Zentropy.View
{
    partial class FormBookOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBookOptions));
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._checkBoxUseBook = new System.Windows.Forms.CheckBox();
            this._checkBoxRandom = new System.Windows.Forms.CheckBox();
            this._buttonCreate = new System.Windows.Forms.Button();
            this._labelPlies = new System.Windows.Forms.Label();
            this._textBoxPgnDepth = new System.Windows.Forms.TextBox();
            this._labelPgnDepth = new System.Windows.Forms.Label();
            this._buttonBrowsePgnPath = new System.Windows.Forms.Button();
            this._comboBoxPgnPath = new System.Windows.Forms.ComboBox();
            this._labelPgnPath = new System.Windows.Forms.Label();
            this._groupBoxCreateBook = new System.Windows.Forms.GroupBox();
            this._toolTipUseBook = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipRandom = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipPgnPath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipBrowsePgnPath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipPgnDepth = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipCreate = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxCreateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(417, 335);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(114, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(294, 335);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(114, 30);
            this._buttonCancel.TabIndex = 27;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _checkBoxUseBook
            // 
            this._checkBoxUseBook.AutoSize = true;
            this._checkBoxUseBook.Location = new System.Drawing.Point(25, 22);
            this._checkBoxUseBook.Margin = new System.Windows.Forms.Padding(0);
            this._checkBoxUseBook.Name = "_checkBoxUseBook";
            this._checkBoxUseBook.Size = new System.Drawing.Size(94, 21);
            this._checkBoxUseBook.TabIndex = 28;
            this._checkBoxUseBook.Text = "Use Book";
            this._toolTipUseBook.SetToolTip(this._checkBoxUseBook, "Start each game with a position from FEN opening book \"book.fen\".");
            this._checkBoxUseBook.UseVisualStyleBackColor = true;
            // 
            // _checkBoxRandom
            // 
            this._checkBoxRandom.AutoSize = true;
            this._checkBoxRandom.Location = new System.Drawing.Point(26, 61);
            this._checkBoxRandom.Margin = new System.Windows.Forms.Padding(0);
            this._checkBoxRandom.Name = "_checkBoxRandom";
            this._checkBoxRandom.Size = new System.Drawing.Size(85, 21);
            this._checkBoxRandom.TabIndex = 29;
            this._checkBoxRandom.Text = "Random";
            this._toolTipRandom.SetToolTip(this._checkBoxRandom, "Book positions will be selected randomly (instead of sequentially)");
            this._checkBoxRandom.UseVisualStyleBackColor = true;
            // 
            // _buttonCreate
            // 
            this._buttonCreate.Location = new System.Drawing.Point(24, 154);
            this._buttonCreate.Margin = new System.Windows.Forms.Padding(0);
            this._buttonCreate.Name = "_buttonCreate";
            this._buttonCreate.Size = new System.Drawing.Size(94, 29);
            this._buttonCreate.TabIndex = 30;
            this._buttonCreate.Text = "Create";
            this._toolTipCreate.SetToolTip(this._buttonCreate, "Begin creation of \'book.fen\' from specified PGN file");
            this._buttonCreate.UseVisualStyleBackColor = true;
            this._buttonCreate.Click += new System.EventHandler(this.OnButtonCreateClick);
            // 
            // _labelPlies
            // 
            this._labelPlies.AutoSize = true;
            this._labelPlies.Location = new System.Drawing.Point(144, 109);
            this._labelPlies.Name = "_labelPlies";
            this._labelPlies.Size = new System.Drawing.Size(134, 17);
            this._labelPlies.TabIndex = 38;
            this._labelPlies.Text = "plies (half-moves)";
            // 
            // _textBoxPgnDepth
            // 
            this._textBoxPgnDepth.Location = new System.Drawing.Point(82, 105);
            this._textBoxPgnDepth.Margin = new System.Windows.Forms.Padding(0);
            this._textBoxPgnDepth.Name = "_textBoxPgnDepth";
            this._textBoxPgnDepth.Size = new System.Drawing.Size(54, 24);
            this._textBoxPgnDepth.TabIndex = 37;
            this._toolTipPgnDepth.SetToolTip(this._textBoxPgnDepth, "Read PGN games to this depth for creation of book positions ");
            // 
            // _labelPgnDepth
            // 
            this._labelPgnDepth.AutoSize = true;
            this._labelPgnDepth.Location = new System.Drawing.Point(22, 109);
            this._labelPgnDepth.Margin = new System.Windows.Forms.Padding(0);
            this._labelPgnDepth.Name = "_labelPgnDepth";
            this._labelPgnDepth.Size = new System.Drawing.Size(57, 17);
            this._labelPgnDepth.TabIndex = 36;
            this._labelPgnDepth.Text = "Depth:";
            // 
            // _buttonBrowsePgnPath
            // 
            this._buttonBrowsePgnPath.Location = new System.Drawing.Point(439, 59);
            this._buttonBrowsePgnPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._buttonBrowsePgnPath.Name = "_buttonBrowsePgnPath";
            this._buttonBrowsePgnPath.Size = new System.Drawing.Size(43, 27);
            this._buttonBrowsePgnPath.TabIndex = 34;
            this._buttonBrowsePgnPath.Text = "...";
            this._toolTipBrowsePgnPath.SetToolTip(this._buttonBrowsePgnPath, "Browse file system for PGN file");
            this._buttonBrowsePgnPath.UseVisualStyleBackColor = true;
            this._buttonBrowsePgnPath.Click += new System.EventHandler(this.OnButtonPgnPathDialogClick);
            // 
            // _comboBoxPgnPath
            // 
            this._comboBoxPgnPath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._comboBoxPgnPath.FormattingEnabled = true;
            this._comboBoxPgnPath.Location = new System.Drawing.Point(24, 60);
            this._comboBoxPgnPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._comboBoxPgnPath.Name = "_comboBoxPgnPath";
            this._comboBoxPgnPath.Size = new System.Drawing.Size(401, 24);
            this._comboBoxPgnPath.TabIndex = 33;
            this._toolTipPgnDepth.SetToolTip(this._comboBoxPgnPath, "PGN file to be converted (will not be changed)");
            // 
            // _labelPgnPath
            // 
            this._labelPgnPath.AutoSize = true;
            this._labelPgnPath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelPgnPath.Location = new System.Drawing.Point(21, 35);
            this._labelPgnPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._labelPgnPath.Name = "_labelPgnPath";
            this._labelPgnPath.Size = new System.Drawing.Size(98, 17);
            this._labelPgnPath.TabIndex = 35;
            this._labelPgnPath.Text = "Choose Pgn:";
            // 
            // _groupBoxCreateBook
            // 
            this._groupBoxCreateBook.Controls.Add(this._comboBoxPgnPath);
            this._groupBoxCreateBook.Controls.Add(this._labelPlies);
            this._groupBoxCreateBook.Controls.Add(this._labelPgnPath);
            this._groupBoxCreateBook.Controls.Add(this._textBoxPgnDepth);
            this._groupBoxCreateBook.Controls.Add(this._buttonCreate);
            this._groupBoxCreateBook.Controls.Add(this._buttonBrowsePgnPath);
            this._groupBoxCreateBook.Controls.Add(this._labelPgnDepth);
            this._groupBoxCreateBook.Location = new System.Drawing.Point(25, 109);
            this._groupBoxCreateBook.Name = "_groupBoxCreateBook";
            this._groupBoxCreateBook.Size = new System.Drawing.Size(506, 207);
            this._groupBoxCreateBook.TabIndex = 39;
            this._groupBoxCreateBook.TabStop = false;
            this._groupBoxCreateBook.Text = "FEN Opening Book from PGN";
            // 
            // FormBookOptions
            // 
            this.ClientSize = new System.Drawing.Size(555, 385);
            this.Controls.Add(this._groupBoxCreateBook);
            this.Controls.Add(this._checkBoxRandom);
            this.Controls.Add(this._checkBoxUseBook);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBookOptions";
            this.Text = "Book Options";
            this._groupBoxCreateBook.ResumeLayout(false);
            this._groupBoxCreateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.CheckBox _checkBoxUseBook;
        private System.Windows.Forms.CheckBox _checkBoxRandom;
        private System.Windows.Forms.Button _buttonCreate;
        private System.Windows.Forms.Button _buttonBrowsePgnPath;
        private System.Windows.Forms.ComboBox _comboBoxPgnPath;
        private System.Windows.Forms.Label _labelPgnPath;
        private System.Windows.Forms.TextBox _textBoxPgnDepth;
        private System.Windows.Forms.Label _labelPgnDepth;
        private System.Windows.Forms.Label _labelPlies;
        private System.Windows.Forms.GroupBox _groupBoxCreateBook;
        private System.Windows.Forms.ToolTip _toolTipUseBook;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ToolTip _toolTipRandom;
        private System.Windows.Forms.ToolTip _toolTipPgnPath;
        private System.Windows.Forms.ToolTip _toolTipBrowsePgnPath;
        private System.Windows.Forms.ToolTip _toolTipPgnDepth;
        private System.Windows.Forms.ToolTip _toolTipCreate;
    }
}