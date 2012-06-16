using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ScottClayton.Stenography.Twopix;

namespace _pxcmd
{
    public partial class Form1 : Form
    {
        string argFile;

        public Form1(string[] args)
        {
            InitializeComponent();

            argFile = "";
            if (args.Length >= 1)
            {
                foreach (string s in args)
                {
                    argFile += s + " ";
                }
                argFile = argFile.Substring(0, argFile.Length - 1);
            }

            if (!File.Exists(argFile))
            {
                MessageBox.Show("The file specified does not exist!\n" + argFile);
            }

            textBox1.Text = argFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = textBox1.Text;
                string key = textBox2.Text;

                string dest = fileName.Substring(0, fileName.LastIndexOf("\\")) + "\\";

                if (File.Exists(fileName))
                {
                    TP_File file = TP_Stenography.DecodeImage((Bitmap)Bitmap.FromFile(fileName), key);
                    
                    // Get the original file name, but don't overwrite anything
                    string name = dest + file.GetFileName();
                    if (File.Exists(name))
                        name = dest + "2pix_" + file.GetFileName();

                    file.Save(name);
                }

                MessageBox.Show("The file was extracted!", "2pix",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch
            {
                MessageBox.Show("There was an error extracting a file from this image.\nPossbile causes include:\n\n" +
                    " - Invalid decryption key\n - Image does not contain any hidden files\n - Image was corrupted", "2pix",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}