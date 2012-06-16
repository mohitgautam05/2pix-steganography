using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScottClayton.Stenography.Twopix;
using System.IO;

namespace _pix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ddlQuality.SelectedIndex = 0;

            //SetRightClickMenu();
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

        private void UpdateEncryptStatus()
        {
            if (cbScaleImage.Checked)
            {
                Size scale = GetImageScale();
                lblStatus.Text = "Scale to " + scale.Width + "x" + scale.Height;
            }
            else
            {
                double percent = (GetFileSize() * 100.0) / GetImageStorage();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog1.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtEncodeImage.Text = openFileDialog1.FileName;
                pictureBox1.Image = (Image)Bitmap.FromFile(openFileDialog1.FileName);

                UpdateStorage();
                UpdateEncryptStatus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog2.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtEncodeFile.Text = openFileDialog2.FileName;
                UpdateEncryptStatus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEncryptKeyAgain.Text != txtEncryptKey.Text)
                {
                    MessageBox.Show("The passwords do not match!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtEncodeImage.Text.Length > 0 && txtEncodeFile.Text.Length > 0)
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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = openFileDialog2.ShowDialog();
            if (d == DialogResult.OK)
            {
                txtDecodeImageLocation.Text = openFileDialog2.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                    }

                    MessageBox.Show("File Extracted!", "2pix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("There was an error extracting a file from this image.\nPossbile causes include:\n\n" +
                    " - Invalid decryption key\n - Image does not contain any hidden files\n - Image was corrupted", "2pix",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2pix stenographically hides Rinjdael encrypted files in the low order bits of a bitmap image.\n\n" +
                "Scott Clayton 2010-2012", "2pix Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStorage();
            UpdateEncryptStatus();
        }

        private void cbScaleImage_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEncryptStatus();
        }

        private void UpdateStorage()
        {
            toolStripStatusLabel1.Text = "Storage Capacity of This Image: " + (GetImageStorage() / 1024.0).ToString("0.00") + " KB";
        }

        private long GetImageStorage()
        {
            return GetImageStorage(pictureBox1.Image.Width, pictureBox1.Image.Height);
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

            double width = pictureBox1.Image.Width;
            double height = pictureBox1.Image.Height;
            double quality = ddlQuality.SelectedIndex + 1;
            double size = GetFileSize();
            double scale = height / width;

            double newWidth = Math.Sqrt((8.0 * size) / (3.0 * quality * scale)) + 5.0; // add a 5 pixel buffer to be safe
            double newHeight = newWidth * scale;

            return new Size((int)newWidth, (int)newHeight);
        }
    }
}