namespace CertificateGenerator.Forms
{
    partial class AboutBox
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
            this.okButton = new MetroFramework.Controls.MetroButton();
            this.leftIconPictureBox = new System.Windows.Forms.PictureBox();
            this.telegramButton = new MetroFramework.Controls.MetroButton();
            this.emailButton = new MetroFramework.Controls.MetroButton();
            this.aboutLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.okButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.okButton.BackgroundColor = System.Drawing.Color.Empty;
            this.okButton.CustomMouseEnterColors = false;
            this.okButton.FontSize = 12F;
            this.okButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.okButton.ForegroundColor = System.Drawing.Color.White;
            this.okButton.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.okButton.Location = new System.Drawing.Point(179, 266);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 26);
            this.okButton.Style = "Yellow";
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // leftIconPictureBox
            // 
            this.leftIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.leftIconPictureBox.Location = new System.Drawing.Point(23, 17);
            this.leftIconPictureBox.Name = "leftIconPictureBox";
            this.leftIconPictureBox.Size = new System.Drawing.Size(60, 60);
            this.leftIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftIconPictureBox.TabIndex = 3;
            this.leftIconPictureBox.TabStop = false;
            // 
            // telegramButton
            // 
            this.telegramButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.telegramButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.telegramButton.BackgroundColor = System.Drawing.Color.Empty;
            this.telegramButton.CustomMouseEnterColors = false;
            this.telegramButton.FontSize = 15F;
            this.telegramButton.FontStyle = System.Drawing.FontStyle.Regular;
            this.telegramButton.ForegroundColor = System.Drawing.Color.Empty;
            this.telegramButton.Highlight = true;
            this.telegramButton.HighlightColor = System.Drawing.Color.Empty;
            this.telegramButton.Location = new System.Drawing.Point(23, 204);
            this.telegramButton.Name = "telegramButton";
            this.telegramButton.Size = new System.Drawing.Size(412, 41);
            this.telegramButton.Style = "blue";
            this.telegramButton.TabIndex = 12;
            this.telegramButton.TabStop = false;
            this.telegramButton.Text = "selectPath";
            this.telegramButton.Click += new System.EventHandler(this.telegramButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.emailButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.emailButton.BackgroundColor = System.Drawing.Color.Empty;
            this.emailButton.CustomMouseEnterColors = false;
            this.emailButton.FontSize = 15F;
            this.emailButton.FontStyle = System.Drawing.FontStyle.Regular;
            this.emailButton.ForegroundColor = System.Drawing.Color.Empty;
            this.emailButton.Highlight = true;
            this.emailButton.HighlightColor = System.Drawing.Color.Empty;
            this.emailButton.Location = new System.Drawing.Point(23, 157);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(412, 41);
            this.emailButton.Style = "Red";
            this.emailButton.TabIndex = 13;
            this.emailButton.TabStop = false;
            this.emailButton.Text = "selectPath";
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // aboutLabel
            // 
            this.aboutLabel.Location = new System.Drawing.Point(23, 89);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(412, 56);
            this.aboutLabel.TabIndex = 14;
            this.aboutLabel.Text = "about";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(458, 302);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.telegramButton);
            this.Controls.Add(this.leftIconPictureBox);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Vazirmatn Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = "Yellow";
            this.StyleColor = System.Drawing.Color.Gold;
            this.Text = "app name";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton okButton;
        private System.Windows.Forms.PictureBox leftIconPictureBox;
        private MetroFramework.Controls.MetroButton telegramButton;
        private MetroFramework.Controls.MetroButton emailButton;
        private MetroFramework.Controls.MetroLabel aboutLabel;
    }
}