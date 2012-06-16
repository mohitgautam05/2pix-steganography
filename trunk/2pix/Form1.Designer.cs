namespace _pix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associateBitmapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecodeImageLocation = new System.Windows.Forms.TextBox();
            this.btnDecodeLoadImage = new System.Windows.Forms.Button();
            this.txtDecodeKey = new System.Windows.Forms.TextBox();
            this.btnDecodeSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbScaleImage = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlQuality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryptKeyAgain = new System.Windows.Forms.TextBox();
            this.txtEncryptKey = new System.Windows.Forms.TextBox();
            this.txtEncodeImage = new System.Windows.Forms.TextBox();
            this.btnEncodeLoadImage = new System.Windows.Forms.Button();
            this.txtEncodeFile = new System.Windows.Forms.TextBox();
            this.btnEncodeSave = new System.Windows.Forms.Button();
            this.btnEncodeLoadFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.associateBitmapsToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // associateBitmapsToolStripMenuItem
            // 
            this.associateBitmapsToolStripMenuItem.Name = "associateBitmapsToolStripMenuItem";
            this.associateBitmapsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.associateBitmapsToolStripMenuItem.Text = "&Add BMP Right Click Option";
            this.associateBitmapsToolStripMenuItem.Click += new System.EventHandler(this.associateBitmapsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Ready!";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(879, 455);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(879, 480);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(879, 455);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDecodeImageLocation);
            this.groupBox1.Controls.Add(this.btnDecodeLoadImage);
            this.groupBox1.Controls.Add(this.txtDecodeKey);
            this.groupBox1.Controls.Add(this.btnDecodeSave);
            this.groupBox1.Location = new System.Drawing.Point(7, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decoder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Step 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Step 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Key:";
            // 
            // txtDecodeImageLocation
            // 
            this.txtDecodeImageLocation.Location = new System.Drawing.Point(6, 19);
            this.txtDecodeImageLocation.Name = "txtDecodeImageLocation";
            this.txtDecodeImageLocation.ReadOnly = true;
            this.txtDecodeImageLocation.Size = new System.Drawing.Size(210, 20);
            this.txtDecodeImageLocation.TabIndex = 3;
            // 
            // btnDecodeLoadImage
            // 
            this.btnDecodeLoadImage.Location = new System.Drawing.Point(94, 45);
            this.btnDecodeLoadImage.Name = "btnDecodeLoadImage";
            this.btnDecodeLoadImage.Size = new System.Drawing.Size(122, 23);
            this.btnDecodeLoadImage.TabIndex = 0;
            this.btnDecodeLoadImage.Text = "Load Image";
            this.btnDecodeLoadImage.UseVisualStyleBackColor = true;
            this.btnDecodeLoadImage.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtDecodeKey
            // 
            this.txtDecodeKey.Location = new System.Drawing.Point(40, 74);
            this.txtDecodeKey.Name = "txtDecodeKey";
            this.txtDecodeKey.Size = new System.Drawing.Size(176, 20);
            this.txtDecodeKey.TabIndex = 1;
            this.txtDecodeKey.UseSystemPasswordChar = true;
            // 
            // btnDecodeSave
            // 
            this.btnDecodeSave.Location = new System.Drawing.Point(94, 100);
            this.btnDecodeSave.Name = "btnDecodeSave";
            this.btnDecodeSave.Size = new System.Drawing.Size(122, 23);
            this.btnDecodeSave.TabIndex = 2;
            this.btnDecodeSave.Text = "Decode && Save";
            this.btnDecodeSave.UseVisualStyleBackColor = true;
            this.btnDecodeSave.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.cbScaleImage);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ddlQuality);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtEncryptKeyAgain);
            this.groupBox2.Controls.Add(this.txtEncryptKey);
            this.groupBox2.Controls.Add(this.txtEncodeImage);
            this.groupBox2.Controls.Add(this.btnEncodeLoadImage);
            this.groupBox2.Controls.Add(this.txtEncodeFile);
            this.groupBox2.Controls.Add(this.btnEncodeSave);
            this.groupBox2.Controls.Add(this.btnEncodeLoadFile);
            this.groupBox2.Location = new System.Drawing.Point(7, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encoder";
            // 
            // cbScaleImage
            // 
            this.cbScaleImage.AutoSize = true;
            this.cbScaleImage.Location = new System.Drawing.Point(6, 227);
            this.cbScaleImage.Name = "cbScaleImage";
            this.cbScaleImage.Size = new System.Drawing.Size(167, 17);
            this.cbScaleImage.TabIndex = 1;
            this.cbScaleImage.Text = "Scale Image to Fit Hidden File";
            this.cbScaleImage.UseVisualStyleBackColor = true;
            this.cbScaleImage.CheckedChanged += new System.EventHandler(this.cbScaleImage_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Storage and Quality level:";
            // 
            // ddlQuality
            // 
            this.ddlQuality.FormattingEnabled = true;
            this.ddlQuality.Items.AddRange(new object[] {
            "High Quality - Low Storage",
            "Good Quality - 2x Storage",
            "OK Quality - 3x Storage",
            "Poor Quality - 4x Storage",
            "Bad Quality - 5x Storage",
            "Horrible Quality - 6x Storage",
            "Useless Quality - 7x Storage",
            "Destroyed Image - 8x Storage "});
            this.ddlQuality.Location = new System.Drawing.Point(6, 148);
            this.ddlQuality.Name = "ddlQuality";
            this.ddlQuality.Size = new System.Drawing.Size(210, 21);
            this.ddlQuality.TabIndex = 12;
            this.ddlQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Step 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Step 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Step 1:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Again:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Key:";
            // 
            // txtEncryptKeyAgain
            // 
            this.txtEncryptKeyAgain.Location = new System.Drawing.Point(49, 201);
            this.txtEncryptKeyAgain.Name = "txtEncryptKeyAgain";
            this.txtEncryptKeyAgain.Size = new System.Drawing.Size(167, 20);
            this.txtEncryptKeyAgain.TabIndex = 3;
            this.txtEncryptKeyAgain.UseSystemPasswordChar = true;
            // 
            // txtEncryptKey
            // 
            this.txtEncryptKey.Location = new System.Drawing.Point(49, 175);
            this.txtEncryptKey.Name = "txtEncryptKey";
            this.txtEncryptKey.Size = new System.Drawing.Size(167, 20);
            this.txtEncryptKey.TabIndex = 2;
            this.txtEncryptKey.UseSystemPasswordChar = true;
            // 
            // txtEncodeImage
            // 
            this.txtEncodeImage.Location = new System.Drawing.Point(6, 19);
            this.txtEncodeImage.Name = "txtEncodeImage";
            this.txtEncodeImage.ReadOnly = true;
            this.txtEncodeImage.Size = new System.Drawing.Size(210, 20);
            this.txtEncodeImage.TabIndex = 5;
            // 
            // btnEncodeLoadImage
            // 
            this.btnEncodeLoadImage.Location = new System.Drawing.Point(94, 45);
            this.btnEncodeLoadImage.Name = "btnEncodeLoadImage";
            this.btnEncodeLoadImage.Size = new System.Drawing.Size(122, 23);
            this.btnEncodeLoadImage.TabIndex = 0;
            this.btnEncodeLoadImage.Text = "Load Image";
            this.btnEncodeLoadImage.UseVisualStyleBackColor = true;
            this.btnEncodeLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEncodeFile
            // 
            this.txtEncodeFile.Location = new System.Drawing.Point(6, 74);
            this.txtEncodeFile.Name = "txtEncodeFile";
            this.txtEncodeFile.ReadOnly = true;
            this.txtEncodeFile.Size = new System.Drawing.Size(210, 20);
            this.txtEncodeFile.TabIndex = 6;
            // 
            // btnEncodeSave
            // 
            this.btnEncodeSave.Location = new System.Drawing.Point(94, 250);
            this.btnEncodeSave.Name = "btnEncodeSave";
            this.btnEncodeSave.Size = new System.Drawing.Size(122, 23);
            this.btnEncodeSave.TabIndex = 4;
            this.btnEncodeSave.Text = "Encode && Save";
            this.btnEncodeSave.UseVisualStyleBackColor = true;
            this.btnEncodeSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEncodeLoadFile
            // 
            this.btnEncodeLoadFile.Location = new System.Drawing.Point(94, 100);
            this.btnEncodeLoadFile.Name = "btnEncodeLoadFile";
            this.btnEncodeLoadFile.Size = new System.Drawing.Size(122, 23);
            this.btnEncodeLoadFile.TabIndex = 1;
            this.btnEncodeLoadFile.Text = "Load File";
            this.btnEncodeLoadFile.UseVisualStyleBackColor = true;
            this.btnEncodeLoadFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::_pix.Properties.Resources.banshee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files (bmp, jpg, gif, png)|*.bmp;*.jpg;*.gif;*.png";
            this.openFileDialog1.Title = "Load an image...";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "*.*";
            this.openFileDialog2.Filter = "All Files|*.*";
            this.openFileDialog2.Title = "Load a file...";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "encoded.bmp";
            this.saveFileDialog1.Filter = "Bitmap Files|*.bmp";
            this.saveFileDialog1.Title = "Save the image...";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "*.*";
            this.saveFileDialog2.Filter = "All Files|*.*";
            this.saveFileDialog2.Title = "Save file as...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(6, 277);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 526);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2pix | Stenography Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEncodeSave;
        private System.Windows.Forms.Button btnEncodeLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtEncodeImage;
        private System.Windows.Forms.Button btnEncodeLoadFile;
        private System.Windows.Forms.TextBox txtEncodeFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtDecodeImageLocation;
        private System.Windows.Forms.Button btnDecodeSave;
        private System.Windows.Forms.Button btnDecodeLoadImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecodeKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associateBitmapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEncryptKeyAgain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddlQuality;
        private System.Windows.Forms.CheckBox cbScaleImage;
        private System.Windows.Forms.Label lblStatus;
    }
}

