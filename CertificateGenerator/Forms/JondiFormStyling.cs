using CertificateGenerator.Utility_Side_Classes;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Drawing;

namespace CertificateGenerator.Forms
{
    public partial class JondiForm : MetroForm
    {


        private void ApplyColors()
        {
            try
            {
                Color selectedColor = _selectedItem.Color;
                StyleColor = certTypeLabel.ForeColor = nameLabel.ForeColor =
                    fatherLabel.ForeColor = dateOfBirthLabel.ForeColor = nationalIDLabel.ForeColor =
                        serialLabel.ForeColor = courseNameLabel.ForeColor = courseEndorCertDateLabel.ForeColor =
                            courseLengthorUnitsLabel.ForeColor = avgLabel.ForeColor =
                                //
                                nameTextBox.StyleCOlor = nameTextBox.ForeColor =
                                    fatherNameTextBox.StyleCOlor = fatherNameTextBox.ForeColor =
                                        dateOfBirthMaskedTextBox.ForeColor = dateOfBirthMaskedTextBox.BorderColor =
                                            nationalIdTextBox.StyleCOlor = nationalIdTextBox.ForeColor =
                                                serialTextBox.StyleCOlor = serialTextBox.ForeColor =
                                                    courseNameTextBox.StyleCOlor = courseNameTextBox.ForeColor =
                                                        courseEndCertDateMaskedTextBox.ForeColor = courseEndCertDateMaskedTextBox.BorderColor =
                                                            courseLengthOrUnitsTextBox.StyleCOlor = courseLengthOrUnitsTextBox.ForeColor =
                                                                avgTextBox.StyleCOlor = avgTextBox.ForeColor =
                                                                    //
                                                                    certTypeComboBox.StyleCOlor = certTypeComboBox.SelectedItemBackgroundColor =
                                                                        pictureSelectButton.ForegroundColor =
                                                                            //
                                                                            userPictureLabel.ForeColor = userPictureBorderedPanel.BorderColor =
                                                                            selectedColor;
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorApplyingTheStyleColors, false);
            }


        }

        private void SetStaticControlsText()
        {
            Text = _appStrings.JondiFormText ?? string.Empty;
            certTypeLabel.Text = _appStrings.JondiFormCertTypeLabelText ?? string.Empty;
            serialLabel.Text = _appStrings.JondiFormSerialLabelText ?? string.Empty;
            nameLabel.Text = _appStrings.JondiFormNameLabelText ?? string.Empty;
            fatherLabel.Text = _appStrings.JondiFormFatherNameLabelText ?? string.Empty;
            dateOfBirthLabel.Text = _appStrings.JondiFormBirthDateLabelText ?? string.Empty;
            nationalIDLabel.Text = _appStrings.JondiFormNationalIdLabelText ?? string.Empty;
            courseNameLabel.Text = _appStrings.JondiFormCourseNameLabelText ?? string.Empty;
            avgLabel.Text = _appStrings.JondiFormAvgLabelText ?? string.Empty;
            userPictureLabel.Text = _appStrings.JondiFormUserPictureLabelText ?? string.Empty;
            pictureSelectButton.Text = _appStrings.JondiFormSelectPictureButtonText ?? string.Empty;
            generateButton.Text = _appStrings.JondiFormGenerateButtonText ?? string.Empty;
            pictureSelectOpenFileDialog.Title = _appStrings.JondiFormOpenFileDialogTitle ?? string.Empty;
        }

        private void ChangeControlLayouts()
        {
            try
            {
                const int generatePortraitButtonY = 490;
                const int generateLandscapeButtonY = 535;
                const int generateButtonAndClearButtonYDifference = 15;
                const int portraitHeight = 550;
                const int landscapeHeight = 600;
                if (_selectedItem.UiType == JondiUiType.PortraitJondiUi)
                {
                    courseEndorCertDateLabel.Text = _appStrings.JondiFormCourseDateLabelText;
                    courseLengthorUnitsLabel.Text = _appStrings.JondiFormCourseLengthLabelText;

                    generateButton.Location = generateButton.Location with { Y = generatePortraitButtonY };
                    clearPictureBox.Location = clearPictureBox.Location with { Y = generatePortraitButtonY + generateButtonAndClearButtonYDifference };
                    avgTextBox.Visible = avgLabel.Visible = false;
                    Height = portraitHeight;
                }
                else
                {
                    courseEndorCertDateLabel.Text = _appStrings.JondiFormCertDateLabelText;
                    courseLengthorUnitsLabel.Text = _appStrings.JondiFormUnitsLabelText;
                    generateButton.Location = generateButton.Location with { Y = generateLandscapeButtonY };
                    clearPictureBox.Location = clearPictureBox.Location with { Y = generateLandscapeButtonY + generateButtonAndClearButtonYDifference };
                    avgTextBox.Visible = avgLabel.Visible = true;
                    Height = landscapeHeight;
                }
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorChangingFormLayout, true);
            }
        }

        private void MetroTextBox_Enter(object sender, EventArgs e)
        {
            MetroTextBox textBox = (MetroTextBox)sender;
            if (textBox.ReadOnly) return;
            textBox.BackColor = Color.DarkSlateGray;
        }

        private void MetroTextBox_Leave(object sender, EventArgs e)
        {
            MetroTextBox textBox = (MetroTextBox)sender;
            textBox.BackColor = default;
        }

        private void MetroMaskedTextBox_Enter(object sender, EventArgs e)
        {
            MetroMaskedTextBox textBox = (MetroMaskedTextBox)sender;
            if (textBox.ReadOnly) return;
            textBox.BackColor = Color.DarkSlateGray;
        }

        private void MetroMaskedTextBox_Leave(object sender, EventArgs e)
        {
            MetroMaskedTextBox textBox = (MetroMaskedTextBox)sender;
            textBox.BackColor = default;
        }
    }
}
