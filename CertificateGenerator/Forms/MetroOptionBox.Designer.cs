namespace CertificateGenerator.Forms
{
    partial class MetroOptionBox
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
            this.yesButton = new MetroFramework.Controls.MetroButton();
            this.leftIconPictureBox = new System.Windows.Forms.PictureBox();
            this.rightIconPictureBox = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.noButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.yesButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.yesButton.BackgroundColor = System.Drawing.Color.Green;
            this.yesButton.CustomMouseEnterColors = false;
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.yesButton.FontSize = 20F;
            this.yesButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.yesButton.ForegroundColor = System.Drawing.Color.White;
            this.yesButton.Highlight = true;
            this.yesButton.HighlightColor = System.Drawing.Color.Lime;
            this.yesButton.Location = new System.Drawing.Point(53, 237);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(246, 40);
            this.yesButton.Style = "Yellow";
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "yes";
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
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
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Vazirmatn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(23, 84);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(598, 122);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noButton
            // 
            this.noButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.noButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.noButton.BackgroundColor = System.Drawing.Color.DarkRed;
            this.noButton.CustomMouseEnterColors = false;
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.noButton.FontSize = 20F;
            this.noButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.noButton.ForegroundColor = System.Drawing.Color.White;
            this.noButton.Highlight = true;
            this.noButton.HighlightColor = System.Drawing.Color.Red;
            this.noButton.Location = new System.Drawing.Point(347, 237);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(246, 40);
            this.noButton.Style = "Yellow";
            this.noButton.TabIndex = 2;
            this.noButton.Text = "no";
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // MetroOptionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(644, 308);
            this.ControlBox = false;
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.rightIconPictureBox);
            this.Controls.Add(this.leftIconPictureBox);
            this.Controls.Add(this.yesButton);
            this.Font = new System.Drawing.Font("Vazirmatn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MetroOptionBox";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = "Yellow";
            this.Text = "Error";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MetroOptionBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.leftIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightIconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton yesButton;
        private System.Windows.Forms.PictureBox leftIconPictureBox;
        private System.Windows.Forms.PictureBox rightIconPictureBox;
        private System.Windows.Forms.Label messageLabel;
        private MetroFramework.Controls.MetroButton noButton;
    }
}