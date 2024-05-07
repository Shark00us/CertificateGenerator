using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateGenerator.Forms;

public partial class CertificateViewerForm : MetroFramework.Forms.MetroForm
{
    private readonly JondiShaporCertificate _jondiShaporCertificate;
    private readonly StiReport _report = new();

    private readonly StiBmpExportSettings _reportSettings = new()
    {
        ImageResolution = 300,
        ImageType = StiImageType.Bmp
    };

    public CertificateViewerForm(JondiShaporCertificate jondiShaporCertificate)
    {
        StiUX.Theme = StiControlTheme.Dark;
        InitializeComponent();
        _jondiShaporCertificate = jondiShaporCertificate;
        Task.Run(InitializeAsync);
        stiViewer.Report = _report;
        EnableSave();
    }

    private void EnableSave()
    {
        saveButton.Enabled = saveButton.Visible = true;
    }

    private async Task InitializeAsync()
    {
        await SetupReportAsync();
    }

    private async Task SetupReportAsync()
    {
        try
        {
            _report.Load(Properties.Resources.jondicert);
            _report.RegData("CertificateData", _jondiShaporCertificate.Data);
            await _report.RenderAsync();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error at SetupReportAsync(): {ex.Message}");
        }
    }

    private async Task ExportReportAndSave()
    {
        try
        {
            using MemoryStream reportAsStream = new MemoryStream();
            await _report.ExportDocumentAsync(StiExportFormat.ImageBmp, reportAsStream, _reportSettings);
            IOUtilities.SaveReportAsFile(_jondiShaporCertificate.FileName, reportAsStream);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Error Exporting to File \n{e.Message}");
        }
    }

    private void CertificateReviewer_FormClosing(object sender, FormClosingEventArgs e)
    {
        _report.Dispose();
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        await ExportReportAndSave();
        IOUtilities.ShowResults(_jondiShaporCertificate.FileName);
        Application.Exit();
    }
}