using CertificateGenerator.Properties;
using CertificateGenerator.Strings;
using System.Drawing;

namespace CertificateGenerator.Certificates
{
    internal class ArshadJondiCert : LandscapeJondiShaporCertificate
    {
        public ArshadJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseName, string certDate, string units, string avg) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseName, certDate, units, avg)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiArshadBack;
        }

    }

    internal class KarshenasiJondiCert : LandscapeJondiShaporCertificate
    {
        public KarshenasiJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseName, string certDate, string units, string avg) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseName, certDate, units, avg)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiKarshenasiBack;
        }
    }

    internal class DiplomJondiCert : LandscapeJondiShaporCertificate
    {
        public DiplomJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseName, string certDate, string units, string avg) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseName, certDate, units, avg)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiDiplomBack;
        }
    }

    internal class DoctorJondiCert : LandscapeJondiShaporCertificate
    {
        public DoctorJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseName, string certDate, string units, string avg) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseName, certDate, units, avg)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiDoctorBack;
        }
    }

    internal class KardaniJondiCert : LandscapeJondiShaporCertificate
    {
        public KardaniJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseName, string certDate, string units, string avg) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseName, certDate, units, avg)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiKardaniBack;
        }
    }
}
