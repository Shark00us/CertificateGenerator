using CertificateGenerator.Extensions;
using CertificateGenerator.Properties;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateGenerator.Forms
{
    public partial class JondiForm : MetroForm
    {

        public JondiForm()
        {
            InitializeComponent();
            this.ApplyFormIcon();
            logoPictureBox.Image = Resources.myLogoBig;
            userPictureBox.EnableImageDragAndDrop();
        }

        private void pictureSelectButton_Click(object sender, EventArgs e)
        {
            string path = OpenImageFileDialog();
            if (path != null)
            {
                userPictureBox.BackgroundImage = LoadImage(path);
            }
        }

        private string OpenImageFileDialog()
        {
            using OpenFileDialog openFileDialog = pictureSelectOpenFileDialog;
            openFileDialog.Filter = "عکس ها (*.jpg;*.bmp)|*.jpg;*.bmp";
            return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
        }

        private Image LoadImage(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                return null;
            }
        }

        private void VerifyInputs()
        {
            bool stateOfInputs = !string.IsNullOrWhiteSpace(serialTextBox.Text) &&
                                     !string.IsNullOrWhiteSpace(nameTextBox.Text) &&
                                     !string.IsNullOrWhiteSpace(fatherNameTextBox.Text) &&
                                     !string.IsNullOrWhiteSpace(nationalIdTextBox.Text) &&
                                     !string.IsNullOrWhiteSpace(courseNameTextBox.Text) &&
                                     !string.IsNullOrWhiteSpace(courseLengthTextBox.Text) &&
                                     dateOfBirthMaskedTextBox.Text.Length == 10 &&
                                     courseEndMaskedTextBox.Text.Length == 10 &&
                                     !(dateOfBirthMaskedTextBox.Text + courseEndMaskedTextBox.Text).Contains(" ") &&
                                     userPictureBox.BackgroundImage != null;
            GenerateButtonEnableOrDisable(stateOfInputs);
        }

        private void TextBoxTextChanged(object sender, EventArgs e)
        {
            VerifyInputs();
        }

        private async void GenerateCertificate(object sender, EventArgs e)
        {
            string[] convertedTexts = await Task.Run(() => GetInputTexts().ArabicNumberToHindiNumbers());
            JondiShaporCertificate jondiShaporCertificate = new JondiShaporCertificate(userPictureBox.BackgroundImage, convertedTexts[0], convertedTexts[1],
                convertedTexts[2], convertedTexts[3], convertedTexts[4],
                convertedTexts[5], convertedTexts[6], convertedTexts[7]);

            using CertificateViewerForm certificateReviewer = new CertificateViewerForm(jondiShaporCertificate);
            certificateReviewer.ShowDialog();
        }

        private string[] GetInputTexts()
        {
            return new[]
            {
                serialTextBox.Text, nameTextBox.Text,
                fatherNameTextBox.Text, dateOfBirthMaskedTextBox.Text, nationalIdTextBox.Text,
                courseEndMaskedTextBox.Text, courseNameTextBox.Text, courseLengthTextBox.Text
            };
        }



        private void logoPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) Process.Start("https://t.ly/Q4-Dq");
        }

        private void GenerateButtonEnableOrDisable(bool state)
        {
            generateButton.Enabled = generateButton.Visible = state;
        }

        private void userPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            VerifyInputs();
        }
    }
}
