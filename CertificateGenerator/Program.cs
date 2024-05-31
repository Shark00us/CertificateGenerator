using CertificateGenerator.Extensions;
using CertificateGenerator.Forms;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using Stimulsoft.Base.Drawing;
using System;
using System.Windows.Forms;


namespace CertificateGenerator
{

    internal static class Program
    {

        private static readonly AppStrings PersianStrings = new PersianStrings();
        private static readonly MySettings MySettings = new();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetupApp();
            JondiForm jondiForm = new JondiForm(PersianStrings, MySettings);
            Application.Run(jondiForm);
        }

        private static void SetupApp()
        {
            InjectStaticDependencies();
            ApplyLicense();
            StiUX.Theme = StiControlTheme.Dark;
            if (!MySettings.InstallFonts) return;
            if (FontInstaller.CheckIfFontsAreInstalled()) return;
            if (!Alerter.YesOrNoOption(PersianStrings.FontsOptionsMessage, PersianStrings.FontsOptionsTitle)) return;
            FontInstaller.InstallFonts();
            MessageBox.Show(PersianStrings.PleaseRestartTheApp, PersianStrings.FontsOptionsTitle, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Environment.Exit(0);
        }

        private static void InjectStaticDependencies()
        {
            OtherExtensions.InjectDependency(PersianStrings);
            ImageExtensions.InjectDependency(PersianStrings);
            IoUtilities.InjectDependency(PersianStrings);
            FontInstaller.InjectDependency(PersianStrings);
            Alerter.InjectDependency(PersianStrings);
            MySettings.InjectDependency(PersianStrings);
        }

        private static void ApplyLicense()
        {
            Stimulsoft.Base.StiLicense.LoadFromEntryAssembly();
            try
            {
                _ = Stimulsoft.Base.StiLicense.Key;
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, PersianStrings.ErrorLicense, false);
            }
        }



    }
}