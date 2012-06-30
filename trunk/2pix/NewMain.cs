using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TwoPix.Http;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection;

namespace _pix
{
    public partial class NewMain : Form
    {
        BackgroundWorker updater;
        bool autoStartedUpdate;

        public NewMain()
        {
            InitializeComponent();

            updater = new BackgroundWorker();
            updater.DoWork += new DoWorkEventHandler(updater_DoWork);
            updater.RunWorkerCompleted += new RunWorkerCompletedEventHandler(updater_RunWorkerCompleted);

            autoStartedUpdate = false;
        }

        void updater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateCheck check = (UpdateCheck)e.Result;
            if (check.Success)
            {
                if (check.MyVersion == check.LatestVersion)
                {
                    if (!autoStartedUpdate)
                    {
                        MessageBox.Show("Your version (v" + check.MyVersion + ") is up to date!", "2pix Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    toolStripStatusLabel1.Text = "Your version of 2pix is up to date!";
                }
                else
                {
                    //MessageBox.Show("There is a newer version of 2pix!\n\nDownload v" + check.LatestVersion + " from:\n\n" +
                    //    check.UpdateURL, "2pix Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //toolStripStatusLabel1.Text = "There is a newer version of 2pix!";

                    new DownloadVersion(new DownloadInfo()
                    {
                        URL = check.UpdateURL,
                        NewVersion = check.LatestVersion,
                        ReadmeURL = "http:" + "//2pix-steganography.googlecode.com/svn/trunk/README.txt"
                    }).ShowDialog();
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "Failed to check for updates!";
            }
        }

        void updater_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateCheck check = new UpdateCheck();
            try
            {
                HttpControl http = new HttpControl();
                string response = http.Get("http:" + "//2pix-steganography.googlecode.com/svn/trunk/setup.iss");

                check.LatestVersion = Regex.Match(response, @"AppVersion\=(?<version>[0-9\.]*)").Groups["version"].Value.Trim();
                check.UpdateURL = Regex.Match(response, @"AppUpdatesURL\=(?<url>.*)").Groups["url"].Value.Replace("\n", "").Replace("\n", "");
                check.MyVersion = GetCurrentVersion().Trim();
                check.Success = check.MyVersion != "" && check.LatestVersion != "";
            }
            catch
            {
                check.Success = false;
            }
            e.Result = check;
        }

        private void SetRightClickMenu()
        {
            try
            {
                string def = Registry.GetValue("HKEY_CLASSES_ROOT", ".bmp", "", "");
                string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
                path = path.Substring(6, path.Length - 6);

                Registry.SetValue("HKEY_CLASSES_ROOT", def + "\\shell\\ExtractWith2pix", "", "Extract with &2pix");
                Registry.SetValue("HKEY_CLASSES_ROOT", def + "\\shell\\ExtractWith2pix\\command", "", path + "\\2pixcmd.exe %1");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void associateBitmapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to add a right click \"Extract with 2pix\" option to the .bmp file extension?", "2pix",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SetRightClickMenu();

                MessageBox.Show("Done!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2pix steganographically hides Rinjdael encrypted files in the low order bits of bitmap images.\n\n" +
                "Scott Clayton 2010-" + DateTime.Now.Year, "2pix Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Encoder().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Decoder().ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoUpdate == "?")
            {
                DialogResult d = MessageBox.Show("Would you like to turn on auto-update checking?\n\n2pix will only bug you with messages when there is a newer version available.",
                    "2pix Auto-Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == System.Windows.Forms.DialogResult.Yes)
                {
                    Properties.Settings.Default.AutoUpdate = "ALWAYS";
                }
                else
                {
                    Properties.Settings.Default.AutoUpdate = "NEVER";
                }
                Properties.Settings.Default.Save();
            }

            if (!updater.IsBusy)
            {
                toolStripStatusLabel1.Text = "Checking for updates...";
                updater.RunWorkerAsync();
            }
        }

        private string GetCurrentVersion()
        {
            try
            {
                return File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\VERSION.txt");
                //string firstline = File.ReadAllLines(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\README.txt")[0];
                //return Regex.Match(firstline, @".*(?<version>([0-9]*\.)+).*").Groups["version"].Value;
            }
            catch
            {
                return "";
            }
        }

        private void NewMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoUpdate == "ALWAYS")
            {
                if (!updater.IsBusy)
                {
                    toolStripStatusLabel1.Text = "Checking for updates...";
                    updater.RunWorkerAsync();
                    autoStartedUpdate = true;
                }
            }
        }
    }

    public class UpdateCheck
    {
        public bool Success { get; set; }
        public string LatestVersion { get; set; }
        public string MyVersion { get; set; }
        public string UpdateURL { get; set; }
    }
}
