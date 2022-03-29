namespace ZamanTutucu.WinFormApp
{
    partial class Ayarlar
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
            this.lbl_dosya_yolu = new System.Windows.Forms.Label();
            this.txt_dosya_yolu = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.btn_dosyasec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_ayarlari_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dosya_yolu
            // 
            this.lbl_dosya_yolu.AutoSize = true;
            this.lbl_dosya_yolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dosya_yolu.Location = new System.Drawing.Point(12, 9);
            this.lbl_dosya_yolu.Name = "lbl_dosya_yolu";
            this.lbl_dosya_yolu.Size = new System.Drawing.Size(126, 13);
            this.lbl_dosya_yolu.TabIndex = 0;
            this.lbl_dosya_yolu.Text = "Worklog Dosya Yolu:";
            // 
            // txt_dosya_yolu
            // 
            this.txt_dosya_yolu.Enabled = false;
            this.txt_dosya_yolu.Location = new System.Drawing.Point(12, 34);
            this.txt_dosya_yolu.Name = "txt_dosya_yolu";
            this.txt_dosya_yolu.Size = new System.Drawing.Size(683, 20);
            this.txt_dosya_yolu.TabIndex = 1;
            // 
            // btn_dosyasec
            // 
            this.btn_dosyasec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dosyasec.Location = new System.Drawing.Point(513, 5);
            this.btn_dosyasec.Name = "btn_dosyasec";
            this.btn_dosyasec.Size = new System.Drawing.Size(101, 23);
            this.btn_dosyasec.TabIndex = 2;
            this.btn_dosyasec.Text = "Dosya Seç";
            this.btn_dosyasec.UseVisualStyleBackColor = true;
            this.btn_dosyasec.Click += new System.EventHandler(this.btn_dosyasec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_ayarlari_kaydet
            // 
            this.btn_ayarlari_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayarlari_kaydet.Location = new System.Drawing.Point(620, 5);
            this.btn_ayarlari_kaydet.Name = "btn_ayarlari_kaydet";
            this.btn_ayarlari_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_ayarlari_kaydet.TabIndex = 3;
            this.btn_ayarlari_kaydet.Text = "Kaydet";
            this.btn_ayarlari_kaydet.UseVisualStyleBackColor = true;
            this.btn_ayarlari_kaydet.Click += new System.EventHandler(this.btn_ayarlari_kaydet_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 66);
            this.Controls.Add(this.btn_ayarlari_kaydet);
            this.Controls.Add(this.btn_dosyasec);
            this.Controls.Add(this.txt_dosya_yolu);
            this.Controls.Add(this.lbl_dosya_yolu);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dosya_yolu;
        private System.Windows.Forms.TextBox txt_dosya_yolu;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button btn_dosyasec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_ayarlari_kaydet;
    }
}