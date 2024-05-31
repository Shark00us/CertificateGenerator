namespace CertificateGenerator.Strings;

/// <summary>
/// Parent Class for Strings used in this App.
/// </summary>
public abstract class AppStrings
{
    // Const Strings
    public const string JondiFormOpenFileDialogPicturesFilter = "|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff";

    public const string DonationLink = "https://t.ly/Q4-Dq";

    public const string Email = "Armintalakoub@gmail.com";

    public const string TelegramId = "SHARK_US";

    public const string TelegramLink = $"https://t.me/{TelegramId}";

    public const string EmailLink = $"mailto:{Email}";

    public const string FontsRegistryPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts";

    public const string FontInstallerScriptResourcesPath = $"CertificateGenerator.Resources.Fonts.{FontInstallerScriptFileName}";

    public const string IranNastaliqResourcesPath = $"CertificateGenerator.Resources.Fonts.{IranNastaliqFileName}";

    public const string RegularVazirResourcesPath = $"CertificateGenerator.Resources.Fonts.{RegularVazirFileName}";

    public const string BoldVazirResourcesPath = $"CertificateGenerator.Resources.Fonts.{BoldVazirFileName}";

    public const string LightVazirResourcesPath = $"CertificateGenerator.Resources.Fonts.{LightVazirFileName}";

    public const string FontInstallerScriptFileName = "InstallFont.ps1";

    public const string IranNastaliqFileName = "Iran Nastaliq Bold.ttf";

    public const string RegularVazirFileName = "Vazirmatn Regular.ttf";

    public const string BoldVazirFileName = "Vazirmatn Bold.ttf";

    public const string LightVazirFileName = "Vazirmatn Light.ttf";

    public static readonly string[] RegistryFontsNames = { "IranNastaliq Bold", "Vazirmatn Regular", "Vazirmatn Bold", "Vazirmatn Light" };



    public abstract string PleaseRestartTheApp { get; }
    // Strings for Alerter Boxes
    public abstract string AlertBoxWarningTitle { get; }
    public abstract string AlertBoxErrorTitle { get; }
    public abstract string AlertBoxCloseButtonText { get; }
    public abstract string AlertBoxContinueButtonText { get; }
    public abstract string OptionBoxNoButtonText { get; }
    public abstract string OptionBoxYesButtonText { get; }
    public abstract string FontsOptionsTitle { get; }
    public abstract string FontsOptionsMessage { get; }
    public abstract string CertificateSaveBoxSaveButtonText { get; }
    public abstract string CertificateSaveBoxCloseButtonText { get; }
    public abstract string CertificateSaveBoxTitle { get; }
    public abstract string CertificateSaveBoxPathSelectButtonText { get; }
    public abstract string CertificateSaveBoxFileNameLabelText { get; }
    public abstract string CertificateSaveBoxFolderDialogDescription { get; }

    // Strings for about Box
    public abstract string AboutBoxTitle { get; }
    public abstract string AboutBoxAboutLabelText { get; }
    public abstract string AboutBoxTelegramButtonText { get; }
    public abstract string AboutBoxEmailButtonText { get; }
    public abstract string AboutBoxOkButtonText { get; }

    // Strings for JondiForm
    public abstract string JondiFormText { get; }
    public abstract string JondiFormSerialLabelText { get; }
    public abstract string JondiFormNameLabelText { get; }
    public abstract string JondiFormFatherNameLabelText { get; }
    public abstract string JondiFormBirthDateLabelText { get; }
    public abstract string JondiFormNationalIdLabelText { get; }
    public abstract string JondiFormCourseNameLabelText { get; }
    public abstract string JondiFormCertDateLabelText { get; }
    public abstract string JondiFormCourseDateLabelText { get; }
    public abstract string JondiFormCourseLengthLabelText { get; }
    public abstract string JondiFormUnitsLabelText { get; }
    public abstract string JondiFormAvgLabelText { get; }
    public abstract string JondiFormUserPictureLabelText { get; }
    public abstract string JondiFormSelectPictureButtonText { get; }
    public abstract string JondiFormGenerateButtonText { get; }
    public abstract string JondiFormOpenFileDialogTitle { get; }
    public abstract string JondiFormOpenFileDialogFilterName { get; }
    public abstract string JondiFormCertTypeLabelText { get; }



    // Strings for CertificateViewerForm
    public abstract string CertViewFormText { get; }
    public abstract string CertViewFormSaveButtonText { get; }



    // Strings for Errors/Exceptions
    public abstract string ErrorLicense { get; }
    public abstract string ErrorSetupDataTable { get; }
    public abstract string ErrorExportReport { get; }
    public abstract string ErrorImageLoad { get; }
    public abstract string ErrorRoundImage { get; }
    public abstract string ErrorResizeImage { get; }
    public abstract string ErrorConvertImage { get; }
    public abstract string ErrorConvertNumbers { get; }
    public abstract string ErrorSaveReportAsFile { get; }
    public abstract string ErrorReCompressImage { get; }
    public abstract string ErrorLoadRegRenderReport { get; }
    public abstract string ErrorGettingInput { get; }
    public abstract string ErrorExtractingResources { get; }
    public abstract string ErrorRunningFontsScript { get; }
    public abstract string ErrorCheckingForFonts { get; }
    public abstract string ErrorCreatingCertificate { get; }
    public abstract string ErrorLinkingTextBoxes { get; }
    public abstract string ErrorClearingTextBoxes { get; }
    public abstract string ErrorCastingItemToCertificate { get; }
    public abstract string ErrorChangingFormLayout { get; }
    public abstract string ErrorApplyingTheStyleColors { get; }
    public abstract string ErrorPopulatingComboBox { get; }
    public abstract string ErrorLoadingSettings { get; }
    public abstract string ErrorSavingSetting { get; }

}