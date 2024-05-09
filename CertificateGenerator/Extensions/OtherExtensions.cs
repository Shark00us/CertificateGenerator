using System.Drawing;
using System.Windows.Forms;

namespace CertificateGenerator.Extensions
{
    internal static class OtherExtensions
    {

        public static string[] ArabicNumberToHindiNumbers(this string[] controlsTexts)
        {
            for (int i = 0; i < controlsTexts.Length; i++)
            {
                controlsTexts[i] = controlsTexts[i]
                    .Replace('0', '۰')
                    .Replace('1', '۱')
                    .Replace('2', '۲')
                    .Replace('3', '۳')
                    .Replace('4', '۴')
                    .Replace('5', '۵')
                    .Replace('6', '۶')
                    .Replace('7', '۷')
                    .Replace('8', '۸')
                    .Replace('9', '۹');
            }

            return controlsTexts;
        }

        public static void ApplyFormIcon(this Form form)
        {
            form.Icon = Properties.Resources.myLogo;
        }

        public static void EnableImageDragAndDrop(this PictureBox pictureBox)
        {
            pictureBox.AllowDrop = true;
            pictureBox.DragEnter += PictureBox_DragEnter;
            pictureBox.DragDrop += PictureBox_DragDrop;
            pictureBox.DragOver += PictureBox_DragOver;
        }

        private static void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                return;
            }

            e.Effect = DragDropEffects.None;
        }
        private static void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (sender is PictureBox pictureBox)
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files.Length > 0)
                    {
                        pictureBox.Image = Image.FromFile(files[0]);
                    }
                }
            }
            catch
            {
                if (sender is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                }
            }
        }
        private static void PictureBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

    }
}
