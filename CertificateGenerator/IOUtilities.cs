using System.IO;
using System.Windows.Forms;

namespace CertificateGenerator
{
    internal static class IOUtilities
    {
        private static string CertificatesPath => Path.Combine(Application.StartupPath, "Certificates");
        
        private static string CreateReportPath(string reportName)
        {
            return Path.Combine(CertificatesPath, $"{reportName}.bmp");
        }
        private static void CreateFolder(string path)
        {
            Directory.CreateDirectory(path);
        }
        public static void ShowResults(string reportName)
        {
            string reportFilePath = CreateReportPath(reportName);
            System.Diagnostics.Process.Start(CertificatesPath);
            System.Diagnostics.Process.Start(reportFilePath);
        }
        public static void SaveReportAsFile(string reportName, MemoryStream reportData)
        {
            CreateFolder(CertificatesPath);
            string savePath = CreateReportPath(reportName);
            File.WriteAllBytes(savePath, reportData.ToArray());
        }
    }
}
