namespace _pix
{
    partial class Encoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encoder));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEncodeImage = new System.Windows.Forms.TextBox();
            this.btnEncodeLoadImage = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbScaleImage = new System.Windows.Forms.CheckBox();
            this.ddlQuality = new System.Windows.Forms.ComboBox();
            this.txtEncryptKeyAgain = new System.Windows.Forms.TextBox();
            this.txtEncryptKey = new System.Windows.Forms.TextBox();
            this.txtEncodeFile = new System.Windows.Forms.TextBox();
            this.btnEncodeSave = new System.Windows.Forms.Button();
            this.btnEncodeLoadFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelStatus = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Controls.Add(this.txtEncodeImage);
            this.groupBox2.Controls.Add(this.btnEncodeLoadImage);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 67);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select an image to put stuff in";
            // 
            // txtEncodeImage
            // 
            this.txtEncodeImage.Location = new System.Drawing.Point(6, 19);
            this.txtEncodeImage.Name = "txtEncodeImage";
            this.txtEncodeImage.ReadOnly = true;
            this.txtEncodeImage.Size = new System.Drawing.Size(286, 20);
            this.txtEncodeImage.TabIndex = 0;
            // 
            // btnEncodeLoadImage
            // 
            this.btnEncodeLoadImage.Location = new System.Drawing.Point(298, 17);
            this.btnEncodeLoadImage.Name = "btnEncodeLoadImage";
            this.btnEncodeLoadImage.Size = new System.Drawing.Size(177, 23);
            this.btnEncodeLoadImage.TabIndex = 1;
            this.btnEncodeLoadImage.Text = "Load Image";
            this.btnEncodeLoadImage.UseVisualStyleBackColor = true;
            this.btnEncodeLoadImage.Click += new System.EventHandler(this.btnEncodeLoadImage_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(298, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 1;
            // 
            // cbScaleImage
            // 
            this.cbScaleImage.AutoSize = true;
            this.cbScaleImage.Location = new System.Drawing.Point(6, 19);
            this.cbScaleImage.Name = "cbScaleImage";
            this.cbScaleImage.Size = new System.Drawing.Size(167, 17);
            this.cbScaleImage.TabIndex = 0;
            this.cbScaleImage.Text = "Scale Image to Fit Hidden File";
            this.cbScaleImage.UseVisualStyleBackColor = true;
            this.cbScaleImage.CheckedChanged += new System.EventHandler(this.cbScaleImage_CheckedChanged);
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
            this.ddlQuality.Location = new System.Drawing.Point(6, 19);
            this.ddlQuality.Name = "ddlQuality";
            this.ddlQuality.Size = new System.Drawing.Size(286, 21);
            this.ddlQuality.TabIndex = 0;
            this.ddlQuality.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtEncryptKeyAgain
            // 
            this.txtEncryptKeyAgain.Location = new System.Drawing.Point(6, 19);
            this.txtEncryptKeyAgain.Name = "txtEncryptKeyAgain";
            this.txtEncryptKeyAgain.Size = new System.Drawing.Size(218, 20);
            this.txtEncryptKeyAgain.TabIndex = 0;
            this.txtEncryptKeyAgain.UseSystemPasswordChar = true;
            this.txtEncryptKeyAgain.TextChanged += new System.EventHandler(this.txtEncryptKeyAgain_TextChanged);
            // 
            // txtEncryptKey
            // 
            this.txtEncryptKey.Location = new System.Drawing.Point(6, 19);
            this.txtEncryptKey.Name = "txtEncryptKey";
            this.txtEncryptKey.Size = new System.Drawing.Size(223, 20);
            this.txtEncryptKey.TabIndex = 0;
            this.txtEncryptKey.UseSystemPasswordChar = true;
            this.txtEncryptKey.TextChanged += new System.EventHandler(this.txtEncryptKey_TextChanged);
            // 
            // txtEncodeFile
            // 
            this.txtEncodeFile.Location = new System.Drawing.Point(6, 19);
            this.txtEncodeFile.Name = "txtEncodeFile";
            this.txtEncodeFile.ReadOnly = true;
            this.txtEncodeFile.Size = new System.Drawing.Size(286, 20);
            this.txtEncodeFile.TabIndex = 0;
            // 
            // btnEncodeSave
            // 
            this.btnEncodeSave.Enabled = false;
            this.btnEncodeSave.Location = new System.Drawing.Point(310, 322);
            this.btnEncodeSave.Name = "btnEncodeSave";
            this.btnEncodeSave.Size = new System.Drawing.Size(177, 23);
            this.btnEncodeSave.TabIndex = 0;
            this.btnEncodeSave.Text = "Encode && Save";
            this.btnEncodeSave.UseVisualStyleBackColor = true;
            this.btnEncodeSave.Click += new System.EventHandler(this.btnEncodeSave_Click);
            // 
            // btnEncodeLoadFile
            // 
            this.btnEncodeLoadFile.Location = new System.Drawing.Point(298, 17);
            this.btnEncodeLoadFile.Name = "btnEncodeLoadFile";
            this.btnEncodeLoadFile.Size = new System.Drawing.Size(177, 23);
            this.btnEncodeLoadFile.TabIndex = 1;
            this.btnEncodeLoadFile.Text = "Load File";
            this.btnEncodeLoadFile.UseVisualStyleBackColor = true;
            this.btnEncodeLoadFile.Click += new System.EventHandler(this.btnEncodeLoadFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEncodeLoadFile);
            this.groupBox1.Controls.Add(this.txtEncodeFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a file to put into the image";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.ddlQuality);
            this.groupBox3.Location = new System.Drawing.Point(12, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 50);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select an image quality";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtEncryptKey);
            this.groupBox4.Location = new System.Drawing.Point(12, 197);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 50);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enter an encryption key";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbScaleImage);
            this.groupBox5.Location = new System.Drawing.Point(12, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(481, 50);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Extra encoding options";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtEncryptKeyAgain);
            this.groupBox6.Location = new System.Drawing.Point(258, 197);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(235, 50);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Repeat encryption key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files (bmp, jpg, gif, png)|*.bmp;*.jpg;*.gif;*.png";
            this.openFileDialog1.Title = "Load an image...";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.Blue;
            this.labelStatus.Location = new System.Drawing.Point(298, 45);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(13, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "?";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Storage capacity of image on selected quality level:";
            // 
            // Encoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 357);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnEncodeSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encoder";
            this.Text = "2pix | Encoder";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbScaleImage;
        private System.Windows.Forms.ComboBox ddlQuality;
        private System.Windows.Forms.TextBox txtEncryptKeyAgain;
        private System.Windows.Forms.TextBox txtEncryptKey;
        private System.Windows.Forms.TextBox txtEncodeImage;
        private System.Windows.Forms.Button btnEncodeLoadImage;
        private System.Windows.Forms.TextBox txtEncodeFile;
        private System.Windows.Forms.Button btnEncodeSave;
        private System.Windows.Forms.Button btnEncodeLoadFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}