namespace SOFDT3
{
    partial class TriageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriageForm));
            this.folderBrowserDialogCases = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogRips = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonBrowseCase = new System.Windows.Forms.Button();
            this.listBoxCaseFolders = new System.Windows.Forms.ListBox();
            this.buttonBrowseRips = new System.Windows.Forms.Button();
            this.textBoxCaseLocation = new System.Windows.Forms.TextBox();
            this.listBoxRipFolders = new System.Windows.Forms.ListBox();
            this.textBoxRipLocation = new System.Windows.Forms.TextBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.richTextBoxFilePreview = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayerRip = new AxWMPLib.AxWindowsMediaPlayer();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.docDocumentViewer1 = new Spire.DocViewer.Forms.DocDocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerRip)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBrowseCase
            // 
            this.ButtonBrowseCase.Location = new System.Drawing.Point(13, 41);
            this.ButtonBrowseCase.Name = "ButtonBrowseCase";
            this.ButtonBrowseCase.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowseCase.TabIndex = 1;
            this.ButtonBrowseCase.Text = "Cases";
            this.ButtonBrowseCase.UseVisualStyleBackColor = true;
            this.ButtonBrowseCase.Click += new System.EventHandler(this.ButtonBrowseCase_Click);
            // 
            // listBoxCaseFolders
            // 
            this.listBoxCaseFolders.AllowDrop = true;
            this.listBoxCaseFolders.FormattingEnabled = true;
            this.listBoxCaseFolders.Location = new System.Drawing.Point(13, 71);
            this.listBoxCaseFolders.Name = "listBoxCaseFolders";
            this.listBoxCaseFolders.ScrollAlwaysVisible = true;
            this.listBoxCaseFolders.Size = new System.Drawing.Size(664, 160);
            this.listBoxCaseFolders.TabIndex = 2;
            this.listBoxCaseFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxCaseFolders_DragDrop);
            this.listBoxCaseFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxCaseFolders_DragEnter);
            this.listBoxCaseFolders.DragOver += new System.Windows.Forms.DragEventHandler(this.ListBoxCaseFolders_DragOver);
            // 
            // buttonBrowseRips
            // 
            this.buttonBrowseRips.Location = new System.Drawing.Point(13, 251);
            this.buttonBrowseRips.Name = "buttonBrowseRips";
            this.buttonBrowseRips.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseRips.TabIndex = 3;
            this.buttonBrowseRips.Text = "Rips";
            this.buttonBrowseRips.UseVisualStyleBackColor = true;
            this.buttonBrowseRips.Click += new System.EventHandler(this.ButtonBrowseRips_Click);
            // 
            // textBoxCaseLocation
            // 
            this.textBoxCaseLocation.Location = new System.Drawing.Point(95, 43);
            this.textBoxCaseLocation.Name = "textBoxCaseLocation";
            this.textBoxCaseLocation.Size = new System.Drawing.Size(582, 20);
            this.textBoxCaseLocation.TabIndex = 4;
            // 
            // listBoxRipFolders
            // 
            this.listBoxRipFolders.FormattingEnabled = true;
            this.listBoxRipFolders.Location = new System.Drawing.Point(13, 282);
            this.listBoxRipFolders.Name = "listBoxRipFolders";
            this.listBoxRipFolders.ScrollAlwaysVisible = true;
            this.listBoxRipFolders.Size = new System.Drawing.Size(664, 160);
            this.listBoxRipFolders.TabIndex = 5;
            this.listBoxRipFolders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxRipFolders_MouseDown);
            // 
            // textBoxRipLocation
            // 
            this.textBoxRipLocation.Location = new System.Drawing.Point(95, 251);
            this.textBoxRipLocation.Name = "textBoxRipLocation";
            this.textBoxRipLocation.Size = new System.Drawing.Size(582, 20);
            this.textBoxRipLocation.TabIndex = 6;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPreview.Location = new System.Drawing.Point(737, 186);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(294, 257);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 7;
            this.pictureBoxPreview.TabStop = false;
            // 
            // richTextBoxFilePreview
            // 
            this.richTextBoxFilePreview.Location = new System.Drawing.Point(313, 448);
            this.richTextBoxFilePreview.Name = "richTextBoxFilePreview";
            this.richTextBoxFilePreview.Size = new System.Drawing.Size(364, 300);
            this.richTextBoxFilePreview.TabIndex = 10;
            this.richTextBoxFilePreview.Text = "";
            // 
            // axWindowsMediaPlayerRip
            // 
            this.axWindowsMediaPlayerRip.Enabled = true;
            this.axWindowsMediaPlayerRip.Location = new System.Drawing.Point(696, 449);
            this.axWindowsMediaPlayerRip.Name = "axWindowsMediaPlayerRip";
            this.axWindowsMediaPlayerRip.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerRip.OcxState")));
            this.axWindowsMediaPlayerRip.Size = new System.Drawing.Size(378, 301);
            this.axWindowsMediaPlayerRip.TabIndex = 11;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(12, 449);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(295, 290);
            this.pdfViewer1.TabIndex = 12;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // docDocumentViewer1
            // 
            this.docDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.docDocumentViewer1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.docDocumentViewer1.EnableHandTools = false;
            this.docDocumentViewer1.Location = new System.Drawing.Point(1055, 189);
            this.docDocumentViewer1.Name = "docDocumentViewer1";
            this.docDocumentViewer1.Size = new System.Drawing.Size(397, 253);
            this.docDocumentViewer1.TabIndex = 13;
            this.docDocumentViewer1.Text = "docDocumentViewer1";
            this.docDocumentViewer1.ToPdfParameterList = null;
            this.docDocumentViewer1.ZoomMode = Spire.DocViewer.Forms.ZoomMode.Default;
            this.docDocumentViewer1.Click += new System.EventHandler(this.docDocumentViewer1_Click);
            // 
            // TriageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 761);
            this.Controls.Add(this.docDocumentViewer1);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.axWindowsMediaPlayerRip);
            this.Controls.Add(this.richTextBoxFilePreview);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.textBoxRipLocation);
            this.Controls.Add(this.listBoxRipFolders);
            this.Controls.Add(this.textBoxCaseLocation);
            this.Controls.Add(this.buttonBrowseRips);
            this.Controls.Add(this.listBoxCaseFolders);
            this.Controls.Add(this.ButtonBrowseCase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TriageForm";
            this.Text = "DT3 Triage Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerRip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCases;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogRips;
        private System.Windows.Forms.Button ButtonBrowseCase;
        private System.Windows.Forms.ListBox listBoxCaseFolders;
        private System.Windows.Forms.Button buttonBrowseRips;
        private System.Windows.Forms.TextBox textBoxCaseLocation;
        private System.Windows.Forms.ListBox listBoxRipFolders;
        private System.Windows.Forms.TextBox textBoxRipLocation;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.RichTextBox richTextBoxFilePreview;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerRip;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private Spire.DocViewer.Forms.DocDocumentViewer docDocumentViewer1;
    }
}

