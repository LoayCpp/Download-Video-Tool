using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadVideo
{
    public partial class frmAboutme : Form
    {
        public frmAboutme()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private void frmAboutme_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
           
        }
        private void Socail_Contact(string Link)
        {
            Process.Start(new ProcessStartInfo { FileName = Link, UseShellExecute = true });


        }
        private void picFacebook_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://www.facebook.com/share/1ByuvJEiyu/");
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://www.instagram.com/7.loa7?igsh=cWxjeHRzM2pnaWc2");

        }

        private void picX_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://x.com/7lo_ay");
        }

        private void picLinked_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://www.linkedin.com/in/luai-anwar");
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://github.com/LoayCpp");
        }

        private void btnContactMe_Click(object sender, EventArgs e)
        {
            Socail_Contact("https://t.me/Luai_Anwar");
        }
        private void Hand_Cursor(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Cursor = Cursors.Hand;

        }

        private void btnContactMe_MouseEnter(object sender, EventArgs e)
        {
            btnContactMe.Cursor = Cursors.Hand;
        }
    }
}
