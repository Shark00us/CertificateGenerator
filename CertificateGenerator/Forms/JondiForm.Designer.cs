namespace CertificateGenerator.Forms
{
    partial class JondiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param nameAndSurname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.serialTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fatherNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nationalIdTextBox = new MetroFramework.Controls.MetroTextBox();
            this.courseNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.courseLengthTextBox = new MetroFramework.Controls.MetroTextBox();
            this.dateOfBirthMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.courseEndMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.pictureSelectButton = new MetroFramework.Controls.MetroButton();
            this.pictureSelectOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.serialLabel = new MetroFramework.Controls.MetroLabel();
            this.nationalIDLabel = new MetroFramework.Controls.MetroLabel();
            this.fatherLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.courseLengthLabel = new MetroFramework.Controls.MetroLabel();
            this.courseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.dateOfBirthLabel = new MetroFramework.Controls.MetroLabel();
            this.courseEndLabel = new MetroFramework.Controls.MetroLabel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // serialTextBox
            // 
            this.serialTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.serialTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.serialTextBox.Location = new System.Drawing.Point(246, 28);
            this.serialTextBox.MaxLength = 10;
            this.serialTextBox.Multiline = true;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(445, 37);
            this.serialTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.serialTextBox.TabIndex = 1;
            this.serialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.serialTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serialTextBox.UseStyleColors = true;
            this.serialTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.nameTextBox.Location = new System.Drawing.Point(246, 74);
            this.nameTextBox.MaxLength = 35;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(394, 37);
            this.nameTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nameTextBox.UseStyleColors = true;
            this.nameTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.fatherNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.fatherNameTextBox.Location = new System.Drawing.Point(246, 120);
            this.fatherNameTextBox.MaxLength = 20;
            this.fatherNameTextBox.Multiline = true;
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(466, 37);
            this.fatherNameTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.fatherNameTextBox.TabIndex = 3;
            this.fatherNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fatherNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fatherNameTextBox.UseStyleColors = true;
            this.fatherNameTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nationalIdTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.nationalIdTextBox.Location = new System.Drawing.Point(246, 210);
            this.nationalIdTextBox.MaxLength = 10;
            this.nationalIdTextBox.Multiline = true;
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.Size = new System.Drawing.Size(457, 37);
            this.nationalIdTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.nationalIdTextBox.TabIndex = 5;
            this.nationalIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nationalIdTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nationalIdTextBox.UseStyleColors = true;
            this.nationalIdTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.courseNameTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.courseNameTextBox.Location = new System.Drawing.Point(246, 257);
            this.courseNameTextBox.MaxLength = 45;
            this.courseNameTextBox.Multiline = true;
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.Size = new System.Drawing.Size(457, 37);
            this.courseNameTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.courseNameTextBox.TabIndex = 6;
            this.courseNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseNameTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.courseNameTextBox.UseStyleColors = true;
            this.courseNameTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // courseLengthTextBox
            // 
            this.courseLengthTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.courseLengthTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.courseLengthTextBox.Location = new System.Drawing.Point(246, 348);
            this.courseLengthTextBox.MaxLength = 3;
            this.courseLengthTextBox.Multiline = true;
            this.courseLengthTextBox.Name = "courseLengthTextBox";
            this.courseLengthTextBox.Size = new System.Drawing.Size(445, 37);
            this.courseLengthTextBox.Style = MetroFramework.MetroColorStyle.Silver;
            this.courseLengthTextBox.TabIndex = 8;
            this.courseLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseLengthTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.courseLengthTextBox.UseStyleColors = true;
            this.courseLengthTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dateOfBirthMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOfBirthMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthMaskedTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(246, 166);
            this.dateOfBirthMaskedTextBox.Mask = "0000/00/00";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.PromptChar = ' ';
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(445, 34);
            this.dateOfBirthMaskedTextBox.TabIndex = 4;
            this.dateOfBirthMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOfBirthMaskedTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // courseEndMaskedTextBox
            // 
            this.courseEndMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.courseEndMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseEndMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseEndMaskedTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.courseEndMaskedTextBox.Location = new System.Drawing.Point(246, 304);
            this.courseEndMaskedTextBox.Mask = "0000/00/00";
            this.courseEndMaskedTextBox.Name = "courseEndMaskedTextBox";
            this.courseEndMaskedTextBox.PromptChar = ' ';
            this.courseEndMaskedTextBox.Size = new System.Drawing.Size(424, 34);
            this.courseEndMaskedTextBox.TabIndex = 7;
            this.courseEndMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseEndMaskedTextBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.ForestGreen;
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(23, 410);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(756, 45);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "ساخت گواهی";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Visible = false;
            this.generateButton.Click += new System.EventHandler(this.GenerateCertificate);
            // 
            // pictureSelectButton
            // 
            this.pictureSelectButton.Location = new System.Drawing.Point(23, 348);
            this.pictureSelectButton.Name = "pictureSelectButton";
            this.pictureSelectButton.Size = new System.Drawing.Size(189, 41);
            this.pictureSelectButton.Style = MetroFramework.MetroColorStyle.White;
            this.pictureSelectButton.TabIndex = 11;
            this.pictureSelectButton.TabStop = false;
            this.pictureSelectButton.Text = "انتخاب عکس پرسنلی";
            this.pictureSelectButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pictureSelectButton.Click += new System.EventHandler(this.pictureSelectButton_Click);
            // 
            // pictureSelectOpenFileDialog
            // 
            this.pictureSelectOpenFileDialog.Title = "انتخاب عکس";
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.serialLabel.Location = new System.Drawing.Point(697, 35);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(86, 25);
            this.serialLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.serialLabel.TabIndex = 12;
            this.serialLabel.Text = ": کد پیگیری";
            this.serialLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.serialLabel.UseStyleColors = true;
            // 
            // nationalIDLabel
            // 
            this.nationalIDLabel.AutoSize = true;
            this.nationalIDLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nationalIDLabel.Location = new System.Drawing.Point(709, 216);
            this.nationalIDLabel.Name = "nationalIDLabel";
            this.nationalIDLabel.Size = new System.Drawing.Size(72, 25);
            this.nationalIDLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.nationalIDLabel.TabIndex = 13;
            this.nationalIDLabel.Text = ": کد ملی";
            this.nationalIDLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nationalIDLabel.UseStyleColors = true;
            // 
            // fatherLabel
            // 
            this.fatherLabel.AutoSize = true;
            this.fatherLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fatherLabel.Location = new System.Drawing.Point(718, 127);
            this.fatherLabel.Name = "fatherLabel";
            this.fatherLabel.Size = new System.Drawing.Size(65, 25);
            this.fatherLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.fatherLabel.TabIndex = 14;
            this.fatherLabel.Text = ": نام پدر";
            this.fatherLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fatherLabel.UseStyleColors = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(643, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 25);
            this.nameLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = ": نام و نام خانوادگی";
            this.nameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.nameLabel.UseStyleColors = true;
            // 
            // courseLengthLabel
            // 
            this.courseLengthLabel.AutoSize = true;
            this.courseLengthLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.courseLengthLabel.Location = new System.Drawing.Point(692, 352);
            this.courseLengthLabel.Name = "courseLengthLabel";
            this.courseLengthLabel.Size = new System.Drawing.Size(89, 25);
            this.courseLengthLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.courseLengthLabel.TabIndex = 16;
            this.courseLengthLabel.Text = ": مدت دوره";
            this.courseLengthLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.courseLengthLabel.UseStyleColors = true;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.courseNameLabel.Location = new System.Drawing.Point(708, 263);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(73, 25);
            this.courseNameLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.courseNameLabel.TabIndex = 17;
            this.courseNameLabel.Text = ": نام دوره";
            this.courseNameLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.courseNameLabel.UseStyleColors = true;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(697, 171);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(84, 25);
            this.dateOfBirthLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.dateOfBirthLabel.TabIndex = 18;
            this.dateOfBirthLabel.Text = ": تاریخ تولد";
            this.dateOfBirthLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateOfBirthLabel.UseStyleColors = true;
            // 
            // courseEndLabel
            // 
            this.courseEndLabel.AutoSize = true;
            this.courseEndLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.courseEndLabel.Location = new System.Drawing.Point(676, 310);
            this.courseEndLabel.Name = "courseEndLabel";
            this.courseEndLabel.Size = new System.Drawing.Size(105, 25);
            this.courseEndLabel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.courseEndLabel.TabIndex = 19;
            this.courseEndLabel.Text = ": تاریخ برگزاری";
            this.courseEndLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.courseEndLabel.UseStyleColors = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Location = new System.Drawing.Point(73, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(87, 78);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 20;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoPictureBox_MouseClick);
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPictureBox.Location = new System.Drawing.Point(23, 96);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(189, 246);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 9;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.BackgroundImageChanged += new System.EventHandler(this.userPictureBox_BackgroundImageChanged);
            // 
            // JondiForm
            // 
            this.AcceptButton = this.generateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 470);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.courseEndLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.courseLengthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fatherLabel);
            this.Controls.Add(this.nationalIDLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.pictureSelectButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.courseEndMaskedTextBox);
            this.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.Controls.Add(this.courseLengthTextBox);
            this.Controls.Add(this.courseNameTextBox);
            this.Controls.Add(this.nationalIdTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.serialTextBox);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "JondiForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "گواهی ساز";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private MetroFramework.Controls.MetroTextBox serialTextBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroTextBox fatherNameTextBox;
        private MetroFramework.Controls.MetroTextBox nationalIdTextBox;
        private MetroFramework.Controls.MetroTextBox courseNameTextBox;
        private MetroFramework.Controls.MetroTextBox courseLengthTextBox;
        private System.Windows.Forms.MaskedTextBox dateOfBirthMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox courseEndMaskedTextBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private MetroFramework.Controls.MetroButton pictureSelectButton;
        private System.Windows.Forms.OpenFileDialog pictureSelectOpenFileDialog;
        private MetroFramework.Controls.MetroLabel serialLabel;
        private MetroFramework.Controls.MetroLabel nationalIDLabel;
        private MetroFramework.Controls.MetroLabel fatherLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel courseLengthLabel;
        private MetroFramework.Controls.MetroLabel courseNameLabel;
        private MetroFramework.Controls.MetroLabel dateOfBirthLabel;
        private MetroFramework.Controls.MetroLabel courseEndLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button generateButton;
    }
}