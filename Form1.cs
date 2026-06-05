using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DownloadVideo;
using System.IO;

namespace DownloadVideo
{
    public partial class Form1 : Form
    {
        string pathDownload = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
        public Form1()
        {
            InitializeComponent();
            txtURL.BackColor = Color.FromArgb(16, 25, 61);
            btnDownload.BackColor =btnAboutMe.BackColor=btnExit.BackColor=btnHome.BackColor =Color.FromArgb(134, 27, 250);
          
            lblStatus.Visible = false;
            btnDownload.Enabled = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtURL.Text))
            {

                MessageBox.Show("Please enter a URL before downloading.", "Missing URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            lblStatus.Visible = true;
            lblStatus.Text = "Downloading......";
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "yt-dlp.exe";
            info.Arguments = $"-o \"{pathDownload}\\%(title)s.%(ext)s\" {txtURL.Text}";
            Process process1 = Process.Start(info);
            process1.WaitForExit();
            lblStatus.Text = "Done";


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void txtURL_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtURL.Text))
            {

                btnDownload.Enabled = false;
            }
            else
            {

                btnDownload.Enabled = true;
            }
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            Form form = new frmAboutme();
            form.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {

                pathDownload = folder.SelectedPath;
            }
        }
    }
}
