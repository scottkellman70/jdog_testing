using Microsoft.Office.Interop.Word;
using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace SOFDT3
{
    public partial class TriageForm : Form
    {
        public TriageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBrowseCase_Click(object sender, EventArgs e)
        {
            this.listBoxCaseFolders.Items.Clear();
            DialogResult result = this.folderBrowserDialogCases.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxCaseLocation.Text = this.folderBrowserDialogCases.SelectedPath;
                string[] folders = Directory.GetDirectories(this.folderBrowserDialogCases.SelectedPath);

                foreach (string dir in folders)
                {
                    listBoxCaseFolders.Items.Add(dir);
                }
            }
        }

        private void ButtonBrowseRips_Click(object sender, EventArgs e)
        {
            this.listBoxRipFolders.Items.Clear();
            //this.pdfViewer1.LoadFromFile = string.Empty;
            this.axWindowsMediaPlayerRip.URL = string.Empty;

            DialogResult result = this.folderBrowserDialogRips.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBoxRipLocation.Text = this.folderBrowserDialogRips.SelectedPath;
                string[] files = Directory.GetFiles(this.folderBrowserDialogRips.SelectedPath);

                foreach (string dir in files)
                {
                    listBoxRipFolders.Items.Add(dir);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCaseFolders_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                //path to dragged file
                string str = (string)e.Data.GetData(DataFormats.StringFormat);
                string fileName = Path.GetFileName(str);
                string dropPath = this.listBoxCaseFolders.SelectedItem.ToString();

                if (File.Exists(str))
                {
                    File.Copy(str, dropPath + @"\" + fileName);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxCaseFolders_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxRipFolders_MouseDown(object sender, MouseEventArgs e)
        {
            //get file type
            bool isImage = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).StartsWith("image/");
            bool isVideo = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).StartsWith("video/");
            bool isAudio = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).StartsWith("audio/");
            bool isPdf = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).StartsWith("application/pdf");
            bool isText = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).StartsWith("text/plain");
            bool isWordDoc = MimeMapping.MimeUtility.GetMimeMapping(this.listBoxRipFolders.SelectedItem.ToString()).Contains("msword");

            if (isImage == true)
            {
                Image myimage = new Bitmap(this.listBoxRipFolders.SelectedItem.ToString());
                this.pictureBoxPreview.BackgroundImage = myimage;
            }

            if (isVideo == true || isAudio == true)
            {
                ShellFile shellFile = ShellFile.FromFilePath(this.listBoxRipFolders.SelectedItem.ToString());
                Bitmap bm = shellFile.Thumbnail.Bitmap;
                Image myimage = bm;
                this.pictureBoxPreview.BackgroundImage = myimage;
                this.axWindowsMediaPlayerRip.URL = this.listBoxRipFolders.SelectedItem.ToString();
            }

            if (isPdf == true)
            {
                this.pdfViewer1.LoadFromFile(this.listBoxRipFolders.SelectedItem.ToString());
            }

            if (isText == true)
            {
                FillRichText(this.listBoxRipFolders.SelectedItem.ToString(), this.richTextBoxFilePreview);
            }

            if (isWordDoc == true)
            {
                //this.docDocumentViewer1.LoadFromFile(this.listBoxRipFolders.SelectedItem.ToString());
                //Document word = new Document();
                //var wordApp = new Microsoft.Office.Interop.Word.Application();
                //wordApp.Documents.Open(this.listBoxRipFolders.SelectedItem.ToString());
            }


            if (listBoxRipFolders.Items.Count == 0)
            {
                return;
            }

            int index = listBoxRipFolders.IndexFromPoint(e.X, e.Y);
            string s = listBoxRipFolders.Items[index].ToString();

            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All)
            {
                listBoxRipFolders.Items.RemoveAt(listBoxRipFolders.IndexFromPoint(e.X, e.Y));
            }
        }

        public void FillRichText(string aPath, RichTextBox rtb)
        {
            rtb.Text = string.Empty;
            string content = File.ReadAllText(aPath);
            rtb.Text = content;
        }


        private void ListBoxCaseFolders_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            // Select the item at this screen location.
            listBoxCaseFolders.SelectedIndex = listBoxCaseFolders.IndexFromScreenPoint(new System.Drawing.Point(e.X, e.Y));
        }

        private void docDocumentViewer1_Click(object sender, EventArgs e)
        {

        }
    }
}
