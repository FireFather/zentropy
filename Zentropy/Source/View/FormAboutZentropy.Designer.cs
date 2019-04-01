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
            // FormAboutZentropy
            // 
            this.ClientSize = new System.Drawing.Size(480, 345);
            this.Controls.Add(this._pictureBoxLogo);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAboutZentropy";
            this.Text = "About Zentropy";
            ((System.ComponentModel.ISupportInitialize)(this._pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.PictureBox _pictureBoxLogo;
    }
}