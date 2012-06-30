using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TwoPix.Http;
using System.Diagnostics;

namespace _pix
{
    public partial class DownloadVersion : Form
    {
        BackgroundWorker worker;
        DownloadInfo info;

        public DownloadVersion(DownloadInfo info)
        {
            InitializeComponent();

            this.info = info;

            linkLabel1.Text = info.URL;
            label2.Text = "The latest version of 2pix is v" + info.NewVersion;

            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.RunWorkerAsync();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            richTextBox1.Text = (string)e.Result;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = new HttpControl().Get(info.ReadmeURL);
            }
            catch
            {
                e.Result = "Failed to download README.txt";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(linkLabel1.Text);
            }
            catch
            {
                // Gobble!
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class DownloadInfo
    {
        public string URL { get; set; }
        public string ReadmeURL { get; set; }
        public string NewVersion { get; set; }
    }
}
