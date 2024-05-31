using System.Windows.Forms;
using CertificateGenerator.Utility_Side_Classes;
using MetroFramework.Controls;

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
            this.courseLengthOrUnitsTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pictureSelectButton = new MetroFramework.Controls.MetroButton();
            this.pictureSelectOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.serialLabel = new MetroFramework.Controls.MetroLabel();
            this.nationalIDLabel = new MetroFramework.Controls.MetroLabel();
            this.fatherLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.courseLengthorUnitsLabel = new MetroFramework.Controls.MetroLabel();
            this.courseNameLabel = new MetroFramework.Controls.MetroLabel();
            this.dateOfBirthLabel = new MetroFramework.Controls.MetroLabel();
            this.courseEndorCertDateLabel = new MetroFramework.Controls.MetroLabel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.certTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.certTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.avgLabel = new MetroFramework.Controls.MetroLabel();
            this.avgTextBox = new MetroFramework.Controls.MetroTextBox();
            this.certPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.generateButton = new MetroFramework.Controls.MetroButton();
            this.clearPictureBox = new System.Windows.Forms.PictureBox();
            this.linkPictureBox = new System.Windows.Forms.PictureBox();
            this.courseEndCertDateMaskedTextBox = new MetroFramework.Controls.MetroMaskedTextBox();
            this.dateOfBirthMaskedTextBox = new MetroFramework.Controls.MetroMaskedTextBox();
            this.userPictureLabel = new MetroFramework.Controls.MetroLabel();
            this.userPictureBorderedPanel = new CertificateGenerator.Utility_Side_Classes.BorderedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certPreviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // serialTextBox
            // 
            this.serialTextBox.BorderColor = System.Drawing.Color.Empty;
            this.serialTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialTextBox.Location = new System.Drawing.Point(232, 292);
            this.serialTextBox.MaxLength = 20;
            this.serialTextBox.Multiline = true;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.serialTextBox.Size = new System.Drawing.Size(394, 37);
            this.serialTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.serialTextBox.TabIndex = 5;
            this.serialTextBox.TabStop = false;
            this.serialTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serialTextBox.UseStyleColors = true;
            this.serialTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.serialTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderColor = System.Drawing.Color.Empty;
            this.nameTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(232, 112);
            this.nameTextBox.MaxLength = 35;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameTextBox.Size = new System.Drawing.Size(394, 37);
            this.nameTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nameTextBox.UseStyleColors = true;
            this.nameTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.BorderColor = System.Drawing.Color.Empty;
            this.fatherNameTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherNameTextBox.Location = new System.Drawing.Point(232, 157);
            this.fatherNameTextBox.MaxLength = 20;
            this.fatherNameTextBox.Multiline = true;
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fatherNameTextBox.Size = new System.Drawing.Size(394, 37);
            this.fatherNameTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.fatherNameTextBox.TabIndex = 2;
            this.fatherNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fatherNameTextBox.UseStyleColors = true;
            this.fatherNameTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.fatherNameTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.BorderColor = System.Drawing.Color.Empty;
            this.nationalIdTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalIdTextBox.Location = new System.Drawing.Point(232, 247);
            this.nationalIdTextBox.MaxLength = 10;
            this.nationalIdTextBox.Multiline = true;
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nationalIdTextBox.Size = new System.Drawing.Size(394, 37);
            this.nationalIdTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.nationalIdTextBox.TabIndex = 4;
            this.nationalIdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nationalIdTextBox.UseStyleColors = true;
            this.nationalIdTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.nationalIdTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // courseNameTextBox
            // 
            this.courseNameTextBox.BorderColor = System.Drawing.Color.Empty;
            this.courseNameTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameTextBox.Location = new System.Drawing.Point(232, 337);
            this.courseNameTextBox.MaxLength = 45;
            this.courseNameTextBox.Multiline = true;
            this.courseNameTextBox.Name = "courseNameTextBox";
            this.courseNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.courseNameTextBox.Size = new System.Drawing.Size(394, 37);
            this.courseNameTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.courseNameTextBox.TabIndex = 6;
            this.courseNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.courseNameTextBox.UseStyleColors = true;
            this.courseNameTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.courseNameTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // courseLengthOrUnitsTextBox
            // 
            this.courseLengthOrUnitsTextBox.BorderColor = System.Drawing.Color.Empty;
            this.courseLengthOrUnitsTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLengthOrUnitsTextBox.Location = new System.Drawing.Point(232, 427);
            this.courseLengthOrUnitsTextBox.MaxLength = 3;
            this.courseLengthOrUnitsTextBox.Multiline = true;
            this.courseLengthOrUnitsTextBox.Name = "courseLengthOrUnitsTextBox";
            this.courseLengthOrUnitsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.courseLengthOrUnitsTextBox.Size = new System.Drawing.Size(394, 37);
            this.courseLengthOrUnitsTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.courseLengthOrUnitsTextBox.TabIndex = 8;
            this.courseLengthOrUnitsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.courseLengthOrUnitsTextBox.UseStyleColors = true;
            this.courseLengthOrUnitsTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.courseLengthOrUnitsTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // pictureSelectButton
            // 
            this.pictureSelectButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.pictureSelectButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.pictureSelectButton.BackgroundColor = System.Drawing.Color.Empty;
            this.pictureSelectButton.CustomMouseEnterColors = false;
            this.pictureSelectButton.FontSize = 12F;
            this.pictureSelectButton.FontStyle = System.Drawing.FontStyle.Regular;
            this.pictureSelectButton.ForegroundColor = System.Drawing.Color.Empty;
            this.pictureSelectButton.HighlightColor = System.Drawing.Color.Empty;
            this.pictureSelectButton.Location = new System.Drawing.Point(60, 441);
            this.pictureSelectButton.Name = "pictureSelectButton";
            this.pictureSelectButton.Size = new System.Drawing.Size(135, 23);
            this.pictureSelectButton.Style = "Orange";
            this.pictureSelectButton.TabIndex = 11;
            this.pictureSelectButton.TabStop = false;
            this.pictureSelectButton.Text = "select pic";
            this.pictureSelectButton.Click += new System.EventHandler(this.pictureSelectButton_Click);
            // 
            // pictureSelectOpenFileDialog
            // 
            this.pictureSelectOpenFileDialog.Title = "انتخاب عکس";
            // 
            // serialLabel
            // 
            this.serialLabel.BackColor = System.Drawing.Color.Transparent;
            this.serialLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.serialLabel.Location = new System.Drawing.Point(632, 292);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(147, 37);
            this.serialLabel.TabIndex = 12;
            this.serialLabel.Text = "serial";
            this.serialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.serialLabel.UseStyleColors = true;
            // 
            // nationalIDLabel
            // 
            this.nationalIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.nationalIDLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.nationalIDLabel.Location = new System.Drawing.Point(632, 247);
            this.nationalIDLabel.Name = "nationalIDLabel";
            this.nationalIDLabel.Size = new System.Drawing.Size(147, 37);
            this.nationalIDLabel.TabIndex = 13;
            this.nationalIDLabel.Text = "id";
            this.nationalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nationalIDLabel.UseStyleColors = true;
            // 
            // fatherLabel
            // 
            this.fatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.fatherLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.fatherLabel.Location = new System.Drawing.Point(632, 157);
            this.fatherLabel.Name = "fatherLabel";
            this.fatherLabel.Size = new System.Drawing.Size(147, 37);
            this.fatherLabel.TabIndex = 14;
            this.fatherLabel.Text = "dad";
            this.fatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fatherLabel.UseStyleColors = true;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.nameLabel.Location = new System.Drawing.Point(632, 112);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 37);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.UseStyleColors = true;
            // 
            // courseLengthorUnitsLabel
            // 
            this.courseLengthorUnitsLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseLengthorUnitsLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.courseLengthorUnitsLabel.Location = new System.Drawing.Point(632, 427);
            this.courseLengthorUnitsLabel.Name = "courseLengthorUnitsLabel";
            this.courseLengthorUnitsLabel.Size = new System.Drawing.Size(147, 37);
            this.courseLengthorUnitsLabel.TabIndex = 16;
            this.courseLengthorUnitsLabel.Text = "lenght";
            this.courseLengthorUnitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseLengthorUnitsLabel.UseStyleColors = true;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseNameLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.courseNameLabel.Location = new System.Drawing.Point(632, 337);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(147, 37);
            this.courseNameLabel.TabIndex = 17;
            this.courseNameLabel.Text = "c name";
            this.courseNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseNameLabel.UseStyleColors = true;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(632, 203);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(147, 37);
            this.dateOfBirthLabel.TabIndex = 18;
            this.dateOfBirthLabel.Text = "dob";
            this.dateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateOfBirthLabel.UseStyleColors = true;
            // 
            // courseEndorCertDateLabel
            // 
            this.courseEndorCertDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseEndorCertDateLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.courseEndorCertDateLabel.Location = new System.Drawing.Point(632, 382);
            this.courseEndorCertDateLabel.Name = "courseEndorCertDateLabel";
            this.courseEndorCertDateLabel.Size = new System.Drawing.Size(147, 37);
            this.courseEndorCertDateLabel.TabIndex = 19;
            this.courseEndorCertDateLabel.Text = "cert date";
            this.courseEndorCertDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseEndorCertDateLabel.UseStyleColors = true;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoPictureBox.Image = global::CertificateGenerator.Properties.Resources.myLogoBig;
            this.logoPictureBox.Location = new System.Drawing.Point(9, 15);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(30, 30);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 20;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoPictureBox_MouseClick);
            // 
            // certTypeComboBox
            // 
            this.certTypeComboBox.CustomSelectedItem = true;
            this.certTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.certTypeComboBox.Font = new System.Drawing.Font("Vazirmatn", 19F, System.Drawing.FontStyle.Bold);
            this.certTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.certTypeComboBox.ItemHeight = 58;
            this.certTypeComboBox.ItemTextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.certTypeComboBox.Location = new System.Drawing.Point(232, 27);
            this.certTypeComboBox.Name = "certTypeComboBox";
            this.certTypeComboBox.PromptText = "select pls";
            this.certTypeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.certTypeComboBox.SelectedItemBackgroundColor = System.Drawing.Color.Empty;
            this.certTypeComboBox.SelectedItemForegroundColor = System.Drawing.Color.Black;
            this.certTypeComboBox.SelectedItemTextHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.certTypeComboBox.Size = new System.Drawing.Size(308, 64);
            this.certTypeComboBox.Style = "Orange";
            this.certTypeComboBox.StyleCOlor = System.Drawing.Color.Coral;
            this.certTypeComboBox.TabIndex = 0;
            this.certTypeComboBox.TabStop = false;
            this.certTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.certTypeComboBox_SelectedIndexChanged);
            // 
            // certTypeLabel
            // 
            this.certTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.certTypeLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px40;
            this.certTypeLabel.FontWeight = MetroFramework.Drawing.MetroFontWeight.Bold;
            this.certTypeLabel.Location = new System.Drawing.Point(546, 27);
            this.certTypeLabel.Name = "certTypeLabel";
            this.certTypeLabel.Size = new System.Drawing.Size(233, 64);
            this.certTypeLabel.TabIndex = 21;
            this.certTypeLabel.Text = "cert type";
            this.certTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.certTypeLabel.UseStyleColors = true;
            // 
            // avgLabel
            // 
            this.avgLabel.BackColor = System.Drawing.Color.Transparent;
            this.avgLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px16;
            this.avgLabel.Location = new System.Drawing.Point(632, 472);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(147, 37);
            this.avgLabel.TabIndex = 23;
            this.avgLabel.Text = "avg";
            this.avgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.avgLabel.UseStyleColors = true;
            // 
            // avgTextBox
            // 
            this.avgTextBox.BorderColor = System.Drawing.Color.Empty;
            this.avgTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgTextBox.Location = new System.Drawing.Point(232, 472);
            this.avgTextBox.MaxLength = 5;
            this.avgTextBox.Multiline = true;
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.avgTextBox.Size = new System.Drawing.Size(394, 37);
            this.avgTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.avgTextBox.TabIndex = 9;
            this.avgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.avgTextBox.UseStyleColors = true;
            this.avgTextBox.Enter += new System.EventHandler(this.MetroTextBox_Enter);
            this.avgTextBox.Leave += new System.EventHandler(this.MetroTextBox_Leave);
            // 
            // certPreviewPictureBox
            // 
            this.certPreviewPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.certPreviewPictureBox.Location = new System.Drawing.Point(60, 27);
            this.certPreviewPictureBox.Name = "certPreviewPictureBox";
            this.certPreviewPictureBox.Size = new System.Drawing.Size(135, 167);
            this.certPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.certPreviewPictureBox.TabIndex = 24;
            this.certPreviewPictureBox.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.generateButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.generateButton.BackgroundColor = System.Drawing.Color.Empty;
            this.generateButton.CustomMouseEnterColors = false;
            this.generateButton.FontSize = 19F;
            this.generateButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.generateButton.ForegroundColor = System.Drawing.Color.Lime;
            this.generateButton.Highlight = true;
            this.generateButton.HighlightColor = System.Drawing.Color.Lime;
            this.generateButton.Location = new System.Drawing.Point(295, 535);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(225, 43);
            this.generateButton.TabIndex = 25;
            this.generateButton.TabStop = false;
            this.generateButton.Text = "build cert";
            this.generateButton.Click += new System.EventHandler(this.GenerateCertificate);
            // 
            // clearPictureBox
            // 
            this.clearPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.clearPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearPictureBox.Image = global::CertificateGenerator.Properties.Resources.clear;
            this.clearPictureBox.Location = new System.Drawing.Point(731, 550);
            this.clearPictureBox.Name = "clearPictureBox";
            this.clearPictureBox.Size = new System.Drawing.Size(48, 21);
            this.clearPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clearPictureBox.TabIndex = 26;
            this.clearPictureBox.TabStop = false;
            this.clearPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearPictureBox_Click);
            // 
            // linkPictureBox
            // 
            this.linkPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.linkPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.linkPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkPictureBox.Image = global::CertificateGenerator.Properties.Resources.linked;
            this.linkPictureBox.Location = new System.Drawing.Point(208, 269);
            this.linkPictureBox.Name = "linkPictureBox";
            this.linkPictureBox.Size = new System.Drawing.Size(18, 36);
            this.linkPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.linkPictureBox.TabIndex = 27;
            this.linkPictureBox.TabStop = false;
            this.linkPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkPictureBox_MouseClick);
            // 
            // courseEndCertDateMaskedTextBox
            // 
            this.courseEndCertDateMaskedTextBox.AsciiOnly = false;
            this.courseEndCertDateMaskedTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.courseEndCertDateMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.courseEndCertDateMaskedTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseEndCertDateMaskedTextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.courseEndCertDateMaskedTextBox.HidePromptOnLeave = false;
            this.courseEndCertDateMaskedTextBox.Location = new System.Drawing.Point(232, 382);
            this.courseEndCertDateMaskedTextBox.Mask = "0000/00/00";
            this.courseEndCertDateMaskedTextBox.Name = "courseEndCertDateMaskedTextBox";
            this.courseEndCertDateMaskedTextBox.PromptChar = ' ';
            this.courseEndCertDateMaskedTextBox.RejectInputOnFirstFailure = false;
            this.courseEndCertDateMaskedTextBox.ResetOnPrompt = true;
            this.courseEndCertDateMaskedTextBox.ResetOnSpace = true;
            this.courseEndCertDateMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.courseEndCertDateMaskedTextBox.Size = new System.Drawing.Size(394, 37);
            this.courseEndCertDateMaskedTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.courseEndCertDateMaskedTextBox.TabIndex = 7;
            this.courseEndCertDateMaskedTextBox.Text = "    /  /";
            this.courseEndCertDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseEndCertDateMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.courseEndCertDateMaskedTextBox.Enter += new System.EventHandler(this.MetroMaskedTextBox_Enter);
            this.courseEndCertDateMaskedTextBox.Leave += new System.EventHandler(this.MetroMaskedTextBox_Leave);
            // 
            // dateOfBirthMaskedTextBox
            // 
            this.dateOfBirthMaskedTextBox.AsciiOnly = false;
            this.dateOfBirthMaskedTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dateOfBirthMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dateOfBirthMaskedTextBox.Font = new System.Drawing.Font("Vazirmatn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthMaskedTextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateOfBirthMaskedTextBox.HidePromptOnLeave = false;
            this.dateOfBirthMaskedTextBox.Location = new System.Drawing.Point(232, 202);
            this.dateOfBirthMaskedTextBox.Mask = "0000/00/00";
            this.dateOfBirthMaskedTextBox.Name = "dateOfBirthMaskedTextBox";
            this.dateOfBirthMaskedTextBox.PromptChar = ' ';
            this.dateOfBirthMaskedTextBox.RejectInputOnFirstFailure = false;
            this.dateOfBirthMaskedTextBox.ResetOnPrompt = true;
            this.dateOfBirthMaskedTextBox.ResetOnSpace = true;
            this.dateOfBirthMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOfBirthMaskedTextBox.Size = new System.Drawing.Size(394, 37);
            this.dateOfBirthMaskedTextBox.StyleCOlor = System.Drawing.Color.Empty;
            this.dateOfBirthMaskedTextBox.TabIndex = 3;
            this.dateOfBirthMaskedTextBox.Text = "    /  /";
            this.dateOfBirthMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateOfBirthMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.dateOfBirthMaskedTextBox.Enter += new System.EventHandler(this.MetroMaskedTextBox_Enter);
            this.dateOfBirthMaskedTextBox.Leave += new System.EventHandler(this.MetroMaskedTextBox_Leave);
            // 
            // userPictureLabel
            // 
            this.userPictureLabel.BackColor = System.Drawing.Color.Transparent;
            this.userPictureLabel.FontSize = MetroFramework.Drawing.MetroFontSize.Px12;
            this.userPictureLabel.Location = new System.Drawing.Point(60, 240);
            this.userPictureLabel.Name = "userPictureLabel";
            this.userPictureLabel.Size = new System.Drawing.Size(135, 20);
            this.userPictureLabel.TabIndex = 29;
            this.userPictureLabel.Text = "user pic";
            this.userPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userPictureLabel.UseStyleColors = true;
            // 
            // userPictureBorderedPanel
            // 
            this.userPictureBorderedPanel.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBorderedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userPictureBorderedPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userPictureBorderedPanel.Location = new System.Drawing.Point(60, 263);
            this.userPictureBorderedPanel.Name = "userPictureBorderedPanel";
            this.userPictureBorderedPanel.Size = new System.Drawing.Size(135, 176);
            this.userPictureBorderedPanel.TabIndex = 28;
            // 
            // JondiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.userPictureLabel);
            this.Controls.Add(this.userPictureBorderedPanel);
            this.Controls.Add(this.linkPictureBox);
            this.Controls.Add(this.clearPictureBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.certPreviewPictureBox);
            this.Controls.Add(this.avgLabel);
            this.Controls.Add(this.avgTextBox);
            this.Controls.Add(this.certTypeLabel);
            this.Controls.Add(this.certTypeComboBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.courseEndorCertDateLabel);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.courseLengthorUnitsLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fatherLabel);
            this.Controls.Add(this.nationalIDLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.pictureSelectButton);
            this.Controls.Add(this.courseEndCertDateMaskedTextBox);
            this.Controls.Add(this.dateOfBirthMaskedTextBox);
            this.Controls.Add(this.courseLengthOrUnitsTextBox);
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
            this.Style = "Orange";
            this.Text = "گواهی ساز";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certPreviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox serialTextBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroTextBox fatherNameTextBox;
        private MetroFramework.Controls.MetroTextBox nationalIdTextBox;
        private MetroFramework.Controls.MetroTextBox courseNameTextBox;
        private MetroFramework.Controls.MetroTextBox courseLengthOrUnitsTextBox;
        private MetroMaskedTextBox dateOfBirthMaskedTextBox;
        private MetroMaskedTextBox courseEndCertDateMaskedTextBox;
        private MetroFramework.Controls.MetroButton pictureSelectButton;
        private System.Windows.Forms.OpenFileDialog pictureSelectOpenFileDialog;
        private MetroFramework.Controls.MetroLabel serialLabel;
        private MetroFramework.Controls.MetroLabel nationalIDLabel;
        private MetroFramework.Controls.MetroLabel fatherLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel courseLengthorUnitsLabel;
        private MetroFramework.Controls.MetroLabel courseNameLabel;
        private MetroFramework.Controls.MetroLabel dateOfBirthLabel;
        private MetroFramework.Controls.MetroLabel courseEndorCertDateLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private MetroFramework.Controls.MetroComboBox certTypeComboBox;
        private MetroFramework.Controls.MetroLabel certTypeLabel;
        private MetroFramework.Controls.MetroLabel avgLabel;
        private MetroFramework.Controls.MetroTextBox avgTextBox;
        private System.Windows.Forms.PictureBox certPreviewPictureBox;
        private MetroFramework.Controls.MetroButton generateButton;
        private System.Windows.Forms.PictureBox clearPictureBox;
        private System.Windows.Forms.PictureBox linkPictureBox;
        private BorderedPanel userPictureBorderedPanel;
        private MetroLabel userPictureLabel;
    }
}