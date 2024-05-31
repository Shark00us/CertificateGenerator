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
            this.saveButton = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stiViewer
            // 
            this.stiViewer.AllowDrop = true;
            this.stiViewer.BackColor = System.Drawing.Color.Black;
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
            this.stiViewer.Size = new System.Drawing.Size(1056, 450);
            this.stiViewer.TabIndex = 0;
            this.stiViewer.TabStop = false;
            this.stiViewer.ThumbsPanelEnabled = false;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.stiViewer, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.saveButton, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.88889F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777778F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1062, 514);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.ActiveBackColor = System.Drawing.Color.Empty;
            this.saveButton.ActiveForeColor = System.Drawing.Color.Empty;
            this.saveButton.BackgroundColor = System.Drawing.Color.Empty;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.CustomMouseEnterColors = false;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Enabled = false;
            this.saveButton.FontSize = 18F;
            this.saveButton.FontStyle = System.Drawing.FontStyle.Bold;
            this.saveButton.ForegroundColor = System.Drawing.Color.Empty;
            this.saveButton.Highlight = true;
            this.saveButton.HighlightColor = System.Drawing.Color.Empty;
            this.saveButton.Location = new System.Drawing.Point(3, 473);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1056, 38);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "save";
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CertificateViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 614);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Vazirmatn", 20F, System.Drawing.FontStyle.Bold);
            this.MinimumSize = new System.Drawing.Size(1102, 614);
            this.Name = "CertificateViewerForm";
            this.Padding = new System.Windows.Forms.Padding(20, 80, 20, 20);
            this.Text = "review";
            this.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CertificateReviewer_FormClosing);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }
    
    #endregion

    private Stimulsoft.Report.Viewer.StiViewerControl stiViewer;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private MetroFramework.Controls.MetroButton saveButton;
}