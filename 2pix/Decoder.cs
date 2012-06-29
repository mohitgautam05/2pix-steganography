using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ScottClayton.Stenography.Twopix;

namespace _pix
{
    public partial class Decoder : Form
    {
        public Decoder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDecodeLoadImage_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog2.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtDecodeImageLocation.Text = openFileDialog2.FileName;
            }
        }

        private void btnDecodeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDecodeImageLocation.Text.Length > 0)
                {
                    TP_File file = TP_Stenography.DecodeImage((Bitmap)Bitmap.FromFile(txtDecodeImageLocation.Text), txtDecodeKey.Text);
                    saveFileDialog2.FileName = file.GetFileName();

                    DialogResult d = saveFileDialog2.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        file.Save(saveFileDialog2.FileName);
                        MessageBox.Show("File Extracted!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error extracting a file from this image.\nPossbile causes include:\n\n" +
                    " - Invalid decryption key\n - Image does not contain any hidden files\n - Image was corrupted", "2pix",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
