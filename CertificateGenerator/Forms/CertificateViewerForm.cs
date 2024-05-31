using CertificateGenerator.Certificates;
using CertificateGenerator.Extensions;
using CertificateGenerator.Strings;
using CertificateGenerator.Utility_Side_Classes;
using Stimulsoft.Report;
using Stimulsoft.Report.Export;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateGenerator.Forms;

public partial class CertificateViewerForm : MetroFramework.Forms.MetroForm
{

    private readonly Certificate _certificate;
    private readonly StiReport _report;
    private readonly AppStrings _appStrings;
    private readonly ImageCompressor _imageCompressor;
    private readonly Color _color;



    public CertificateViewerForm(AppStrings appStrings, ImageCompressor imageCompressor, Certificate certificate, Color certColor)
    {
        this.ApplyFormIcon();
        //
        _appStrings = appStrings;
        _imageCompressor = imageCompressor;
        _certificate = certificate;
        _color = certColor;
        _report = certificate.Report();
        //
        InitializeComponent();
        SetControlsText();
        ApplyColor();
        //
        Task.Run(InitializeAsync);
        stiViewer.Report = _report;
        stiViewer.InvokeZoomOnePage();
        //
        EnableSave();
        WindowState = FormWindowState.Maximized;
    }

    private void SetControlsText()
    {
        Text = _appStrings.CertViewFormText;
        saveButton.Text = _appStrings.CertViewFormSaveButtonText;
    }

    private void ApplyColor()
    {
        StyleColor = ForeColor = saveButton.HighlightColor = saveButton.ForegroundColor = _color;
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
            _report.RegData(_certificate.DataTableName, _certificate.Data);
            await _report.RenderAsync();
        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorLoadRegRenderReport, true);
        }
    }

    private async Task ExportCompressAndSaveReport(string path, string fileName)
    {
        StiBmpExportSettings reportSettings = new()
        {
            ImageResolution = 300
        };
        using MemoryStream reportAsStream = new MemoryStream();
        try
        {
            await _report.ExportDocumentAsync(StiExportFormat.Image, reportAsStream, reportSettings);
            MemoryStream compressedReportAsStream = _imageCompressor.ReCompressImage(reportAsStream);
            IoUtilities.SaveAndShowReportAsFile(path, fileName, compressedReportAsStream);
        }
        catch (Exception ex)
        {
            Alerter.HandleException(ex, _appStrings.ErrorExportReport, true);
        }
    }

    private void CertificateReviewer_FormClosing(object sender, FormClosingEventArgs e)
    {
        _report.Dispose();
    }

    private async void saveButton_Click(object sender, EventArgs e)
    {
        string fileName;
        string path;
        bool? validSave = Alerter.SelectSavePath(_report, _certificate.ExportFileName, out fileName, out path);
        if (validSave == null) return;
        saveButton.Enabled = false;
        await ExportCompressAndSaveReport(path, fileName);
        Close();
    }
}