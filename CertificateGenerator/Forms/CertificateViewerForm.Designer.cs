using System.ComponentModel;

namespace CertificateGenerator.Forms;

partial class CertificateViewerForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param nameAndSurname="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.stiViewer = new Stimulsoft.Report.Viewer.StiViewerControl();
        this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        this.saveButton = new MetroFramework.Controls.MetroTile();
        this.tableLayoutPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // stiViewer
        // 
        this.stiViewer.AllowDrop = true;
        this.stiViewer.BackColor = System.Drawing.Color.Black;
        this.stiViewer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.stiViewer.Dock = System.Windows.Forms.DockStyle.Fill;
        this.stiViewer.Location = new System.Drawing.Point(3, 3);
        this.stiViewer.Name = "stiViewer";
        this.stiViewer.PageViewMode = Stimulsoft.Report.Viewer.StiPageViewMode.SinglePage;
        this.stiViewer.Report = null;
        this.stiViewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
        this.stiViewer.ShowBookmarksPanel = false;
        this.stiViewer.ShowContextMenu = false;
        this.stiViewer.ShowDotMatrixModeButton = false;
        this.stiViewer.ShowEditor = false;
        this.stiViewer.ShowFind = false;
        this.stiViewer.ShowFirstPage = false;
        this.stiViewer.ShowFullScreen = false;
        this.stiViewer.ShowHelpButton = false;
        this.stiViewer.ShowLastPage = false;
        this.stiViewer.ShowNextPage = false;
        this.stiViewer.ShowOpen = false;
        this.stiViewer.ShowPageControl = false;
        this.stiViewer.ShowPageDelete = false;
        this.stiViewer.ShowPageDesign = false;
        this.stiViewer.ShowPageNew = false;
        this.stiViewer.ShowPageSize = false;
        this.stiViewer.ShowPageViewMode = false;
        this.stiViewer.ShowParametersButton = false;
        this.stiViewer.ShowPreviousPage = false;
        this.stiViewer.ShowPrint = false;
        this.stiViewer.ShowResourcesButton = false;
        this.stiViewer.ShowSave = false;
        this.stiViewer.ShowSaveDocumentFile = false;
        this.stiViewer.ShowSendEMail = false;
        this.stiViewer.ShowSendEMailDocumentFile = false;
        this.stiViewer.ShowSignature = false;
        this.stiViewer.ShowSliderZoom = false;
        this.stiViewer.ShowStatusBar = false;
        this.stiViewer.ShowThumbsPanel = false;
        this.stiViewer.ShowToolbar = false;
        this.stiViewer.ShowViewModeContinuous = false;
        this.stiViewer.ShowViewModeMultiplePages = false;
        this.stiViewer.ShowViewModeSinglePage = false;
        this.stiViewer.ShowZoom = false;
        this.stiViewer.ShowZoomMultiplePages = false;
        this.stiViewer.ShowZoomOnePage = false;
        this.stiViewer.ShowZoomPageWidth = false;
        this.stiViewer.ShowZoomTwoPages = false;
        this.stiViewer.Size = new System.Drawing.Size(1056, 501);
        this.stiViewer.TabIndex = 0;
        this.stiViewer.TabStop = false;
        this.stiViewer.ThumbsPanelEnabled = false;
        // 
        // tableLayoutPanel
        // 
        this.tableLayoutPanel.ColumnCount = 1;
        this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        this.tableLayoutPanel.Controls.Add(this.stiViewer, 0, 0);
        this.tableLayoutPanel.Controls.Add(this.saveButton, 0, 1);
        this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel.Location = new System.Drawing.Point(20, 30);
        this.tableLayoutPanel.Name = "tableLayoutPanel";
        this.tableLayoutPanel.RowCount = 2;
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.Size = new System.Drawing.Size(1062, 564);
        this.tableLayoutPanel.TabIndex = 1;
        // 
        // saveButton
        // 
        this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.saveButton.Enabled = false;
        this.saveButton.Location = new System.Drawing.Point(3, 510);
        this.saveButton.Name = "saveButton";
        this.saveButton.PaintTileCount = false;
        this.saveButton.Size = new System.Drawing.Size(1056, 51);
        this.saveButton.Style = MetroFramework.MetroColorStyle.Orange;
        this.saveButton.TabIndex = 0;
        this.saveButton.Text = "ذخیره گواهی";
        this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.saveButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
        this.saveButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
        this.saveButton.Visible = false;
        this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
        // 
        // CertificateViewerForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1102, 614);
        this.Controls.Add(this.tableLayoutPanel);
        this.DisplayHeader = false;
        this.Name = "CertificateViewerForm";
        this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
        this.ShowInTaskbar = false;
        this.Style = MetroFramework.MetroColorStyle.Orange;
        this.Text = "پیش نمایش گواهی";
        this.Theme = MetroFramework.MetroThemeStyle.Dark;
        this.TopMost = true;
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CertificateReviewer_FormClosing);
        this.tableLayoutPanel.ResumeLayout(false);
        this.ResumeLayout(false);
    }
    
    #endregion

    private Stimulsoft.Report.Viewer.StiViewerControl stiViewer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private MetroFramework.Controls.MetroTile saveButton;
}