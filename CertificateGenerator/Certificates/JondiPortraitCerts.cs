using CertificateGenerator.Properties;
using CertificateGenerator.Strings;
using System.Drawing;

namespace CertificateGenerator.Certificates
{
    internal class PiraPezeshkiJondiCert : PortraitJondiShaporCertificate
    {
        public PiraPezeshkiJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseEnd, string courseName, string courseLength) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseEnd, courseName, courseLength)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiPiraBack;
        }
    }

    internal class NotPezeshkiJondiCert : PortraitJondiShaporCertificate
    {

        public NotPezeshkiJondiCert(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth, string nationalNumber, string courseEnd, string courseName, string courseLength) : base(strings, userImage, serialNumber, nameAndSurname, fatherName, dateOfBirth, nationalNumber, courseEnd, courseName, courseLength)
        {
        }
        protected override Image BackgroundImage()
        {
            return Resources.JondiPezeshkiBack;
        }
    }
}
