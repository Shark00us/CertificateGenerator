using CertificateGenerator.Strings;
using MetroFramework.Forms;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


namespace CertificateGenerator.Forms
{
    public partial class MetroOptionBox : MetroForm
    {
        private readonly AppStrings _appStrings;
        private readonly string _title;
        private readonly string _message;


        public MetroOptionBox(AppStrings appStrings, string message, string title)
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
            _appStrings = appStrings;
            _message = message ?? "";
            _title = title ?? "";
            ApplyTexts();
            ApplyStyles();

        }

        private void ApplyTexts()
        {
            messageLabel.Text = _message;
            Text = _title;
            noButton.Text = _appStrings.OptionBoxNoButtonText;
            yesButton.Text = _appStrings.OptionBoxYesButtonText;
        }

        private void ApplyStyles()
        {
            ForeColor = StyleColor = messageLabel.ForeColor = Color.DeepSkyBlue;
            SystemSounds.Asterisk.Play();
            leftIconPictureBox.Image = rightIconPictureBox.Image = SystemIcons.Information.ToBitmap();
            Icon = SystemIcons.Information;
        }

        private void yesButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void noButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void MetroOptionBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Abort)
            {
                Application.Exit();
            }
        }
    }
}
