using System;
using System.Data;
using System.Drawing;

namespace CertificateGenerator;

public class JondiShaporCertificate
{
    private readonly Image _userImage;
    private readonly string _serialNumber;
    private readonly string _nameAndSurname;
    private readonly string _fatherName;
    private readonly string _dateOfBirth;
    private readonly string _nationalNumber;
    private readonly string _courseEnd;
    private readonly string _courseName;
    private readonly string _courseLength;

    public DataTable Data { get; }
    public string FileName { get; }

    public JondiShaporCertificate(Image userImage, string serialNumber, string nameAndSurname, string fatherName, string dateOfBirth,
        string nationalNumber, string courseEnd, string courseName, string courseLength)
    {
        FileName = nameAndSurname;
        
        _userImage = userImage.ConvertPngToJpg().ResizeImage(234, 324).RoundCorners(38);
        _serialNumber = serialNumber;
        _nameAndSurname = nameAndSurname;
        _fatherName = fatherName;
        _dateOfBirth = dateOfBirth;
        _nationalNumber = nationalNumber;
        _courseEnd = courseEnd;
        _courseName = courseName;
        _courseLength = courseLength;
        Data = CreateCertificateDataTable();
    }

    private DataTable CreateCertificateDataTable()
    {
        if (this == null)
        {
            throw new ArgumentNullException();
        }

        DataTable table = new DataTable("CertificateData");

        table.Columns.Add("UserImage", typeof(Image));
        table.Columns.Add("SerialNumber", typeof(string));
        table.Columns.Add("NameAndSurname", typeof(string));
        table.Columns.Add("FatherName", typeof(string));
        table.Columns.Add("DateOfBirth", typeof(string));
        table.Columns.Add("NationalNumber", typeof(string));
        table.Columns.Add("CourseEnd", typeof(string));
        table.Columns.Add("CourseName", typeof(string));
        table.Columns.Add("CourseLength", typeof(string));
        table.Columns.Add("BackgroundImage", typeof(Image));

        DataRow row = table.NewRow();
        row["UserImage"] = _userImage;
        row["SerialNumber"] = _serialNumber;
        row["Name"] = _nameAndSurname;
        row["FatherName"] = _fatherName;
        row["DateOfBirth"] = _dateOfBirth;
        row["NationalNumber"] = _nationalNumber;
        row["CourseEnd"] = _courseEnd;
        row["CourseName"] = _courseName;
        row["CourseLength"] = _courseLength;
        row["BackgroundImage"] = Properties.Resources.jondibackground;

        table.Rows.Add(row);
        return table;
    }


}