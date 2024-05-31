using CertificateGenerator.Extensions;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CertificateGenerator.Forms
{
    public partial class CertificateSaveBox : MetroForm
    {
        private readonly AppStrings _appStrings;
        private readonly MySettings _mYSettings = new MySettings();
        private string _path;
        public string Path
        {
            get { return _path; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
        }

        public CertificateSaveBox(AppStrings appStrings, string fileName)
        {
            InitializeComponent();
            _appStrings = appStrings;
            _fileName = fileName;
            _path = _mYSettings.SavePath;
            ApplyTexts();
            ApplyStyles();
            DialogResult = DialogResult.Abort;
        }

        private void ApplyTexts()
        {
            savePathTextBox.Text = _path;
            fileNameTextBox.Text = _fileName;
            Text = _appStrings.CertificateSaveBoxTitle;
            fileNameLabel.Text = _appStrings.CertificateSaveBoxFileNameLabelText;
            selectPathButton.Text = _appStrings.CertificateSaveBoxPathSelectButtonText;
            closeButton.Text = _appStrings.CertificateSaveBoxCloseButtonText;
            saveButton.Text = _appStrings.CertificateSaveBoxSaveButtonText;
            pathFolderBrowserDialog.Description = _appStrings.CertificateSaveBoxFolderDialogDescription;
        }

        private void ApplyStyles()
        {
            leftIconPictureBox.Image = rightIconPictureBox.Image = SystemIcons.Question.ToBitmap();
            Icon = SystemIcons.Question;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool validFileName = fileNameTextBox.CheckError() && fileNameTextBox.CheckForIllegalCharacters() &&
            savePathTextBox.CheckAsPath();
            if (!validFileName) return;
            _path = savePathTextBox.Text;
            _fileName = fileNameTextBox.Text;
            MySettings.SaveCertsPath(_path);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void CertificateSaveBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Abort)
            {
                Application.Exit();
            }
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            pathFolderBrowserDialog.ShowDialog(this);
            if (pathFolderBrowserDialog.SelectedPath != null)
            {
                _path = savePathTextBox.Text = pathFolderBrowserDialog.SelectedPath;
            }
        }
    }
}
