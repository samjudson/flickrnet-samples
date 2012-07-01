using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) return;

            FilenameTextBox.Text = openFileDialog1.FileName;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            UploadButton.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var f = FlickrManager.GetAuthInstance();
            f.OnUploadProgress += new EventHandler<FlickrNet.UploadProgressEventArgs>(Flickr_OnUploadProgress);
            string photoId = f.UploadPicture(FilenameTextBox.Text, TitleTextBox.Text, DescriptionTextBox.Text, null, !IsPrivateCheckBox.Checked, false, false);

        }

        void Flickr_OnUploadProgress(object sender, FlickrNet.UploadProgressEventArgs e)
        {
            backgroundWorker1.ReportProgress(e.ProcessPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UploadButton.Enabled = true;

            MessageBox.Show("Upload completed");
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
