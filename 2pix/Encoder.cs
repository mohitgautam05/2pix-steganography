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
    public partial class Encoder : Form
    {
        Bitmap image;

        public Encoder()
        {
            InitializeComponent();
            ddlQuality.SelectedIndex = 0;
        }

        private void UpdateEncryptStatus()
        {
            if (cbScaleImage.Checked)
            {
                Size scale = GetImageScale();
                lblStatus.Text = "Scale to " + scale.Width + "x" + scale.Height;
            }
            else
            {
                double percent = GetPercentFull();
                if (GetFileSize() < GetImageStorage())
                {
                    lblStatus.Text = percent.ToString("0.00") + "% Full";
                }
                else
                {
                    lblStatus.Text = "File is too large for image!";
                }
            }
        }

        private double GetPercentFull()
        {
            return (GetFileSize() * 100.0) / GetImageStorage();
        }

        private void UpdateStorage()
        {
            labelStatus.Text = (GetImageStorage() / 1024.0).ToString("0.00") + " KB";
        }

        private long GetImageStorage()
        {
            return GetImageStorage(image.Width, image.Height);
        }

        private long GetImageStorage(int width, int height)
        {
            return (long)((((double)width * (double)height * 3.0) / 8.0) * (double)(ddlQuality.SelectedIndex + 1));
        }

        private long GetFileSize()
        {
            if (File.Exists(txtEncodeFile.Text))
            {
                FileInfo info = new FileInfo(txtEncodeFile.Text);
                return info.Length;
            }
            return 0L;
        }

        private Size GetImageScale()
        {
            // Here's the math that determines the new dimensions of the image:
            // (3 / 8) * width * height * quality >= fileSize
            // (8 * fileSize) / (3 * quality) <= width * height
            // scale = height / width
            // height * width = width * width * scale
            // width ^ 2 * scale >= (8 * fileSize) / (3 * quality)
            // width ^ 2 >= (8 * fileSize) / (3 * quality * scale)
            // width >= sqrt((8 * fileSize) / (3 * quality * scale))

            double width = image.Width;
            double height = image.Height;
            double quality = ddlQuality.SelectedIndex + 1;
            double size = GetFileSize();
            double scale = height / width;

            double newWidth = Math.Sqrt((8.0 * size) / (3.0 * quality * scale)) + 5.0; // add a 5 pixel buffer to be safe
            double newHeight = newWidth * scale;

            return new Size((int)newWidth, (int)newHeight);
        }

        private void CheckAllowEncode()
        {
            btnEncodeSave.Enabled = 
                txtEncodeImage.Text.Length > 0 && 
                txtEncodeFile.Text.Length > 0 && 
                ddlQuality.SelectedIndex >= 0 &&
                txtEncryptKey.Text == txtEncryptKeyAgain.Text &&
                (GetPercentFull() <= 100.0 || cbScaleImage.Checked);
        }

        private void btnEncodeLoadImage_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtEncodeImage.Text = openFileDialog1.FileName;
                image = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);

                UpdateStorage();
                UpdateEncryptStatus();
            }
            CheckAllowEncode();
        }

        private void btnEncodeLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog2.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtEncodeFile.Text = openFileDialog2.FileName;
                UpdateEncryptStatus();
            }
            CheckAllowEncode();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlQuality.SelectedIndex > 0)
            {
                UpdateStorage();
                UpdateEncryptStatus();
                CheckAllowEncode();
            }
        }

        private void btnEncodeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEncryptKeyAgain.Text != txtEncryptKey.Text)
                {
                    MessageBox.Show("The passwords do not match!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtEncodeImage.Text.Length > 0 && txtEncodeFile.Text.Length > 0)
                {
                    DialogResult d = saveFileDialog1.ShowDialog();
                    if (d == DialogResult.OK)
                    {
                        // Format the image for encoding
                        Image originalImage = Bitmap.FromFile(txtEncodeImage.Text);

                        // See if we need to resize the image
                        Size scale;
                        if (cbScaleImage.Checked)
                        {
                            scale = GetImageScale();
                        }
                        else
                        {
                            scale = new Size(originalImage.Width, originalImage.Height);
                        }

                        // Get a bitmap of the correct size
                        Bitmap image = new Bitmap(scale.Width, scale.Height);
                        Graphics g = Graphics.FromImage(image);
                        g.DrawImage(originalImage, 0, 0, scale.Width, scale.Height);

                        // Encode and save
                        TP_Stenography.EncodeImage(image, new TP_File(txtEncodeFile.Text, txtEncryptKey.Text), ddlQuality.SelectedIndex + 1);
                        image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    }

                    MessageBox.Show("File Saved!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileTooLargeForImageException)
            {
                MessageBox.Show("The image is not large enough to hold that file.", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "2pix", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbScaleImage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEncryptStatus();
            CheckAllowEncode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEncryptKey_TextChanged(object sender, EventArgs e)
        {
            CheckAllowEncode();
        }

        private void txtEncryptKeyAgain_TextChanged(object sender, EventArgs e)
        {
            CheckAllowEncode();
        }
    }
}
