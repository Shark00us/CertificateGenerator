using CertificateGenerator.Properties;
using CertificateGenerator.Strings;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Reflection;

namespace CertificateGenerator.Forms
{
    public partial class AboutBox : MetroForm
    {
        private readonly AppStrings _appStrings;


        public AboutBox(AppStrings appStrings)
        {
            InitializeComponent();
            _appStrings = appStrings;
            ApplyTexts();
            ApplyStyles();
        }

        private void ApplyTexts()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            Text = $"{_appStrings.AboutBoxTitle} {version}";
            aboutLabel.Text = _appStrings.AboutBoxAboutLabelText;
            telegramButton.Text = _appStrings.AboutBoxTelegramButtonText;
            emailButton.Text = _appStrings.AboutBoxEmailButtonText;
            okButton.Text = _appStrings.AboutBoxOkButtonText;
        }

        private void ApplyStyles()
        {
            leftIconPictureBox.Image = Resources.myLogoBig;
            Icon = Resources.myLogo;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void telegramButton_Click(object sender, EventArgs e)
        {
            Process.Start(AppStrings.TelegramLink);
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            Process.Start(AppStrings.EmailLink);
        }
    }
}
