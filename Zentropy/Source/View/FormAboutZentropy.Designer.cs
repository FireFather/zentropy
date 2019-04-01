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
            this._labelDescription2 = new System.Windows.Forms.Label();
            this._labelDescription3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).BeginInit();
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
            this._labelVersion.Location = new System.Drawing.Point(211, 68);
            this._labelVersion.Name = "_labelVersion";
            this._labelVersion.Size = new System.Drawing.Size(66, 17);
            this._labelVersion.TabIndex = 7;
            this._labelVersion.Text = "Version:";
            // 
            // _labelVersionNumber
            // 
            this._labelVersionNumber.AutoSize = true;
            this._labelVersionNumber.Location = new System.Drawing.Point(277, 68);
            this._labelVersionNumber.Name = "_labelVersionNumber";
            this._labelVersionNumber.Size = new System.Drawing.Size(76, 17);
            this._labelVersionNumber.TabIndex = 8;
            this._labelVersionNumber.Text = "4-1-2019";
            // 
            // _labelDescription1
            // 
            this._labelDescription1.AutoSize = true;
            this._labelDescription1.Location = new System.Drawing.Point(95, 183);
            this._labelDescription1.Name = "_labelDescription1";
            this._labelDescription1.Size = new System.Drawing.Size(229, 17);
            this._labelDescription1.TabIndex = 9;
            this._labelDescription1.Text = "A Windows chess engine GUI...";
            // 
            // _labelDescription2
            // 
            this._labelDescription2.AutoSize = true;
            this._labelDescription2.Location = new System.Drawing.Point(95, 210);
            this._labelDescription2.Name = "_labelDescription2";
            this._labelDescription2.Size = new System.Drawing.Size(207, 17);
            this._labelDescription2.TabIndex = 10;
            this._labelDescription2.Text = "developed from BerldChess:";
            // 
            // _labelDescription3
            // 
            this._labelDescription3.AutoSize = true;
            this._labelDescription3.Location = new System.Drawing.Point(95, 237);
            this._labelDescription3.Name = "_labelDescription3";
            this._labelDescription3.Size = new System.Drawing.Size(291, 17);
            this._labelDescription3.TabIndex = 11;
            this._labelDescription3.Text = "https://github.com/Bernton/BerldChess";
            // 
            // FormAboutZentropy
            // 
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this._labelDescription3);
            this.Controls.Add(this._labelDescription2);
            this.Controls.Add(this._labelDescription1);
            this.Controls.Add(this._labelVersionNumber);
            this.Controls.Add(this._labelVersion);
            this.Controls.Add(this._pictureBoxLogo);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutZentropy";
            this.Text = "About Zentropy";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.PictureBox _pictureBoxLogo;
        private System.Windows.Forms.Label _labelVersion;
        private System.Windows.Forms.Label _labelVersionNumber;
        private System.Windows.Forms.Label _labelDescription1;
        private System.Windows.Forms.Label _labelDescription2;
        private System.Windows.Forms.Label _labelDescription3;
    }
}