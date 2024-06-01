using CertificateGenerator.Certificates;
using CertificateGenerator.Extensions;
using CertificateGenerator.Properties;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateGenerator.Forms
{
    public partial class JondiForm
    {
        private readonly AppStrings _appStrings;
        private readonly MySettings _mySettings;
        private JondiComboBoxItem _selectedItem;
        private bool _linkedTextBox;
        private bool _validData;
        //
        private readonly JondiComboBoxItem[] _certsList =
        {
            new ("کوتاه مدت پیرا پزشکی",JondiCertificateEnum.PiraPezeshki,JondiUiType.PortraitJondiUi,ColorTranslator.FromHtml("#CDCD7F"),Resources.JondiPiraBack),
            new ("کوتاه مدت ساعتی",JondiCertificateEnum.NotPezeshki,JondiUiType.PortraitJondiUi,ColorTranslator.FromHtml("#F7F9FB"),Resources.JondiPezeshkiBack),
            new ("همسطح دیپلم",JondiCertificateEnum.Diplom,JondiUiType.LandscapeJondiUi,ColorTranslator.FromHtml("#F5FBFC"),Resources.JondiDiplomBack),
            new ("همسطح کاردانی",JondiCertificateEnum.Kardani,JondiUiType.LandscapeJondiUi,ColorTranslator.FromHtml("#FEFDCE"),Resources.JondiKardaniBack),
            new ("همسطح کارشناسی",JondiCertificateEnum.Karshenasi,JondiUiType.LandscapeJondiUi,ColorTranslator.FromHtml("#CCFB99"),Resources.JondiKarshenasiBack),
            new ("همسطح کارشناسی ارشد",JondiCertificateEnum.Arshad,JondiUiType.LandscapeJondiUi,ColorTranslator.FromHtml("#FDCA98"),Resources.JondiArshadBack),
            new ("همسطح دکتری",JondiCertificateEnum.Doctora,JondiUiType.LandscapeJondiUi,ColorTranslator.FromHtml("#D0F4F4"),Resources.JondiDoctorBack),
        };


        public JondiForm(AppStrings appStrings, MySettings mySettings)
        {
            _appStrings = appStrings;
            _mySettings = mySettings;
            InitializeComponent();
            this.ApplyFormIcon();
            PopulateComboBox();
            SetStaticControlsText();
            SetInputsFromSettings();
            GetLinkedTextBoxes();
            logoPictureBox.Image = Resources.myLogoBig;
            userPictureBorderedPanel.EnableImageDragAndDrop();
            nationalIdTextBox.TextChanged += LinkedTextBoxTextChanged;
        }

        private void PopulateComboBox()
        {
            try
            {
                certTypeComboBox.DataSource = _certsList;
                certTypeComboBox.ValueMember = "Type";
                certTypeComboBox.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorPopulatingComboBox, true);
            }


        }

        private void SetInputsFromSettings()
        {
            serialTextBox.Text = _mySettings.SerialNo;
            nameTextBox.Text = _mySettings.NameAndSurname;
            fatherNameTextBox.Text = _mySettings.FatherName;
            dateOfBirthMaskedTextBox.Text = _mySettings.DateOfBirth;
            nationalIdTextBox.Text = _mySettings.NationalID;
            courseNameTextBox.Text = _mySettings.CourseName;
            courseEndCertDateMaskedTextBox.Text = _mySettings.CertDate;
            courseLengthOrUnitsTextBox.Text = _mySettings.CourseLength;
            avgTextBox.Text = _mySettings.Avg;
            userPictureBorderedPanel.BackgroundImage = _mySettings.UserImage;

        }

        private void GetLinkedTextBoxes()
        {
            _linkedTextBox = !_mySettings.LinkedTextBoxes;
            LinkUnlinkTextBoxes();
        }

        private string? OpenImageFileDialog()
        {
            using OpenFileDialog openFileDialog = pictureSelectOpenFileDialog;
            openFileDialog.Filter =
                $@"{AppStrings.JondiFormOpenFileDialogPicturesFilter}{_appStrings.JondiFormOpenFileDialogFilterName}";
            return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : null;
        }

        private Image LoadImageFromFile(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorImageLoad, false);
                return null;
            }
        }

        private string[] GetInputTexts()
        {
            try
            {
                return new[]
                {
                    serialTextBox.Text, nameTextBox.Text,fatherNameTextBox.Text,
                    dateOfBirthMaskedTextBox.Text, nationalIdTextBox.Text,courseNameTextBox.Text,
                    courseEndCertDateMaskedTextBox.Text,courseLengthOrUnitsTextBox.Text,avgTextBox.Text
                };

            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorGettingInput, true);
                return new string[] { };
            }
        }

        private void VerifyInputs()
        {
            bool serialConfirmation = serialTextBox.CheckError(_selectedItem.Color);
            bool nameConfirmation = nameTextBox.CheckError(_selectedItem.Color);
            bool fatherNameConfirmation = fatherNameTextBox.CheckError(_selectedItem.Color);
            bool nationalIdConfirmation = nationalIdTextBox.CheckError(_selectedItem.Color, true, 10);
            bool courseNameConfirmation = courseNameTextBox.CheckError(_selectedItem.Color);
            bool courseLengthOrUnitsConfirmation = courseLengthOrUnitsTextBox.CheckError(_selectedItem.Color, true);
            bool birthDateConfirmation = dateOfBirthMaskedTextBox.CheckError(_selectedItem.Color, 10);
            bool courseEndCertDateConfirmation = courseEndCertDateMaskedTextBox.CheckError(_selectedItem.Color, 10);
            bool userImageConfirmation = userPictureBorderedPanel.CheckError(_selectedItem.Color);
            bool finalConfirm = serialConfirmation && nameConfirmation && courseLengthOrUnitsConfirmation && courseNameConfirmation && courseEndCertDateConfirmation && fatherNameConfirmation && nationalIdConfirmation && birthDateConfirmation && userImageConfirmation;
            if (_selectedItem.UiType == JondiUiType.LandscapeJondiUi)
            {
                bool avgConfirm = avgTextBox.CheckError(_selectedItem.Color, true);
                finalConfirm = finalConfirm && avgConfirm;
            }

            _validData = finalConfirm;
        }


        private void LoadPreview()
        {
            if (_selectedItem.PreviewImage == null) return;
            Image img = _selectedItem.PreviewImage;
            certPreviewPictureBox.Image = _selectedItem.PreviewImage.ResizeImage(img.Width / 20, img.Height / 20);
        }



        private async void GenerateCertificate(object sender, EventArgs e)
        {
            VerifyInputs();
            if (!_validData) return;
            generateButton.Enabled = false;
            string[] inputs = GetInputTexts();
            Certificate cert = await CreateTheCertificate(inputs);
            using CertificateViewerForm certificateReviewer = new CertificateViewerForm(_appStrings, new ImageCompressor(_appStrings), cert, _selectedItem.Color);
            MySettings.SaveJondiInputs(inputs);
            MySettings.SaveImage(userPictureBorderedPanel.BackgroundImage);
            MySettings.SaveLinkedTextBoxes(_linkedTextBox);
            certificateReviewer.ShowDialog();
            generateButton.Enabled = true;
        }

        private async Task<Certificate> CreateTheCertificate(string[] inputs)
        {
            try
            {
                string[] convertedTexts = await Task.Run(inputs.ArabicNumberToHindiNumbers);
                Image userPicture = userPictureBorderedPanel.BackgroundImage;
                switch (_selectedItem.Type)
                {
                    case JondiCertificateEnum.PiraPezeshki:
                        return new PiraPezeshkiJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7]);
                    case JondiCertificateEnum.NotPezeshki:
                        return new NotPezeshkiJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7]);
                    case JondiCertificateEnum.Diplom:
                        return new DiplomJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7], convertedTexts[8]);
                    case JondiCertificateEnum.Kardani:
                        return new KardaniJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7], convertedTexts[8]);
                    case JondiCertificateEnum.Karshenasi:
                        return new KarshenasiJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7], convertedTexts[8]);
                    case JondiCertificateEnum.Arshad:
                        return new ArshadJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7], convertedTexts[8]);
                    case JondiCertificateEnum.Doctora:
                        return new DoctorJondiCert(_appStrings,
                            userPictureBorderedPanel.BackgroundImage, convertedTexts[0], convertedTexts[1],
                            convertedTexts[2], convertedTexts[3], convertedTexts[4],
                            convertedTexts[5], convertedTexts[6], convertedTexts[7], convertedTexts[8]);
                    default: throw new Exception("Type of certificate could not be decided on");
                }

            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorCreatingCertificate, true);
                return null;
            }
        }

        private void pictureSelectButton_Click(object sender, EventArgs e)
        {
            string? path = OpenImageFileDialog();
            if (path != null)
            {
                userPictureBorderedPanel.BackgroundImage = LoadImageFromFile(path);
            }
        }


        private void logoPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                AboutBox about = new AboutBox(_appStrings);
                about.ShowDialog();
                Process.Start(AppStrings.DonationLink);
            }

        }



        private void certTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (certTypeComboBox.SelectedIndex > -1)
            {
                try
                {
                    JondiComboBoxItem selectedItem = (JondiComboBoxItem)certTypeComboBox.SelectedItem;
                    _selectedItem = selectedItem;
                }
                catch (Exception ex)
                {
                    Alerter.HandleException(ex, _appStrings.ErrorCastingItemToCertificate, true);
                }
                ApplyColors();
                LoadPreview();
                ChangeControlLayouts();
            }
        }

        private void clearPictureBox_Click(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    serialTextBox.Clear();
                    nameTextBox.Clear();
                    fatherNameTextBox.Clear();
                    dateOfBirthMaskedTextBox.Clear();
                    nationalIdTextBox.Clear();
                    avgTextBox.Clear();
                    nameTextBox.Focus();
                    userPictureBorderedPanel.BackgroundImage = null;
                }
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorClearingTextBoxes, false);
            }

        }

        private void linkPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LinkUnlinkTextBoxes();
            }

        }
        private void LinkedTextBoxTextChanged(object sender, EventArgs e)
        {
            if (_linkedTextBox)
            {
                serialTextBox.Text = nationalIdTextBox.Text;
            }
        }

        private void LinkUnlinkTextBoxes()
        {
            try
            {

                if (_linkedTextBox)
                {

                    linkPictureBox.Image = Resources.unlinked;
                    serialTextBox.ReadOnly = false;
                    serialTextBox.TabStop = true;
                    _linkedTextBox = false;
                    return;
                }
                linkPictureBox.Image = Resources.linked;
                serialTextBox.ReadOnly = true;
                serialTextBox.TabStop = false;
                serialTextBox.Text = nationalIdTextBox.Text;
                _linkedTextBox = true;
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorLinkingTextBoxes, false);
            }
        }
    }

    internal enum JondiCertificateEnum
    {
        PiraPezeshki,
        NotPezeshki,
        Diplom,
        Kardani,
        Karshenasi,
        Arshad,
        Doctora
    }

    internal enum JondiUiType
    {
        LandscapeJondiUi,
        PortraitJondiUi,
    }


    internal class JondiComboBoxItem
    {
        public string Name { get; }
        public JondiCertificateEnum Type { get; }
        public Color Color { get; }
        public JondiUiType UiType { get; }
        public Image PreviewImage { get; }


        public JondiComboBoxItem(string name, JondiCertificateEnum type, JondiUiType uiType, Color color, Image previewImage)
        {
            Name = name ?? "";
            Type = type;
            UiType = uiType;
            Color = color;
            PreviewImage = previewImage ?? new Bitmap(1, 1);
        }
    }
}