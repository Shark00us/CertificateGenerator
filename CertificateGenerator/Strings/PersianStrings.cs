namespace CertificateGenerator.Strings;

public class PersianStrings : AppStrings
{
    public override string PleaseRestartTheApp => ".لطفا برنامه را دوباره اجرا کنید";
    public override string AlertBoxWarningTitle => "اخطار";
    public override string AlertBoxErrorTitle => "خطای کلی";
    public override string AlertBoxCloseButtonText => "بستن برنامه";
    public override string AlertBoxContinueButtonText => "ادامه";
    public override string OptionBoxNoButtonText => "خیر";
    public override string OptionBoxYesButtonText => "بله";
    public override string FontsOptionsTitle => "نصب فونت های مورد نیاز";

    public override string FontsOptionsMessage =>
        " فونت های مورد نیاز برنامه بر روی سیستم شما نصب نمی باشند \n آیا تمایل دارید این فونت ها نصب شوند؟";

    public override string CertificateSaveBoxSaveButtonText => "ذخیره";
    public override string CertificateSaveBoxCloseButtonText => "انصراف";
    public override string CertificateSaveBoxTitle => "ذخیره گواهی";
    public override string CertificateSaveBoxPathSelectButtonText => "انتخاب مسیر";
    public override string CertificateSaveBoxFileNameLabelText => "نام فایل گواهی";
    public override string CertificateSaveBoxFolderDialogDescription => "انتخاب مسیر ذخیره گواهی";
    public override string AboutBoxTitle => "Certificate Generator";
    public override string AboutBoxAboutLabelText => "Made by Armin Talakoub \nCommissioned by BeHi236";
    public override string AboutBoxTelegramButtonText => $"Telegram : @{TelegramId}";
    public override string AboutBoxEmailButtonText => $"Email : {Email}";
    public override string AboutBoxOkButtonText => "Ok";
    public override string JondiFormText => "گواهی ساز";
    public override string JondiFormSerialLabelText => ": شماره سریال";
    public override string JondiFormNameLabelText => ": نام و نام خانوادگی";
    public override string JondiFormFatherNameLabelText => ": نام پدر";
    public override string JondiFormBirthDateLabelText => ": تاریخ تولد";
    public override string JondiFormNationalIdLabelText => ": کد ملی";
    public override string JondiFormCourseNameLabelText => ": نام دوره";
    public override string JondiFormCertDateLabelText => ": تاریخ صدور";
    public override string JondiFormCourseDateLabelText => ": تاریخ پایان دوره";
    public override string JondiFormCourseLengthLabelText => ": مدت دوره";
    public override string JondiFormUnitsLabelText => ": تعداد واحد";
    public override string JondiFormAvgLabelText => ": معدل";
    public override string JondiFormUserPictureLabelText => ": عکس پرسنلی";
    public override string JondiFormSelectPictureButtonText => "انتخاب عکس پرسنلی";
    public override string JondiFormGenerateButtonText => "ساخت گواهی";
    public override string JondiFormOpenFileDialogTitle => "لطفاً عکس پرسنلی را انتخاب کنید";
    public override string JondiFormOpenFileDialogFilterName => "عکس ها";
    public override string JondiFormCertTypeLabelText => ": نوع گواهی";
    public override string CertViewFormText => "پیش نمایش گواهی";
    public override string CertViewFormSaveButtonText => "ذخیره گواهی";
    public override string ErrorLicense => "Lincene is invalid.";
    public override string ErrorSetupDataTable => "Error setting up Datatable.";
    public override string ErrorExportReport => "Error exporting report.";
    public override string ErrorImageLoad => "Error loading image.";
    public override string ErrorRoundImage => "Error rounding image corners.";
    public override string ErrorResizeImage => "Error resizing image.";
    public override string ErrorConvertImage => "Error converting image.";
    public override string ErrorConvertNumbers => "Error converting numbers.";
    public override string ErrorSaveReportAsFile => "Error saving report as file.";
    public override string ErrorReCompressImage => "Error compressing image.";
    public override string ErrorLoadRegRenderReport => "Error loading/registering/rendering report.";
    public override string ErrorGettingInput => "Error getting inputs.";
    public override string ErrorExtractingResources => "Error extracting resources.";
    public override string ErrorRunningFontsScript => "Error running the fonts script.";
    public override string ErrorCheckingForFonts => "Error checking for fonts.";
    public override string ErrorCreatingCertificate => "Error creating certificate.";
    public override string ErrorLinkingTextBoxes => "Error linking textboxes.";
    public override string ErrorClearingTextBoxes => "Error clearing textboxes.";
    public override string ErrorCastingItemToCertificate => "Error casting item to certificate.";
    public override string ErrorChangingFormLayout => "Error changing form layout.";
    public override string ErrorApplyingTheStyleColors => "Error applying style colors.";
    public override string ErrorPopulatingComboBox => "Error populating combobox.";
    public override string ErrorLoadingSettings => "Error loading settings.";
    public override string ErrorSavingSetting => "Error saving settings.";
}