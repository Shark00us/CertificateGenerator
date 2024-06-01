namespace CertificateGenerator.Forms
{
    partial class CertificateSaveBox
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
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.leftIconPictureBox = new System.Windows.Forms.PictureBox();
            this.rightIconPictureBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new MetroFramework.Controls.MetroButton();
            this.fileNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.savePathTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fileNameLabel = new MetroFramework.Controls.MetroLabel();
            this.selectPathButton = new MetroFramework.Controls.MetroButton();
            this.pathFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.showResultsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.saveButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.saveButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.saveButton.CustomMouseEnterColors = false;
            this.saveButton.FontSize = 20F;
            this.saveButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.saveButton.ForegroundColor = System.Drawing.Color.White;
            this.saveButton.Highlight = true;
            this.saveButton.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.saveButton.Location = new System.Drawing.Point(53, 231);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(364, 40);
            this.saveButton.Style = "Yellow";
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // leftIconPictureBox
            // 
            this.leftIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.leftIconPictureBox.Location = new System.Drawing.Point(23, 17);
            this.leftIconPictureBox.Name = "leftIconPictureBox";
            this.leftIconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.leftIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftIconPictureBox.TabIndex = 3;
            this.leftIconPictureBox.TabStop = false;
            // 
            // rightIconPictureBox
            // 
            this.rightIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rightIconPictureBox.Location = new System.Drawing.Point(571, 17);
            this.rightIconPictureBox.Name = "rightIconPictureBox";
            this.rightIconPictureBox.Size = new System.Drawing.Size(50, 50);
            this.rightIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightIconPictureBox.TabIndex = 4;
            this.rightIconPictureBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.closeButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.closeButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.closeButton.CustomMouseEnterColors = false;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.FontSize = 20F;
            this.closeButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.closeButton.ForegroundColor = System.Drawing.Color.White;
            this.closeButton.Highlight = true;
            this.closeButton.HighlightColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(433, 231);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(160, 40);
            this.closeButton.Style = "Yellow";
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Text = "close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.BorderColor = System.Drawing.Color.Empty;
            this.fileNameTextBox.FontSize = MetroFramework.Drawing.MetroFontSize.Px18;
            this.fileNameTextBox.Location = new System.Drawing.Point(23, 147);
            this.fileNameTextBox.MaxLength = 100;
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(459, 41);
            this.fileNameTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.fileNameTextBox.TabIndex = 8;
            this.fileNameTextBox.TabStop = false;
            this.fileNameTextBox.Text = "filename";
            this.fileNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.BorderColor = System.Drawing.Color.Empty;
            this.savePathTextBox.FontSize = MetroFramework.Drawing.MetroFontSize.Px18;
            this.savePathTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.savePathTextBox.Location = new System.Drawing.Point(23, 100);
            this.savePathTextBox.MaxLength = 220;
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.ReadOnly = true;
            this.savePathTextBox.Size = new System.Drawing.Size(483, 41);
            this.savePathTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.savePathTextBox.TabIndex = 9;
            this.savePathTextBox.TabStop = false;
            this.savePathTextBox.Text = "Path//";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileNameLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.fileNameLabel.Location = new System.Drawing.Point(488, 147);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(133, 41);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "fileName";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectPathButton
            // 
            this.selectPathButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.selectPathButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.selectPathButton.BackgroundColor = System.Drawing.Color.Empty;
            this.selectPathButton.CustomMouseEnterColors = false;
            this.selectPathButton.FontSize = 14F;
            this.selectPathButton.FontStyle = System.Drawing.FontStyle.Regular;
            this.selectPathButton.ForegroundColor = System.Drawing.Color.Empty;
            this.selectPathButton.Highlight = true;
            this.selectPathButton.HighlightColor = System.Drawing.Color.Empty;
            this.selectPathButton.Location = new System.Drawing.Point(518, 100);
            this.selectPathButton.Name = "selectPathButton";
            this.selectPathButton.Size = new System.Drawing.Size(103, 41);
            this.selectPathButton.Style = "blue";
            this.selectPathButton.TabIndex = 12;
            this.selectPathButton.TabStop = false;
            this.selectPathButton.Text = "selectPath";
            this.selectPathButton.Click += new System.EventHandler(this.selectPathButton_Click);
            // 
            // showResultsCheckBox
            // 
            this.showResultsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showResultsCheckBox.Font = new System.Drawing.Font("Vazirmatn Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResultsCheckBox.ForeColor = System.Drawing.Color.White;
            this.showResultsCheckBox.Location = new System.Drawing.Point(53, 194);
            this.showResultsCheckBox.Name = "showResultsCheckBox";
            this.showResultsCheckBox.Size = new System.Drawing.Size(540, 31);
            this.showResultsCheckBox.TabIndex = 13;
            this.showResultsCheckBox.TabStop = false;
            this.showResultsCheckBox.Text = "showResults";
            this.showResultsCheckBox.UseVisualStyleBackColor = false;
            this.showResultsCheckBox.CheckedChanged += new System.EventHandler(this.showResultsCheckBox_CheckedChanged);
            // 
            // CertificateSaveBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(644, 300);
            this.ControlBox = false;
            this.Controls.Add(this.showResultsCheckBox);
            this.Controls.Add(this.selectPathButton);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.rightIconPictureBox);
            this.Controls.Add(this.leftIconPictureBox);
            this.Controls.Add(this.saveButton);
            this.Font = new System.Drawing.Font("Vazirmatn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateSaveBox";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = "Yellow";
            this.StyleColor = System.Drawing.Color.SkyBlue;
            this.Text = "save";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CertificateSaveBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveButton;
        private System.Windows.Forms.PictureBox leftIconPictureBox;
        private System.Windows.Forms.PictureBox rightIconPictureBox;
        private MetroFramework.Controls.MetroButton closeButton;
        private MetroFramework.Controls.MetroTextBox fileNameTextBox;
        private MetroFramework.Controls.MetroTextBox savePathTextBox;
        private MetroFramework.Controls.MetroLabel fileNameLabel;
        private MetroFramework.Controls.MetroButton selectPathButton;
        private System.Windows.Forms.FolderBrowserDialog pathFolderBrowserDialog;
        private System.Windows.Forms.CheckBox showResultsCheckBox;
    }
}