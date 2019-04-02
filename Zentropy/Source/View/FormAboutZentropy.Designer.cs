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
            this._labelChessEngineInterface = new System.Windows.Forms.Label();
            this._labelZentropy = new System.Windows.Forms.Label();
            this._labelBerldChess = new System.Windows.Forms.Label();
            this._labelChessDotNet = new System.Windows.Forms.Label();
            this._labelBy = new System.Windows.Forms.Label();
            this._groupBoxBasedOn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).BeginInit();
            this._groupBoxBasedOn.SuspendLayout();
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
            // _labelChessEngineInterface
            // 
            this._labelChessEngineInterface.AutoSize = true;
            this._labelChessEngineInterface.Font = new System.Drawing.Font("Verdana", 9F);
            this._labelChessEngineInterface.Location = new System.Drawing.Point(6, 69);
            this._labelChessEngineInterface.Name = "_labelChessEngineInterface";
            this._labelChessEngineInterface.Size = new System.Drawing.Size(316, 14);
            this._labelChessEngineInterface.TabIndex = 8;
            this._labelChessEngineInterface.Text = "and the ChessEngineInterface .NET .dll assembly";
            // 
            // _labelZentropy
            // 
            this._labelZentropy.AutoSize = true;
            this._labelZentropy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelZentropy.Location = new System.Drawing.Point(200, 60);
            this._labelZentropy.Name = "_labelZentropy";
            this._labelZentropy.Size = new System.Drawing.Size(231, 18);
            this._labelZentropy.TabIndex = 9;
            this._labelZentropy.Text = "Zentropy chess engine GUI";
            this._labelZentropy.Click += new System.EventHandler(this._labelDescription1_Click);
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
            // _labelBy
            // 
            this._labelBy.AutoSize = true;
            this._labelBy.Font = new System.Drawing.Font("Verdana", 9F);
            this._labelBy.Location = new System.Drawing.Point(17, 310);
            this._labelBy.Name = "_labelBy";
            this._labelBy.Size = new System.Drawing.Size(161, 14);
            this._labelBy.TabIndex = 13;
            this._labelBy.Text = "by firefather@telenet.be";
            // 
            // _groupBoxBasedOn
            // 
            this._groupBoxBasedOn.Controls.Add(this._labelChessDotNet);
            this._groupBoxBasedOn.Controls.Add(this._labelChessEngineInterface);
            this._groupBoxBasedOn.Controls.Add(this._labelBerldChess);
            this._groupBoxBasedOn.Font = new System.Drawing.Font("Verdana", 9F);
            this._groupBoxBasedOn.Location = new System.Drawing.Point(49, 170);
            this._groupBoxBasedOn.Name = "_groupBoxBasedOn";
            this._groupBoxBasedOn.Size = new System.Drawing.Size(384, 100);
            this._groupBoxBasedOn.TabIndex = 14;
            this._groupBoxBasedOn.TabStop = false;
            this._groupBoxBasedOn.Text = "Based on";
            // 
            // FormAboutZentropy
            // 
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this._groupBoxBasedOn);
            this.Controls.Add(this._labelBy);
            this.Controls.Add(this._labelZentropy);
            this.Controls.Add(this._labelVersion);
            this.Controls.Add(this._pictureBoxLogo);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutZentropy";
            this.Text = "About Zentropy";
            this.Load += new System.EventHandler(this.FormAboutZentropy_Load);
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).EndInit();
            this._groupBoxBasedOn.ResumeLayout(false);
            this._groupBoxBasedOn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.PictureBox _pictureBoxLogo;
        private System.Windows.Forms.Label _labelVersion;
        private System.Windows.Forms.Label _labelChessEngineInterface;
        private System.Windows.Forms.Label _labelZentropy;
        private System.Windows.Forms.Label _labelBerldChess;
        private System.Windows.Forms.Label _labelChessDotNet;
        private System.Windows.Forms.Label _labelBy;
        private System.Windows.Forms.GroupBox _groupBoxBasedOn;
    }
}