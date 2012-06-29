namespace _pix
{
    partial class Decoder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decoder));
            this.button1 = new System.Windows.Forms.Button();
            this.txtDecodeImageLocation = new System.Windows.Forms.TextBox();
            this.btnDecodeLoadImage = new System.Windows.Forms.Button();
            this.txtDecodeKey = new System.Windows.Forms.TextBox();
            this.btnDecodeSave = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDecodeImageLocation
            // 
            this.txtDecodeImageLocation.Location = new System.Drawing.Point(6, 19);
            this.txtDecodeImageLocation.Name = "txtDecodeImageLocation";
            this.txtDecodeImageLocation.ReadOnly = true;
            this.txtDecodeImageLocation.Size = new System.Drawing.Size(286, 20);
            this.txtDecodeImageLocation.TabIndex = 0;
            // 
            // btnDecodeLoadImage
            // 
            this.btnDecodeLoadImage.Location = new System.Drawing.Point(298, 17);
            this.btnDecodeLoadImage.Name = "btnDecodeLoadImage";
            this.btnDecodeLoadImage.Size = new System.Drawing.Size(177, 23);
            this.btnDecodeLoadImage.TabIndex = 1;
            this.btnDecodeLoadImage.Text = "Load Image";
            this.btnDecodeLoadImage.UseVisualStyleBackColor = true;
            this.btnDecodeLoadImage.Click += new System.EventHandler(this.btnDecodeLoadImage_Click);
            // 
            // txtDecodeKey
            // 
            this.txtDecodeKey.Location = new System.Drawing.Point(6, 19);
            this.txtDecodeKey.Name = "txtDecodeKey";
            this.txtDecodeKey.Size = new System.Drawing.Size(469, 20);
            this.txtDecodeKey.TabIndex = 0;
            this.txtDecodeKey.UseSystemPasswordChar = true;
            // 
            // btnDecodeSave
            // 
            this.btnDecodeSave.Location = new System.Drawing.Point(310, 138);
            this.btnDecodeSave.Name = "btnDecodeSave";
            this.btnDecodeSave.Size = new System.Drawing.Size(177, 23);
            this.btnDecodeSave.TabIndex = 0;
            this.btnDecodeSave.Text = "Decode && Save";
            this.btnDecodeSave.UseVisualStyleBackColor = true;
            this.btnDecodeSave.Click += new System.EventHandler(this.btnDecodeSave_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtDecodeImageLocation);
            this.groupBox8.Controls.Add(this.btnDecodeLoadImage);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(481, 50);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Select the image that contains a file";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDecodeKey);
            this.groupBox9.Location = new System.Drawing.Point(12, 68);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(481, 50);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Enter the decryption key for this image";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "encoded.bmp";
            this.openFileDialog2.Filter = "Bitmap Images|*.bmp";
            this.openFileDialog2.Title = "Load a file...";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileName = "*.*";
            this.saveFileDialog2.Filter = "All Files|*.*";
            this.saveFileDialog2.Title = "Save file as...";
            // 
            // Decoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 173);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.btnDecodeSave);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Decoder";
            this.Text = "2pix | Extractor";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDecodeImageLocation;
        private System.Windows.Forms.Button btnDecodeLoadImage;
        private System.Windows.Forms.TextBox txtDecodeKey;
        private System.Windows.Forms.Button btnDecodeSave;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}