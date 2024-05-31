using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using MetroFramework.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CertificateGenerator.Extensions
{
    internal static class OtherExtensions
    {
        private static AppStrings _appStrings;

        public static void InjectDependency(AppStrings strings)
        {
            _appStrings = strings;
        }
        public static string[] ArabicNumberToHindiNumbers(this string[] controlsTexts)
        {
            string[] newStrings = (string[])controlsTexts.Clone();
            try
            {
                for (int i = 0; i < newStrings.Length; i++)
                {
                    newStrings[i] = newStrings[i]
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
            }
            catch (Exception e)
            {
                Alerter.HandleException(e, _appStrings.ErrorConvertNumbers, false);
            }
            return newStrings;
        }

        public static bool CheckError(this MetroTextBox textBox, Color normalColor = default, bool checkSpace = false, int minLength = 0)
        {
            bool confirm = !string.IsNullOrWhiteSpace(textBox.Text);
            if (minLength > 0) confirm = confirm && textBox.Text.Length >= minLength;
            if (checkSpace) confirm = confirm && !textBox.Text.Contains(" ");
            textBox.StyleCOlor = !confirm ? Color.Red : normalColor;
            return confirm;
        }
        public static bool CheckError(this MetroMaskedTextBox textBox, Color normalColor = default, int minLength = 0)
        {
            bool confirm = !textBox.Text.Contains(" ");
            if (minLength > 0) confirm = confirm && textBox.Text.Length >= minLength;
            textBox.BorderColor = !confirm ? Color.Red : normalColor;
            return confirm;
        }
        public static bool CheckError(this BorderedPanel border, Color normalColor = default)
        {
            bool confirm = border.BackgroundImage != null;
            border.BorderColor = !confirm ? Color.Red : normalColor;
            return confirm;
        }

        public static bool CheckAsPath(this MetroTextBox textBox, Color normalColor = default)
        {
            bool confirm = Directory.Exists(textBox.Text ?? string.Empty);
            textBox.BorderColor = !confirm ? Color.Red : normalColor;
            return confirm;
        }

        public static void ApplyFormIcon(this Form form)
        {
            form.Icon = Properties.Resources.myLogo;
        }

        public static bool CheckForIllegalCharacters(this MetroTextBox textBox, Color normalColor = default)
        {
            char[] illegalFileNameChars = Path.GetInvalidFileNameChars();
            string text = textBox.Text;
            bool result = true;
            foreach (char c in text)
            {
                if (illegalFileNameChars.Contains(c)) result = false;
            }
            textBox.BorderColor = !result ? Color.Red : normalColor;
            return result;
        }

        public static void EnableImageDragAndDrop(this Control control)
        {
            control.AllowDrop = true;
            control.DragEnter += Control_DragEnter;
            control.DragDrop += ControlDragDrop;
            control.DragOver += Control_DragOver;
        }

        private static void Control_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Move;
                return;
            }

            e.Effect = DragDropEffects.None;
        }
        private static void ControlDragDrop(object sender, DragEventArgs e)
        {
            if (sender is Control control)
            {
                try
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (files.Length > 0)
                    {
                        control.BackgroundImage = Image.FromFile(files[0]);
                    }
                }
                catch (Exception ex)
                {
                    Alerter.HandleException(ex, _appStrings.ErrorImageLoad, false);
                    control.BackgroundImage = null;
                }
            }
        }
        private static void Control_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

    }
}
