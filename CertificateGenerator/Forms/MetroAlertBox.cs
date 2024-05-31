using CertificateGenerator.Strings;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Media;

namespace CertificateGenerator.Forms
{
    public enum AlertType
    {
        Warning,
        Error
    }
    public partial class MetroAlertBox : MetroForm
    {
        private readonly AppStrings _appStrings;
        private readonly AlertType _type;
        private readonly string _message;
        private readonly string _exceptionMessage;
        private readonly string _stackTrace;

        public MetroAlertBox(AppStrings appStrings, AlertType type, string message, string exceptionMessage, string stackTrace)
        {
            InitializeComponent();
            _appStrings = appStrings;
            _message = message ?? "";
            _exceptionMessage = exceptionMessage ?? "";
            _stackTrace = stackTrace ?? "";
            _type = type;
            ApplyTexts();
            ApplyType();
        }

        private void ApplyTexts()
        {
            messageTextBox.Text = _message;
            exceptionMessageTextBox.Text = _exceptionMessage;
            stackTraceTextBox.Text = _stackTrace;
        }

        private void ApplyType()
        {
            if (_type == AlertType.Warning)
            {
                exceptionMessageTextBox.StyleCOlor = messageTextBox.StyleCOlor = stackTraceTextBox.StyleCOlor = ForeColor = StyleColor = okButton.HighlightColor = okButton.ForegroundColor = messageTextBox.ForeColor = Color.Gold;
                Text = _appStrings.AlertBoxWarningTitle;
                okButton.Text = _appStrings.AlertBoxContinueButtonText;
                okButton.Click += ((sender, args) => Close());
                SystemSounds.Exclamation.Play();
                leftIconPictureBox.Image = rightIconPictureBox.Image = SystemIcons.Warning.ToBitmap();
                Icon = SystemIcons.Warning;
            }
            else
            {
                exceptionMessageTextBox.StyleCOlor = messageTextBox.StyleCOlor = stackTraceTextBox.StyleCOlor = ForeColor = StyleColor = okButton.HighlightColor = okButton.ForegroundColor = messageTextBox.ForeColor = Color.Red;
                Text = _appStrings.AlertBoxErrorTitle;
                okButton.Text = _appStrings.AlertBoxCloseButtonText;
                okButton.Click += ((sender, args) => Environment.Exit(0));
                SystemSounds.Hand.Play();
                leftIconPictureBox.Image = rightIconPictureBox.Image = SystemIcons.Error.ToBitmap();
                Icon = SystemIcons.Error;
            }
        }
    }
}
