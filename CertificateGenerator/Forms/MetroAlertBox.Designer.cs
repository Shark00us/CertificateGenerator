namespace CertificateGenerator.Forms
{
    partial class MetroAlertBox
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
            this.exceptionMessageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stackTraceTextBox = new MetroFramework.Controls.MetroTextBox();
            this.leftIconPictureBox = new System.Windows.Forms.PictureBox();
            this.rightIconPictureBox = new System.Windows.Forms.PictureBox();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.okButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.okButton.BackgroundColor = System.Drawing.Color.Empty;
            this.okButton.CustomMouseEnterColors = false;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FontSize = 17F;
            this.okButton.FontStyle = System.Drawing.FontStyle.Regular;
            this.okButton.ForegroundColor = System.Drawing.Color.Empty;
            this.okButton.Highlight = true;
            this.okButton.HighlightColor = System.Drawing.Color.Empty;
            this.okButton.Location = new System.Drawing.Point(233, 288);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(178, 40);
            this.okButton.Style = "Yellow";
            this.okButton.TabIndex = 0;
            this.okButton.TabStop = false;
            this.okButton.Text = "ok";
            // 
            // exceptionMessageTextBox
            // 
            this.exceptionMessageTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exceptionMessageTextBox.BorderColor = System.Drawing.Color.Empty;
            this.exceptionMessageTextBox.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.exceptionMessageTextBox.ForeColor = System.Drawing.Color.White;
            this.exceptionMessageTextBox.Location = new System.Drawing.Point(23, 130);
            this.exceptionMessageTextBox.Multiline = true;
            this.exceptionMessageTextBox.Name = "exceptionMessageTextBox";
            this.exceptionMessageTextBox.ReadOnly = true;
            this.exceptionMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exceptionMessageTextBox.Size = new System.Drawing.Size(598, 43);
            this.exceptionMessageTextBox.Style = "Yellow";
            this.exceptionMessageTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.exceptionMessageTextBox.TabIndex = 1;
            this.exceptionMessageTextBox.Text = "exc message";
            this.exceptionMessageTextBox.UseStyleColors = true;
            // 
            // stackTraceTextBox
            // 
            this.stackTraceTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stackTraceTextBox.BorderColor = System.Drawing.Color.Empty;
            this.stackTraceTextBox.FontSize = MetroFramework.Drawing.MetroFontSize.Px12;
            this.stackTraceTextBox.ForeColor = System.Drawing.Color.White;
            this.stackTraceTextBox.Location = new System.Drawing.Point(23, 179);
            this.stackTraceTextBox.Multiline = true;
            this.stackTraceTextBox.Name = "stackTraceTextBox";
            this.stackTraceTextBox.ReadOnly = true;
            this.stackTraceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stackTraceTextBox.Size = new System.Drawing.Size(598, 97);
            this.stackTraceTextBox.Style = "Yellow";
            this.stackTraceTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.stackTraceTextBox.TabIndex = 2;
            this.stackTraceTextBox.Text = "stackTrace";
            this.stackTraceTextBox.UseStyleColors = true;
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
            // messageTextBox
            // 
            this.messageTextBox.BorderColor = System.Drawing.Color.Empty;
            this.messageTextBox.FontSize = MetroFramework.Drawing.MetroFontSize.Px20;
            this.messageTextBox.FontWeight = MetroFramework.Drawing.MetroFontWeight.Regular;
            this.messageTextBox.Location = new System.Drawing.Point(23, 78);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageTextBox.Size = new System.Drawing.Size(598, 46);
            this.messageTextBox.Style = "Yellow";
            this.messageTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.messageTextBox.TabIndex = 5;
            this.messageTextBox.Text = "message";
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.messageTextBox.UseStyleColors = true;
            // 
            // MetroAlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(644, 340);
            this.ControlBox = false;
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.rightIconPictureBox);
            this.Controls.Add(this.leftIconPictureBox);
            this.Controls.Add(this.stackTraceTextBox);
            this.Controls.Add(this.exceptionMessageTextBox);
            this.Controls.Add(this.okButton);
            this.Font = new System.Drawing.Font("Vazirmatn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroAlertBox";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = "Yellow";
            this.Text = "Error";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton okButton;
        private MetroFramework.Controls.MetroTextBox exceptionMessageTextBox;
        private MetroFramework.Controls.MetroTextBox stackTraceTextBox;
        private System.Windows.Forms.PictureBox leftIconPictureBox;
        private System.Windows.Forms.PictureBox rightIconPictureBox;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
    }
}