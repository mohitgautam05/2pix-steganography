using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _pix
{
    public partial class NewMain : Form
    {
        public NewMain()
        {
            InitializeComponent();
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
    }
}
