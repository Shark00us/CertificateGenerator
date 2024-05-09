using CertificateGenerator.Extensions;
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



    public CertificateViewerForm(JondiShaporCertificate jondiShaporCertificate)
    {
        StiUX.Theme = StiControlTheme.Dark;
        InitializeComponent();
        this.ApplyFormIcon();
        /**************************************************************/
        _jondiShaporCertificate = jondiShaporCertificate;
        Task.Run(InitializeAsync);
        stiViewer.Report = _report;
        /**************************************************************/
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

    private async Task ExportCompressAndSaveReport()
    {
        try
        {
            StiBmpExportSettings reportSettings = new()
            {
                ImageResolution = 300
            };
            using MemoryStream reportAsStream = new MemoryStream();
            await _report.ExportDocumentAsync(StiExportFormat.Image, reportAsStream, reportSettings);
            MemoryStream compressedReportAsStream = reportAsStream.ReCompressImage();
            IOUtilities.SaveReportAsFile(_jondiShaporCertificate.FileName, compressedReportAsStream);
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
        await ExportCompressAndSaveReport();
        IOUtilities.ShowReportResults(_jondiShaporCertificate.FileName);
        Application.Exit();
    }
}