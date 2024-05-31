
using CertificateGenerator.Strings;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CertificateGenerator.Utility_Side_Classes
{
    public class MySettings
    {
        #region fields
        private static AppStrings _appStrings;

        private bool _installFonts;
        public bool InstallFonts
        {
            get { return _installFonts; }
        }

        private bool _linkedTextBoxes;
        public bool LinkedTextBoxes
        {
            get { return _linkedTextBoxes; }
        }

        private string _nameAndSurname = string.Empty;
        public string NameAndSurname
        {
            get { return _nameAndSurname; }
        }

        private string _fatherName = string.Empty;
        public string FatherName
        {
            get { return _fatherName; }
        }

        private string _dateOfBirth = string.Empty;
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
        }

        private string _nationalID = string.Empty;
        public string NationalID
        {
            get { return _nationalID; }
        }

        private string _serialNo = string.Empty;
        public string SerialNo
        {
            get { return _serialNo; }
        }

        private string _courseName = string.Empty;
        public string CourseName
        {
            get { return _courseName; }
        }

        private string _certDate = string.Empty;
        public string CertDate
        {
            get { return _certDate; }
        }

        private string _courseLength = string.Empty;
        public string CourseLength
        {
            get { return _courseLength; }
        }

        private string _avg = string.Empty;
        public string Avg
        {
            get { return _avg; }
        }

        private string _savePath = string.Empty;
        public string SavePath
        {
            get { return _savePath; }
        }

        private Image _userImage64;
        public Image UserImage
        {
            get { return _userImage64; }
        }
        #endregion

        public MySettings()
        {
            InitializeSetting();
        }

        public static void InjectDependency(AppStrings strings)
        {
            _appStrings = strings;
        }

        private void InitializeSetting()
        {
            try
            {
                _installFonts = Properties.Settings.Default.tryFonts;
                _linkedTextBoxes = Properties.Settings.Default.linkedTextBoxes;
                _nameAndSurname = Properties.Settings.Default.nameAndSurname;
                _fatherName = Properties.Settings.Default.fatherName;
                _dateOfBirth = Properties.Settings.Default.dateOfBirth;
                _nationalID = Properties.Settings.Default.nationalID;
                _serialNo = Properties.Settings.Default.serialNo;
                _courseName = Properties.Settings.Default.courseName;
                _certDate = Properties.Settings.Default.certDate;
                _courseLength = Properties.Settings.Default.courseLength;
                _avg = Properties.Settings.Default.avg;
                _userImage64 = SettingToImage();
                _savePath = Properties.Settings.Default.savePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        private static Image SettingToImage()
        {
            try
            {
                string imageStr = Properties.Settings.Default.userImage64;
                byte[] imageBytes = Convert.FromBase64String(imageStr);
                using MemoryStream ms = new MemoryStream(imageBytes);
                Image image = Image.FromStream(ms);
                return image;
            }
            catch
            {
                return null;
            }
        }

        public static void SaveImage(Image image)
        {
            try
            {
                using MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                Properties.Settings.Default.userImage64 = base64String;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorSavingSetting, false);
            }

        }

        public static void SaveCertsPath(string path)
        {
            try
            {
                Properties.Settings.Default.savePath = path;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorSavingSetting, false);
            }
        }

        public static void SaveFontTry(bool tryFonts)
        {
            try
            {
                Properties.Settings.Default.tryFonts = tryFonts;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\n{ex.StackTrace}");
            }
        }

        public static void SaveLinkedTextBoxes(bool linkedTextBoxes)
        {
            try
            {
                Properties.Settings.Default.linkedTextBoxes = linkedTextBoxes;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorSavingSetting, false);
            }
        }

        public static void SaveJondiInputs(string[] inputs)
        {
            try
            {
                Properties.Settings.Default.serialNo = inputs[0];
                Properties.Settings.Default.nameAndSurname = inputs[1];
                Properties.Settings.Default.fatherName = inputs[2];
                Properties.Settings.Default.dateOfBirth = inputs[3];
                Properties.Settings.Default.nationalID = inputs[4];
                Properties.Settings.Default.courseName = inputs[5];
                Properties.Settings.Default.certDate = inputs[6];
                Properties.Settings.Default.courseLength = inputs[7];
                Properties.Settings.Default.avg = inputs[8];
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Alerter.HandleException(ex, _appStrings.ErrorSavingSetting, false);
            }
        }
    }
}
