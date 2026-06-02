namespace PBO_PROJEK.Views
{
    partial class FrmVerifikasi
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
            this.reject = new System.Windows.Forms.Button();
            this.approve = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catatan = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.namabarang = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.Label();
            this.kondisi = new System.Windows.Forms.Label();
            this.isicatatan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.donatur = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.deskripsi = new System.Windows.Forms.Label();
            this.lokasi = new System.Windows.Forms.Label();
            this.isidonatur = new System.Windows.Forms.Label();
            this.isikategori = new System.Windows.Forms.Label();
            this.isikondisi = new System.Windows.Forms.Label();
            this.isitanggal = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.isilokasi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reject
            // 
            this.reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reject.Location = new System.Drawing.Point(238, 483);
            this.reject.Name = "reject";
            this.reject.Size = new System.Drawing.Size(215, 56);
            this.reject.TabIndex = 0;
            this.reject.Text = "Reject(Tolak)";
            this.reject.UseVisualStyleBackColor = false;
            // 
            // approve
            // 
            this.approve.BackColor = System.Drawing.Color.DarkGreen;
            this.approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.approve.Location = new System.Drawing.Point(23, 484);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(213, 52);
            this.approve.TabIndex = 1;
            this.approve.Text = "Approve(Terima)";
            this.approve.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 399);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 78);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(173, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 87);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // catatan
            // 
            this.catatan.AutoSize = true;
            this.catatan.Location = new System.Drawing.Point(30, 375);
            this.catatan.Name = "catatan";
            this.catatan.Size = new System.Drawing.Size(139, 20);
            this.catatan.TabIndex = 4;
            this.catatan.Text = "Catatan (opsional)";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(54, 129);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(368, 243);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // namabarang
            // 
            this.namabarang.AutoSize = true;
            this.namabarang.Location = new System.Drawing.Point(63, 142);
            this.namabarang.Name = "namabarang";
            this.namabarang.Size = new System.Drawing.Size(111, 20);
            this.namabarang.TabIndex = 6;
            this.namabarang.Text = "Nama Barang ";
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Location = new System.Drawing.Point(63, 209);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(68, 20);
            this.kategori.TabIndex = 7;
            this.kategori.Text = "Kategori";
            // 
            // kondisi
            // 
            this.kondisi.AutoSize = true;
            this.kondisi.Location = new System.Drawing.Point(63, 241);
            this.kondisi.Name = "kondisi";
            this.kondisi.Size = new System.Drawing.Size(60, 20);
            this.kondisi.TabIndex = 8;
            this.kondisi.Text = "Kondisi";
            this.kondisi.Click += new System.EventHandler(this.kondisi_Click);
            // 
            // isicatatan
            // 
            this.isicatatan.AutoSize = true;
            this.isicatatan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isicatatan.Font = new System.Drawing.Font("Yu Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isicatatan.Location = new System.Drawing.Point(63, 404);
            this.isicatatan.Name = "isicatatan";
            this.isicatatan.Size = new System.Drawing.Size(169, 21);
            this.isicatatan.TabIndex = 9;
            this.isicatatan.Text = "Tulis catatan jika ada...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Baju";
            // 
            // donatur
            // 
            this.donatur.AutoSize = true;
            this.donatur.Location = new System.Drawing.Point(63, 176);
            this.donatur.Name = "donatur";
            this.donatur.Size = new System.Drawing.Size(67, 20);
            this.donatur.TabIndex = 14;
            this.donatur.Text = "Donatur";
            this.donatur.Click += new System.EventHandler(this.label3_Click);
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Location = new System.Drawing.Point(63, 275);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(121, 20);
            this.tanggal.TabIndex = 15;
            this.tanggal.Text = "Tanggal Upload";
            // 
            // deskripsi
            // 
            this.deskripsi.AutoSize = true;
            this.deskripsi.Location = new System.Drawing.Point(63, 308);
            this.deskripsi.Name = "deskripsi";
            this.deskripsi.Size = new System.Drawing.Size(74, 20);
            this.deskripsi.TabIndex = 16;
            this.deskripsi.Text = "Deskripsi";
            // 
            // lokasi
            // 
            this.lokasi.AutoSize = true;
            this.lokasi.Location = new System.Drawing.Point(63, 340);
            this.lokasi.Name = "lokasi";
            this.lokasi.Size = new System.Drawing.Size(55, 20);
            this.lokasi.TabIndex = 17;
            this.lokasi.Text = "Lokasi";
            // 
            // isidonatur
            // 
            this.isidonatur.AutoSize = true;
            this.isidonatur.Location = new System.Drawing.Point(208, 176);
            this.isidonatur.Name = "isidonatur";
            this.isidonatur.Size = new System.Drawing.Size(51, 20);
            this.isidonatur.TabIndex = 18;
            this.isidonatur.Text = "Akbat";
            // 
            // isikategori
            // 
            this.isikategori.AutoSize = true;
            this.isikategori.Location = new System.Drawing.Point(208, 209);
            this.isikategori.Name = "isikategori";
            this.isikategori.Size = new System.Drawing.Size(66, 20);
            this.isikategori.TabIndex = 19;
            this.isikategori.Text = "Pakaian";
            // 
            // isikondisi
            // 
            this.isikondisi.AutoSize = true;
            this.isikondisi.Location = new System.Drawing.Point(208, 241);
            this.isikondisi.Name = "isikondisi";
            this.isikondisi.Size = new System.Drawing.Size(40, 20);
            this.isikondisi.TabIndex = 20;
            this.isikondisi.Text = "Baik";
            // 
            // isitanggal
            // 
            this.isitanggal.AutoSize = true;
            this.isitanggal.Location = new System.Drawing.Point(208, 275);
            this.isitanggal.Name = "isitanggal";
            this.isitanggal.Size = new System.Drawing.Size(89, 20);
            this.isitanggal.TabIndex = 21;
            this.isitanggal.Text = "20/06/2026";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(208, 305);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(183, 31);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "Barang masih layak";
            // 
            // isilokasi
            // 
            this.isilokasi.Location = new System.Drawing.Point(208, 338);
            this.isilokasi.Name = "isilokasi";
            this.isilokasi.Size = new System.Drawing.Size(183, 26);
            this.isilokasi.TabIndex = 23;
            this.isilokasi.Text = "Jl. Merdeka No.11";
            // 
            // FrmVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.isilokasi);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.isitanggal);
            this.Controls.Add(this.isikondisi);
            this.Controls.Add(this.isikategori);
            this.Controls.Add(this.isidonatur);
            this.Controls.Add(this.lokasi);
            this.Controls.Add(this.deskripsi);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.donatur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isicatatan);
            this.Controls.Add(this.kondisi);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.namabarang);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.catatan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.reject);
            this.Name = "FrmVerifikasi";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reject;
        private System.Windows.Forms.Button approve;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label catatan;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label namabarang;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.Label kondisi;
        private System.Windows.Forms.Label isicatatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label donatur;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label deskripsi;
        private System.Windows.Forms.Label lokasi;
        private System.Windows.Forms.Label isidonatur;
        private System.Windows.Forms.Label isikategori;
        private System.Windows.Forms.Label isikondisi;
        private System.Windows.Forms.Label isitanggal;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox isilokasi;
    }
}