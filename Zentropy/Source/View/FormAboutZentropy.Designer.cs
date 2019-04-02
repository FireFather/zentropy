namespace Zentropy.View
{
    partial class FormAboutZentropy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutZentropy));
            this._buttonOk = new System.Windows.Forms.Button();
            this._pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this._labelVersion = new System.Windows.Forms.Label();
            this._labelVersionNumber = new System.Windows.Forms.Label();
            this._labelDescription1 = new System.Windows.Forms.Label();
            this._labelBerldChess = new System.Windows.Forms.Label();
            this._labelChessDotNet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(362, 301);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(101, 30);
            this._buttonOk.TabIndex = 5;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _pictureBoxLogo
            // 
            this._pictureBoxLogo.Image = global::Zentropy.Properties.Resources.ZentropyLogo;
            this._pictureBoxLogo.Location = new System.Drawing.Point(20, 20);
            this._pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this._pictureBoxLogo.Name = "_pictureBoxLogo";
            this._pictureBoxLogo.Size = new System.Drawing.Size(128, 128);
            this._pictureBoxLogo.TabIndex = 6;
            this._pictureBoxLogo.TabStop = false;
            // 
            // _labelVersion
            // 
            this._labelVersion.AutoSize = true;
            this._labelVersion.Font = new System.Drawing.Font("Verdana", 10F);
            this._labelVersion.Location = new System.Drawing.Point(249, 88);
            this._labelVersion.Name = "_labelVersion";
            this._labelVersion.Size = new System.Drawing.Size(133, 17);
            this._labelVersion.TabIndex = 7;
            this._labelVersion.Text = "Version 4-2-2019";
            // 
            // _labelVersionNumber
            // 
            this._labelVersionNumber.AutoSize = true;
            this._labelVersionNumber.Font = new System.Drawing.Font("Verdana", 9F);
            this._labelVersionNumber.Location = new System.Drawing.Point(6, 69);
            this._labelVersionNumber.Name = "_labelVersionNumber";
            this._labelVersionNumber.Size = new System.Drawing.Size(316, 14);
            this._labelVersionNumber.TabIndex = 8;
            this._labelVersionNumber.Text = "and the ChessEngineInterface .NET .dll assembly";
            // 
            // _labelDescription1
            // 
            this._labelDescription1.AutoSize = true;
            this._labelDescription1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDescription1.Location = new System.Drawing.Point(200, 60);
            this._labelDescription1.Name = "_labelDescription1";
            this._labelDescription1.Size = new System.Drawing.Size(231, 18);
            this._labelDescription1.TabIndex = 9;
            this._labelDescription1.Text = "Zentropy chess engine GUI";
            this._labelDescription1.Click += new System.EventHandler(this._labelDescription1_Click);
            // 
            // _labelBerldChess
            // 
            this._labelBerldChess.AutoSize = true;
            this._labelBerldChess.Font = new System.Drawing.Font("Verdana", 9F);
            this._labelBerldChess.Location = new System.Drawing.Point(6, 23);
            this._labelBerldChess.Name = "_labelBerldChess";
            this._labelBerldChess.Size = new System.Drawing.Size(335, 14);
            this._labelBerldChess.TabIndex = 10;
            this._labelBerldChess.Text = "BerldChess: https://github.com/Bernton/BerldChess";
            // 
            // _labelChessDotNet
            // 
            this._labelChessDotNet.AutoSize = true;
            this._labelChessDotNet.Font = new System.Drawing.Font("Verdana", 9F);
            this._labelChessDotNet.Location = new System.Drawing.Point(6, 46);
            this._labelChessDotNet.Name = "_labelChessDotNet";
            this._labelChessDotNet.Size = new System.Drawing.Size(371, 14);
            this._labelChessDotNet.TabIndex = 11;
            this._labelChessDotNet.Text = "ChessDotNet: https://github.com/ProgramFOX/Chess.NET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.Location = new System.Drawing.Point(17, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "by firefather@telenet.be";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._labelChessDotNet);
            this.groupBox1.Controls.Add(this._labelVersionNumber);
            this.groupBox1.Controls.Add(this._labelBerldChess);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F);
            this.groupBox1.Location = new System.Drawing.Point(49, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Based on";
            // 
            // FormAboutZentropy
            // 
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._labelDescription1);
            this.Controls.Add(this._labelVersion);
            this.Controls.Add(this._pictureBoxLogo);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutZentropy";
            this.Text = "About Zentropy";
            this.Load += new System.EventHandler(this.FormAboutZentropy_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.PictureBox _pictureBoxLogo;
        private System.Windows.Forms.Label _labelVersion;
        private System.Windows.Forms.Label _labelVersionNumber;
        private System.Windows.Forms.Label _labelDescription1;
        private System.Windows.Forms.Label _labelBerldChess;
        private System.Windows.Forms.Label _labelChessDotNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}