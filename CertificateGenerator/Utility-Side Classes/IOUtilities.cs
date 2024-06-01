using CertificateGenerator.Strings;
using System;
using System.Diagnostics;
using System.IO;

namespace CertificateGenerator.Utility_Side_Classes
{
    internal static class IoUtilities
    {
        private static AppStrings _appStrings;

        public static void InjectDependency(AppStrings strings)
        {
            _appStrings = strings;
        }

        private static string GetUniqueFilePath(string path, string fileName)
        {
            string fullPath = CreateImagePath(path, fileName);
            string extension = Path.GetExtension(fullPath);
            if (!File.Exists(fullPath))
            {
                return fullPath;
            }
            int counter = 1;
            string newPath;
            do
            {
                newPath = Path.Combine(path, $"{fileName}({counter}){extension}");
                counter++;
            } while (File.Exists(newPath));

            return newPath;
        }

        private static string CreateImagePath(string path, string fileName)
        {
            return Path.Combine(path, $"{fileName}.jpg");
        }
        private static void ShowReportResults(string fullPath)
        {
            //string directoryPath = Path.GetDirectoryName(fullPath);
            //Process.Start(directoryPath);
            Process.Start(fullPath);
        }
        public static void SaveAndShowReportAsFile(string path, string fileName, MemoryStream reportData, bool showResults)
        {
            try
            {
                string uniquePath = GetUniqueFilePath(path, fileName);
                File.WriteAllBytes(uniquePath, reportData.ToArray());
                if (!showResults) return;
                ShowReportResults(uniquePath);
            }
            catch (Exception e)
            {
                Alerter.HandleException(e, _appStrings.ErrorSaveReportAsFile, true);
            }
        }

    }
}
