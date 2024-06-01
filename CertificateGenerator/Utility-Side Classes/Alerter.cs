using CertificateGenerator.Forms;
using CertificateGenerator.Strings;
using Stimulsoft.Report;
using System;
using System.Windows.Forms;

namespace CertificateGenerator.Utility_Side_Classes
{
    internal static class Alerter
    {
        private static AppStrings _appStrings;

        public static void InjectDependency(AppStrings strings)
        {
            _appStrings = strings;
        }

        public static void HandleException(Exception exc, string message, bool fatal)
        {
            string excMessage = exc.Message;
            string stackTrace = exc.StackTrace;
            AlertType alertType = AlertType.Warning;
            if (fatal)
            {
                alertType = AlertType.Error;
            }
            MetroAlertBox metroAlertBox = new MetroAlertBox(_appStrings, alertType, message, excMessage, stackTrace);
            metroAlertBox.ShowDialog();
        }

        public static bool YesOrNoOption(string message, string title)
        {

            using MetroOptionBox options = new MetroOptionBox(_appStrings, message, title);
            options.ShowDialog();
            bool result = options.DialogResult == DialogResult.Yes;
            return result;
        }
        public static bool? SelectSavePath(StiReport report, string originalName, out string fileName, out string path, out bool showResults)
        {
            using CertificateSaveBox options = new CertificateSaveBox(_appStrings, originalName);
            options.ShowDialog();
            bool result = options.DialogResult == DialogResult.OK;
            if (result == true)
            {
                fileName = options.FileName;
                path = options.Path;
                showResults = options.ShowResults;
                return result;
            }
            fileName = null;
            path = null;
            showResults = false;
            return null;
        }
    }
}
