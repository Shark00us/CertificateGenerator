using CertificateGenerator.Extensions;
using CertificateGenerator.Properties;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using Stimulsoft.Report;
using System;
using System.Data;
using System.Drawing;

namespace CertificateGenerator.Certificates;

public abstract class Certificate
{
    public abstract DataTable Data { get; }
    public abstract string ExportFileName { get; }
    public abstract string DataTableName { get; }
    //
    public abstract StiReport Report();
}

public abstract class PortraitJondiShaporCertificate : Certificate
{
    private readonly AppStrings _appStrings;
    //
    private readonly Image _userImage;
    private readonly string _serialNumber;
    private readonly string _nameAndSurname;
    private readonly string _fatherName;
    private readonly string _dateOfBirth;
    private readonly string _nationalNumber;
    private readonly string _courseEnd;
    private readonly string _courseName;
    private readonly string _courseLength;
    protected abstract Image BackgroundImage();
    //
    private readonly DataColumn[] _columns = {
        new ("UserImage", typeof(Image)),
        new ("SerialNumber", typeof(string)),
        new ("Name", typeof(string)),
        new ("FatherName", typeof(string)),
        new ("DateOfBirth", typeof(string)),
        new ("NationalNumber", typeof(string)),
        new ("CourseEnd", typeof(string)),
        new ("CourseName", typeof(string)),
        new ("CourseLength", typeof(string)),
        new ("BackgroundImage", typeof(Image))
    };

    //
    public override DataTable Data { get; }
    public override string ExportFileName { get; }
    public override string DataTableName => "CertificateData";

    //
    public PortraitJondiShaporCertificate(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName,
        string dateOfBirth,
        string nationalNumber, string courseName, string courseEnd, string courseLength)
    {
        _appStrings = strings;
        //
        _userImage = userImage.ConvertPngToJpg().ResizeImage(234, 324).RoundCorners(38);
        _serialNumber = serialNumber;
        _nameAndSurname = nameAndSurname;
        _fatherName = fatherName;
        _dateOfBirth = dateOfBirth;
        _nationalNumber = nationalNumber;
        _courseEnd = courseEnd;
        _courseName = courseName;
        _courseLength = courseLength;
        //
        Data = CreateCertificateDataTable();
        ExportFileName = nameAndSurname;
    }

    public override StiReport Report()
    {
        StiReport report = new StiReport();
        report.Load(Resources.PortraitJondiCert);
        return report;
    }

    private DataTable CreateCertificateDataTable()
    {
        try
        {
            DataTable table = new DataTable(DataTableName);
            table.Columns.AddRange(_columns);
            DataRow row = table.NewRow();
            row[_columns[0]] = _userImage;
            row[_columns[1]] = _serialNumber;
            row[_columns[2]] = _nameAndSurname;
            row[_columns[3]] = _fatherName;
            row[_columns[4]] = _dateOfBirth;
            row[_columns[5]] = _nationalNumber;
            row[_columns[6]] = _courseEnd;
            row[_columns[7]] = _courseName;
            row[_columns[8]] = _courseLength;
            row[_columns[9]] = BackgroundImage();
            table.Rows.Add(row);
            return table;
        }
        catch (Exception exception)
        {
            Alerter.HandleException(exception, _appStrings.ErrorSetupDataTable, true);
        }

        return null;

    }
}

public abstract class LandscapeJondiShaporCertificate : Certificate
{
    private readonly AppStrings _appStrings;
    //
    private readonly Image _userImage;
    private readonly string _certDate;
    private readonly string _serialNumber;
    private readonly string _nationalNumber;
    private readonly string _nameAndSurname;
    private readonly string _fatherName;
    private readonly string _dateOfBirth;
    private readonly string _units;
    private readonly string _courseName;
    private readonly string _avg;

    protected abstract Image BackgroundImage();
    //
    private readonly DataColumn[] _columns = {
        new ("UserImage", typeof(Image)),
        new ("SerialNumber", typeof(string)),
        new ("Name", typeof(string)),
        new ("FatherName", typeof(string)),
        new ("DateOfBirth", typeof(string)),
        new ("NationalNumber", typeof(string)),
        new ("CertDate", typeof(string)),
        new ("CourseName", typeof(string)),
        new ("Units", typeof(string)),
        new ("BackgroundImage", typeof(Image)),
        new ("Avg", typeof(string))
    };

    //
    public override DataTable Data { get; }
    public override string ExportFileName { get; }
    public override string DataTableName => "CertificateData";

    //
    public LandscapeJondiShaporCertificate(AppStrings strings, Image userImage, string serialNumber, string nameAndSurname, string fatherName,
        string dateOfBirth,
        string nationalNumber, string courseName, string certDate, string units, string avg)
    {
        _appStrings = strings;
        //
        _userImage = userImage.ConvertPngToJpg().ResizeImage(234, 324);
        _serialNumber = serialNumber;
        _nameAndSurname = nameAndSurname;
        _fatherName = fatherName;
        _dateOfBirth = dateOfBirth;
        _nationalNumber = nationalNumber;
        _units = units;
        _courseName = courseName;
        _certDate = certDate;
        _avg = avg;
        //
        Data = CreateCertificateDataTable();
        ExportFileName = nameAndSurname;
    }

    public override StiReport Report()
    {
        StiReport report = new StiReport();
        report.Load(Resources.LandscapeJondiCert);
        return report;
    }

    private DataTable CreateCertificateDataTable()
    {
        try
        {
            DataTable table = new DataTable(DataTableName);
            table.Columns.AddRange(_columns);
            DataRow row = table.NewRow();
            row[_columns[0]] = _userImage;
            row[_columns[1]] = _serialNumber;
            row[_columns[2]] = _nameAndSurname;
            row[_columns[3]] = _fatherName;
            row[_columns[4]] = _dateOfBirth;
            row[_columns[5]] = _nationalNumber;
            row[_columns[6]] = _certDate;
            row[_columns[7]] = _courseName;
            row[_columns[8]] = _units;
            row[_columns[9]] = BackgroundImage();
            row[_columns[10]] = _avg;
            table.Rows.Add(row);
            return table;
        }
        catch (Exception exception)
        {
            Alerter.HandleException(exception, _appStrings.ErrorSetupDataTable, true);
        }

        return null;

    }
}