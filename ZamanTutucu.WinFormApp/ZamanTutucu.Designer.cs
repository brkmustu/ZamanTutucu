namespace ZamanTutucu.WinFormApp
{
    partial class ZamanTutucu
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
            this.components = new System.ComponentModel.Container();
            this.sayac_lbl = new System.Windows.Forms.Label();
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.eksilt = new System.Windows.Forms.Button();
            this.arttir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.txt_jirano = new System.Windows.Forms.TextBox();
            this.rtxt_aciklama = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.btn_tumloglar = new System.Windows.Forms.Button();
            this.JiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayac_lbl
            // 
            this.sayac_lbl.AutoSize = true;
            this.sayac_lbl.Font = new System.Drawing.Font("Arial", 15F);
            this.sayac_lbl.Location = new System.Drawing.Point(12, 95);
            this.sayac_lbl.Name = "sayac_lbl";
            this.sayac_lbl.Size = new System.Drawing.Size(65, 23);
            this.sayac_lbl.TabIndex = 0;
            this.sayac_lbl.Text = "Sayac";
            // 
            // baslat
            // 
            this.baslat.BackColor = System.Drawing.Color.SteelBlue;
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baslat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.baslat.Location = new System.Drawing.Point(12, 12);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(75, 23);
            this.baslat.TabIndex = 1;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            this.durdur.BackColor = System.Drawing.Color.Brown;
            this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durdur.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.durdur.Location = new System.Drawing.Point(165, 12);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(75, 23);
            this.durdur.TabIndex = 2;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // eksilt
            // 
            this.eksilt.Location = new System.Drawing.Point(93, 12);
            this.eksilt.Name = "eksilt";
            this.eksilt.Size = new System.Drawing.Size(30, 23);
            this.eksilt.TabIndex = 3;
            this.eksilt.Text = "-";
            this.eksilt.UseVisualStyleBackColor = true;
            this.eksilt.Click += new System.EventHandler(this.eksilt_Click);
            // 
            // arttir
            // 
            this.arttir.Location = new System.Drawing.Point(129, 12);
            this.arttir.Name = "arttir";
            this.arttir.Size = new System.Drawing.Size(30, 23);
            this.arttir.TabIndex = 4;
            this.arttir.Text = "+";
            this.arttir.UseVisualStyleBackColor = true;
            this.arttir.Click += new System.EventHandler(this.arttir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JiraNo,
            this.Aciklama,
            this.Sure});
            this.dataGridView1.Location = new System.Drawing.Point(12, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(490, 518);
            this.dataGridView1.TabIndex = 5;
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.Teal;
            this.ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ekle.Location = new System.Drawing.Point(246, 12);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 6;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // txt_jirano
            // 
            this.txt_jirano.Location = new System.Drawing.Point(178, 41);
            this.txt_jirano.Name = "txt_jirano";
            this.txt_jirano.Size = new System.Drawing.Size(324, 20);
            this.txt_jirano.TabIndex = 7;
            // 
            // rtxt_aciklama
            // 
            this.rtxt_aciklama.Location = new System.Drawing.Point(178, 64);
            this.rtxt_aciklama.Name = "rtxt_aciklama";
            this.rtxt_aciklama.Size = new System.Drawing.Size(324, 54);
            this.rtxt_aciklama.TabIndex = 8;
            this.rtxt_aciklama.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jira No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Açıklama:";
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ayarlar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ayarlar.Location = new System.Drawing.Point(427, 12);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(75, 23);
            this.btn_ayarlar.TabIndex = 12;
            this.btn_ayarlar.Text = "Ayarlar";
            this.btn_ayarlar.UseVisualStyleBackColor = false;
            this.btn_ayarlar.Click += new System.EventHandler(this.btn_ayarlar_Click);
            // 
            // btn_tumloglar
            // 
            this.btn_tumloglar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_tumloglar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tumloglar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_tumloglar.Location = new System.Drawing.Point(327, 12);
            this.btn_tumloglar.Name = "btn_tumloglar";
            this.btn_tumloglar.Size = new System.Drawing.Size(94, 23);
            this.btn_tumloglar.TabIndex = 13;
            this.btn_tumloglar.Text = "Tüm Loglar";
            this.btn_tumloglar.UseVisualStyleBackColor = false;
            this.btn_tumloglar.Click += new System.EventHandler(this.btn_tumloglar_Click);
            // 
            // JiraNo
            // 
            this.JiraNo.HeaderText = "JiraNo";
            this.JiraNo.Name = "JiraNo";
            this.JiraNo.ReadOnly = true;
            this.JiraNo.Width = 75;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Açıklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 270;
            // 
            // Sure
            // 
            this.Sure.HeaderText = "Süre";
            this.Sure.Name = "Sure";
            this.Sure.ReadOnly = true;
            this.Sure.Width = 75;
            // 
            // ZamanTutucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 654);
            this.Controls.Add(this.btn_tumloglar);
            this.Controls.Add(this.btn_ayarlar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxt_aciklama);
            this.Controls.Add(this.txt_jirano);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.arttir);
            this.Controls.Add(this.eksilt);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.sayac_lbl);
            this.Name = "ZamanTutucu";
            this.Text = "Zaman Tutucu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayac_lbl;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button eksilt;
        private System.Windows.Forms.Button arttir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox txt_jirano;
        private System.Windows.Forms.RichTextBox rtxt_aciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ayarlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn JiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sure;
        private System.Windows.Forms.Button btn_tumloglar;
    }
}

