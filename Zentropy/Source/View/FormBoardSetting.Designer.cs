namespace Zentropy.View
{
    partial class FormBoardSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoardSetting));
            this._labelShowDarkSquareColor = new System.Windows.Forms.Label();
            this._labelShowLightSquareColor = new System.Windows.Forms.Label();
            this._buttonDarkSquare = new System.Windows.Forms.Button();
            this._buttonLightSquare = new System.Windows.Forms.Button();
            this._buttonLastmove = new System.Windows.Forms.Button();
            this._buttonOk = new System.Windows.Forms.Button();
            this._checkBoxUseSquareImages = new System.Windows.Forms.CheckBox();
            this._labelLightSquarePath = new System.Windows.Forms.Label();
            this._labelDarkSquarePath = new System.Windows.Forms.Label();
            this._textBoxDarkSquarePath = new System.Windows.Forms.TextBox();
            this._textBoxLightSquarePath = new System.Windows.Forms.TextBox();
            this._buttonLightBrowseButton = new System.Windows.Forms.Button();
            this._buttonDarkBrowseButton = new System.Windows.Forms.Button();
            this._labelLastmove = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._textBoxOpacity = new System.Windows.Forms.TextBox();
            this._labelOpacity = new System.Windows.Forms.Label();
            this._radioButtonNoHighlight = new System.Windows.Forms.RadioButton();
            this._radioButtonFillHighlight = new System.Windows.Forms.RadioButton();
            this._radioButtonBorderHighlight = new System.Windows.Forms.RadioButton();
            this._radioButtonArrowHighlight = new System.Windows.Forms.RadioButton();
            this._groupBoxHighlightLastMove = new System.Windows.Forms.GroupBox();
            this._groupBoxSquareImages = new System.Windows.Forms.GroupBox();
            this._groupBoxSquareColors = new System.Windows.Forms.GroupBox();
            this._toolTipLightSquare = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipDarkSquare = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipLastMove = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipOpacity = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipUseSquareImages = new System.Windows.Forms.ToolTip(this.components);
            this._toolTiplDarkSquarePath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipLightSquarePath = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipNoHighlight = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipFillHighlight = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipBorderHighlight = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipArrowHighlight = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipDarkBrowseButton = new System.Windows.Forms.ToolTip(this.components);
            this._toolTipLightBrowseButton = new System.Windows.Forms.ToolTip(this.components);
            this._groupBoxHighlightLastMove.SuspendLayout();
            this._groupBoxSquareImages.SuspendLayout();
            this._groupBoxSquareColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelShowDarkSquareColor
            // 
            this._labelShowDarkSquareColor.AutoSize = true;
            this._labelShowDarkSquareColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelShowDarkSquareColor.Location = new System.Drawing.Point(17, 95);
            this._labelShowDarkSquareColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelShowDarkSquareColor.Name = "_labelShowDarkSquareColor";
            this._labelShowDarkSquareColor.Size = new System.Drawing.Size(102, 17);
            this._labelShowDarkSquareColor.TabIndex = 14;
            this._labelShowDarkSquareColor.Text = "Dark Square:";
            // 
            // _labelShowLightSquareColor
            // 
            this._labelShowLightSquareColor.AutoSize = true;
            this._labelShowLightSquareColor.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelShowLightSquareColor.Location = new System.Drawing.Point(19, 40);
            this._labelShowLightSquareColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelShowLightSquareColor.Name = "_labelShowLightSquareColor";
            this._labelShowLightSquareColor.Size = new System.Drawing.Size(104, 17);
            this._labelShowLightSquareColor.TabIndex = 17;
            this._labelShowLightSquareColor.Text = "Light Square:";
            // 
            // _buttonDarkSquare
            // 
            this._buttonDarkSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonDarkSquare.Location = new System.Drawing.Point(136, 82);
            this._buttonDarkSquare.Margin = new System.Windows.Forms.Padding(0);
            this._buttonDarkSquare.Name = "_buttonDarkSquare";
            this._buttonDarkSquare.Size = new System.Drawing.Size(53, 48);
            this._buttonDarkSquare.TabIndex = 18;
            this._toolTipDarkSquare.SetToolTip(this._buttonDarkSquare, "Select the color for the board\'s dark squares");
            this._buttonDarkSquare.UseVisualStyleBackColor = true;
            this._buttonDarkSquare.Click += new System.EventHandler(this.OnButtonDarkSquareColorClick);
            // 
            // _buttonLightSquare
            // 
            this._buttonLightSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonLightSquare.Location = new System.Drawing.Point(136, 25);
            this._buttonLightSquare.Margin = new System.Windows.Forms.Padding(0);
            this._buttonLightSquare.Name = "_buttonLightSquare";
            this._buttonLightSquare.Size = new System.Drawing.Size(53, 48);
            this._buttonLightSquare.TabIndex = 19;
            this._toolTipLightSquare.SetToolTip(this._buttonLightSquare, "Select the color for the board\'s light squares");
            this._buttonLightSquare.UseVisualStyleBackColor = true;
            this._buttonLightSquare.Click += new System.EventHandler(this.OnButtonLightSquareColorClick);
            // 
            // _buttonLastmove
            // 
            this._buttonLastmove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._buttonLastmove.Location = new System.Drawing.Point(480, 25);
            this._buttonLastmove.Margin = new System.Windows.Forms.Padding(0);
            this._buttonLastmove.Name = "_buttonLastmove";
            this._buttonLastmove.Size = new System.Drawing.Size(53, 48);
            this._buttonLastmove.TabIndex = 36;
            this._toolTipLastMove.SetToolTip(this._buttonLastmove, "Select the color for the \'Highlight Last Move\' options");
            this._buttonLastmove.UseVisualStyleBackColor = true;
            this._buttonLastmove.Click += new System.EventHandler(this.OnButtonHighlightLastmoveColorClick);
            // 
            // _buttonOk
            // 
            this._buttonOk.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonOk.Location = new System.Drawing.Point(479, 485);
            this._buttonOk.Margin = new System.Windows.Forms.Padding(0);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(101, 30);
            this._buttonOk.TabIndex = 20;
            this._buttonOk.Text = "Ok";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.OnButtonOkClick);
            // 
            // _checkBoxUseSquareImages
            // 
            this._checkBoxUseSquareImages.AutoSize = true;
            this._checkBoxUseSquareImages.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxUseSquareImages.Location = new System.Drawing.Point(22, 38);
            this._checkBoxUseSquareImages.Margin = new System.Windows.Forms.Padding(0);
            this._checkBoxUseSquareImages.Name = "_checkBoxUseSquareImages";
            this._checkBoxUseSquareImages.Size = new System.Drawing.Size(109, 21);
            this._checkBoxUseSquareImages.TabIndex = 25;
            this._checkBoxUseSquareImages.Text = "Use Images";
            this._toolTipUseSquareImages.SetToolTip(this._checkBoxUseSquareImages, "Use bitmaps instead of colors for squares");
            this._checkBoxUseSquareImages.UseVisualStyleBackColor = true;
            this._checkBoxUseSquareImages.CheckedChanged += new System.EventHandler(this.OnCheckBoxUseSquareImagesCheckedChanged);
            // 
            // _labelLightSquarePath
            // 
            this._labelLightSquarePath.AutoSize = true;
            this._labelLightSquarePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLightSquarePath.Location = new System.Drawing.Point(19, 114);
            this._labelLightSquarePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelLightSquarePath.Name = "_labelLightSquarePath";
            this._labelLightSquarePath.Size = new System.Drawing.Size(152, 17);
            this._labelLightSquarePath.TabIndex = 27;
            this._labelLightSquarePath.Text = "Light Square Image:";
            // 
            // _labelDarkSquarePath
            // 
            this._labelDarkSquarePath.AutoSize = true;
            this._labelDarkSquarePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelDarkSquarePath.Location = new System.Drawing.Point(19, 77);
            this._labelDarkSquarePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelDarkSquarePath.Name = "_labelDarkSquarePath";
            this._labelDarkSquarePath.Size = new System.Drawing.Size(150, 17);
            this._labelDarkSquarePath.TabIndex = 26;
            this._labelDarkSquarePath.Text = "Dark Square Image:";
            // 
            // _textBoxDarkSquarePath
            // 
            this._textBoxDarkSquarePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxDarkSquarePath.Location = new System.Drawing.Point(181, 75);
            this._textBoxDarkSquarePath.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxDarkSquarePath.Name = "_textBoxDarkSquarePath";
            this._textBoxDarkSquarePath.Size = new System.Drawing.Size(283, 24);
            this._textBoxDarkSquarePath.TabIndex = 28;
            this._toolTiplDarkSquarePath.SetToolTip(this._textBoxDarkSquarePath, "File used for dark squares");
            this._textBoxDarkSquarePath.TextChanged += new System.EventHandler(this.OnTextBoxDarkSquarePathTextChanged);
            // 
            // _textBoxLightSquarePath
            // 
            this._textBoxLightSquarePath.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._textBoxLightSquarePath.Location = new System.Drawing.Point(181, 112);
            this._textBoxLightSquarePath.Margin = new System.Windows.Forms.Padding(4);
            this._textBoxLightSquarePath.Name = "_textBoxLightSquarePath";
            this._textBoxLightSquarePath.Size = new System.Drawing.Size(283, 24);
            this._textBoxLightSquarePath.TabIndex = 29;
            this._toolTipLightSquarePath.SetToolTip(this._textBoxLightSquarePath, "File used for light squares");
            this._textBoxLightSquarePath.TextChanged += new System.EventHandler(this.OnTextBoxLightSquarePathTextChanged);
            // 
            // _buttonLightBrowseButton
            // 
            this._buttonLightBrowseButton.Font = new System.Drawing.Font("Verdana", 10F);
            this._buttonLightBrowseButton.Location = new System.Drawing.Point(475, 110);
            this._buttonLightBrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this._buttonLightBrowseButton.Name = "_buttonLightBrowseButton";
            this._buttonLightBrowseButton.Size = new System.Drawing.Size(58, 27);
            this._buttonLightBrowseButton.TabIndex = 31;
            this._buttonLightBrowseButton.Text = "...";
            this._buttonLightBrowseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._toolTipLightBrowseButton.SetToolTip(this._buttonLightBrowseButton, "Browse file system for light square bitmap");
            this._buttonLightBrowseButton.UseVisualStyleBackColor = true;
            this._buttonLightBrowseButton.Click += new System.EventHandler(this.OnButtonLightDialogClick);
            // 
            // _buttonDarkBrowseButton
            // 
            this._buttonDarkBrowseButton.Font = new System.Drawing.Font("Verdana", 10F);
            this._buttonDarkBrowseButton.Location = new System.Drawing.Point(475, 74);
            this._buttonDarkBrowseButton.Margin = new System.Windows.Forms.Padding(0);
            this._buttonDarkBrowseButton.Name = "_buttonDarkBrowseButton";
            this._buttonDarkBrowseButton.Size = new System.Drawing.Size(58, 27);
            this._buttonDarkBrowseButton.TabIndex = 32;
            this._buttonDarkBrowseButton.Text = "...";
            this._buttonDarkBrowseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._toolTipDarkBrowseButton.SetToolTip(this._buttonDarkBrowseButton, "Browse file system for dark square bitmap");
            this._buttonDarkBrowseButton.UseVisualStyleBackColor = true;
            this._buttonDarkBrowseButton.Click += new System.EventHandler(this.OnButtonDarkDialogClick);
            // 
            // _labelLastmove
            // 
            this._labelLastmove.AutoSize = true;
            this._labelLastmove.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelLastmove.Location = new System.Drawing.Point(379, 42);
            this._labelLastmove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._labelLastmove.Name = "_labelLastmove";
            this._labelLastmove.Size = new System.Drawing.Size(85, 17);
            this._labelLastmove.TabIndex = 35;
            this._labelLastmove.Text = "Last Move:";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonCancel.Location = new System.Drawing.Point(369, 485);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(101, 30);
            this._buttonCancel.TabIndex = 37;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.OnButtonCancelClick);
            // 
            // _textBoxOpacity
            // 
            this._textBoxOpacity.Location = new System.Drawing.Point(481, 90);
            this._textBoxOpacity.Name = "_textBoxOpacity";
            this._textBoxOpacity.Size = new System.Drawing.Size(52, 26);
            this._textBoxOpacity.TabIndex = 38;
            this._toolTipOpacity.SetToolTip(this._textBoxOpacity, "Select the transparency of board square colors (from 0-255)");
            this._textBoxOpacity.TextChanged += new System.EventHandler(this.OnTextBoxOpacityTextChanged);
            // 
            // _labelOpacity
            // 
            this._labelOpacity.AutoSize = true;
            this._labelOpacity.Location = new System.Drawing.Point(393, 93);
            this._labelOpacity.Name = "_labelOpacity";
            this._labelOpacity.Size = new System.Drawing.Size(71, 18);
            this._labelOpacity.TabIndex = 39;
            this._labelOpacity.Text = "Opacity:";
            // 
            // _radioButtonNoHighlight
            // 
            this._radioButtonNoHighlight.AutoSize = true;
            this._radioButtonNoHighlight.Font = new System.Drawing.Font("Verdana", 10F);
            this._radioButtonNoHighlight.Location = new System.Drawing.Point(22, 35);
            this._radioButtonNoHighlight.Margin = new System.Windows.Forms.Padding(4);
            this._radioButtonNoHighlight.Name = "_radioButtonNoHighlight";
            this._radioButtonNoHighlight.Size = new System.Drawing.Size(62, 21);
            this._radioButtonNoHighlight.TabIndex = 0;
            this._radioButtonNoHighlight.TabStop = true;
            this._radioButtonNoHighlight.Text = "None";
            this._toolTipNoHighlight.SetToolTip(this._radioButtonNoHighlight, "No highlight");
            this._radioButtonNoHighlight.UseVisualStyleBackColor = true;
            this._radioButtonNoHighlight.CheckedChanged += new System.EventHandler(this.OnRadioButtonNoHighlightCheckedChanged);
            // 
            // _radioButtonFillHighlight
            // 
            this._radioButtonFillHighlight.AutoSize = true;
            this._radioButtonFillHighlight.Font = new System.Drawing.Font("Verdana", 10F);
            this._radioButtonFillHighlight.Location = new System.Drawing.Point(22, 64);
            this._radioButtonFillHighlight.Margin = new System.Windows.Forms.Padding(4);
            this._radioButtonFillHighlight.Name = "_radioButtonFillHighlight";
            this._radioButtonFillHighlight.Size = new System.Drawing.Size(60, 21);
            this._radioButtonFillHighlight.TabIndex = 1;
            this._radioButtonFillHighlight.TabStop = true;
            this._radioButtonFillHighlight.Text = "Fill";
            this._toolTipFillHighlight.SetToolTip(this._radioButtonFillHighlight, "Fill square with \'Last Move\' color");
            this._radioButtonFillHighlight.UseVisualStyleBackColor = true;
            this._radioButtonFillHighlight.CheckedChanged += new System.EventHandler(this.OnRadioButtonFillCheckedChanged);
            // 
            // _radioButtonBorderHighlight
            // 
            this._radioButtonBorderHighlight.AutoSize = true;
            this._radioButtonBorderHighlight.Font = new System.Drawing.Font("Verdana", 10F);
            this._radioButtonBorderHighlight.Location = new System.Drawing.Point(22, 95);
            this._radioButtonBorderHighlight.Margin = new System.Windows.Forms.Padding(4);
            this._radioButtonBorderHighlight.Name = "_radioButtonBorderHighlight";
            this._radioButtonBorderHighlight.Size = new System.Drawing.Size(74, 21);
            this._radioButtonBorderHighlight.TabIndex = 2;
            this._radioButtonBorderHighlight.TabStop = true;
            this._radioButtonBorderHighlight.Text = "Border";
            this._toolTipBorderHighlight.SetToolTip(this._radioButtonBorderHighlight, "Thin square borders");
            this._radioButtonBorderHighlight.UseVisualStyleBackColor = true;
            this._radioButtonBorderHighlight.CheckedChanged += new System.EventHandler(this.OnRadioButtonBorderHighlightCheckedChanged);
            // 
            // _radioButtonArrowHighlight
            // 
            this._radioButtonArrowHighlight.AutoSize = true;
            this._radioButtonArrowHighlight.Font = new System.Drawing.Font("Verdana", 10F);
            this._radioButtonArrowHighlight.Location = new System.Drawing.Point(22, 124);
            this._radioButtonArrowHighlight.Margin = new System.Windows.Forms.Padding(4);
            this._radioButtonArrowHighlight.Name = "_radioButtonArrowHighlight";
            this._radioButtonArrowHighlight.Size = new System.Drawing.Size(68, 21);
            this._radioButtonArrowHighlight.TabIndex = 4;
            this._radioButtonArrowHighlight.TabStop = true;
            this._radioButtonArrowHighlight.Text = "Arrow";
            this._toolTipArrowHighlight.SetToolTip(this._radioButtonArrowHighlight, "Arrow indicating \'from\' and \'to\' squares");
            this._radioButtonArrowHighlight.UseVisualStyleBackColor = true;
            this._radioButtonArrowHighlight.CheckedChanged += new System.EventHandler(this.OnRadioButtonArrowCheckedChanged);
            // 
            // _groupBoxHighlightLastMove
            // 
            this._groupBoxHighlightLastMove.Controls.Add(this._radioButtonFillHighlight);
            this._groupBoxHighlightLastMove.Controls.Add(this._radioButtonArrowHighlight);
            this._groupBoxHighlightLastMove.Controls.Add(this._radioButtonNoHighlight);
            this._groupBoxHighlightLastMove.Controls.Add(this._radioButtonBorderHighlight);
            this._groupBoxHighlightLastMove.Location = new System.Drawing.Point(22, 350);
            this._groupBoxHighlightLastMove.Name = "_groupBoxHighlightLastMove";
            this._groupBoxHighlightLastMove.Size = new System.Drawing.Size(200, 165);
            this._groupBoxHighlightLastMove.TabIndex = 40;
            this._groupBoxHighlightLastMove.TabStop = false;
            this._groupBoxHighlightLastMove.Text = "Highlight Last Move";
            // 
            // _groupBoxSquareImages
            // 
            this._groupBoxSquareImages.Controls.Add(this._textBoxDarkSquarePath);
            this._groupBoxSquareImages.Controls.Add(this._labelDarkSquarePath);
            this._groupBoxSquareImages.Controls.Add(this._textBoxLightSquarePath);
            this._groupBoxSquareImages.Controls.Add(this._buttonLightBrowseButton);
            this._groupBoxSquareImages.Controls.Add(this._labelLightSquarePath);
            this._groupBoxSquareImages.Controls.Add(this._buttonDarkBrowseButton);
            this._groupBoxSquareImages.Controls.Add(this._checkBoxUseSquareImages);
            this._groupBoxSquareImages.Location = new System.Drawing.Point(22, 177);
            this._groupBoxSquareImages.Name = "_groupBoxSquareImages";
            this._groupBoxSquareImages.Size = new System.Drawing.Size(558, 157);
            this._groupBoxSquareImages.TabIndex = 41;
            this._groupBoxSquareImages.TabStop = false;
            this._groupBoxSquareImages.Text = "Images";
            // 
            // _groupBoxSquareColors
            // 
            this._groupBoxSquareColors.Controls.Add(this._buttonLightSquare);
            this._groupBoxSquareColors.Controls.Add(this._labelShowLightSquareColor);
            this._groupBoxSquareColors.Controls.Add(this._buttonDarkSquare);
            this._groupBoxSquareColors.Controls.Add(this._labelOpacity);
            this._groupBoxSquareColors.Controls.Add(this._labelShowDarkSquareColor);
            this._groupBoxSquareColors.Controls.Add(this._textBoxOpacity);
            this._groupBoxSquareColors.Controls.Add(this._buttonLastmove);
            this._groupBoxSquareColors.Controls.Add(this._labelLastmove);
            this._groupBoxSquareColors.Location = new System.Drawing.Point(22, 14);
            this._groupBoxSquareColors.Name = "_groupBoxSquareColors";
            this._groupBoxSquareColors.Size = new System.Drawing.Size(558, 149);
            this._groupBoxSquareColors.TabIndex = 42;
            this._groupBoxSquareColors.TabStop = false;
            this._groupBoxSquareColors.Text = "Colors";
            // 
            // FormBoardSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 534);
            this.Controls.Add(this._groupBoxSquareColors);
            this.Controls.Add(this._groupBoxSquareImages);
            this.Controls.Add(this._groupBoxHighlightLastMove);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBoardSetting";
            this.Text = "Board Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnBoardSettingDialogFormClosing);
            this.Shown += new System.EventHandler(this.OnBoardSettingDialogShown);
            this._groupBoxHighlightLastMove.ResumeLayout(false);
            this._groupBoxHighlightLastMove.PerformLayout();
            this._groupBoxSquareImages.ResumeLayout(false);
            this._groupBoxSquareImages.PerformLayout();
            this._groupBoxSquareColors.ResumeLayout(false);
            this._groupBoxSquareColors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label _labelShowDarkSquareColor;
        private System.Windows.Forms.Label _labelShowLightSquareColor;
        private System.Windows.Forms.Label _labelLastmove;		
        private System.Windows.Forms.Button _buttonDarkSquare;
        private System.Windows.Forms.Button _buttonLightSquare;
        private System.Windows.Forms.Button _buttonLastmove;
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.CheckBox _checkBoxUseSquareImages;
        private System.Windows.Forms.Label _labelLightSquarePath;
        private System.Windows.Forms.Label _labelDarkSquarePath;
        private System.Windows.Forms.TextBox _textBoxDarkSquarePath;
        private System.Windows.Forms.TextBox _textBoxLightSquarePath;
        private System.Windows.Forms.Button _buttonLightBrowseButton;
        private System.Windows.Forms.Button _buttonDarkBrowseButton;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.TextBox _textBoxOpacity;
        private System.Windows.Forms.Label _labelOpacity;
        private System.Windows.Forms.RadioButton _radioButtonNoHighlight;
        private System.Windows.Forms.RadioButton _radioButtonFillHighlight;
        private System.Windows.Forms.RadioButton _radioButtonBorderHighlight;
        private System.Windows.Forms.RadioButton _radioButtonArrowHighlight;
        private System.Windows.Forms.GroupBox _groupBoxHighlightLastMove;
        private System.Windows.Forms.GroupBox _groupBoxSquareImages;
        private System.Windows.Forms.GroupBox _groupBoxSquareColors;
        private System.Windows.Forms.ToolTip _toolTipLightSquare;
        private System.Windows.Forms.ToolTip _toolTipDarkSquare;
        private System.Windows.Forms.ToolTip _toolTipLastMove;
        private System.Windows.Forms.ToolTip _toolTipOpacity;
        private System.Windows.Forms.ToolTip _toolTipUseSquareImages;
        private System.Windows.Forms.ToolTip _toolTiplDarkSquarePath;
        private System.Windows.Forms.ToolTip _toolTipLightSquarePath;
        private System.Windows.Forms.ToolTip _toolTipNoHighlight;
        private System.Windows.Forms.ToolTip _toolTipFillHighlight;
        private System.Windows.Forms.ToolTip _toolTipBorderHighlight;
        private System.Windows.Forms.ToolTip _toolTipArrowHighlight;
        private System.Windows.Forms.ToolTip _toolTipDarkBrowseButton;
        private System.Windows.Forms.ToolTip _toolTipLightBrowseButton;
    }
}