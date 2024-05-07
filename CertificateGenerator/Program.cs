using System;
using System.Windows.Forms;
using CertificateGenerator.Forms;

namespace CertificateGenerator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JondiForm());
        }
    }
}