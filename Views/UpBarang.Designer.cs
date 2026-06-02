namespace PBO_PROJEK.Views
{
    partial class UpBarang
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
            this.pilihkategoriBox = new System.Windows.Forms.ComboBox();
            this.namabarangBox = new System.Windows.Forms.TextBox();
            this.pilihkondisiBox = new System.Windows.Forms.ComboBox();
            this.deskripsiBox = new System.Windows.Forms.TextBox();
            this.fotobarangBox = new System.Windows.Forms.PictureBox();
            this.addbarangBtn = new System.Windows.Forms.Button();
            this.simpandonasiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotobarangBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pilihkategoriBox
            // 
            this.pilihkategoriBox.FormattingEnabled = true;
            this.pilihkategoriBox.Location = new System.Drawing.Point(96, 59);
            this.pilihkategoriBox.Name = "pilihkategoriBox";
            this.pilihkategoriBox.Size = new System.Drawing.Size(289, 21);
            this.pilihkategoriBox.TabIndex = 0;
            // 
            // namabarangBox
            // 
            this.namabarangBox.Location = new System.Drawing.Point(96, 101);
            this.namabarangBox.Name = "namabarangBox";
            this.namabarangBox.Size = new System.Drawing.Size(289, 20);
            this.namabarangBox.TabIndex = 1;
            // 
            // pilihkondisiBox
            // 
            this.pilihkondisiBox.FormattingEnabled = true;
            this.pilihkondisiBox.Location = new System.Drawing.Point(96, 145);
            this.pilihkondisiBox.Name = "pilihkondisiBox";
            this.pilihkondisiBox.Size = new System.Drawing.Size(289, 21);
            this.pilihkondisiBox.TabIndex = 2;
            // 
            // deskripsiBox
            // 
            this.deskripsiBox.Location = new System.Drawing.Point(96, 190);
            this.deskripsiBox.Name = "deskripsiBox";
            this.deskripsiBox.Size = new System.Drawing.Size(289, 20);
            this.deskripsiBox.TabIndex = 3;
            // 
            // fotobarangBox
            // 
            this.fotobarangBox.Location = new System.Drawing.Point(96, 252);
            this.fotobarangBox.Name = "fotobarangBox";
            this.fotobarangBox.Size = new System.Drawing.Size(289, 103);
            this.fotobarangBox.TabIndex = 4;
            this.fotobarangBox.TabStop = false;
            // 
            // addbarangBtn
            // 
            this.addbarangBtn.Location = new System.Drawing.Point(96, 378);
            this.addbarangBtn.Name = "addbarangBtn";
            this.addbarangBtn.Size = new System.Drawing.Size(289, 23);
            this.addbarangBtn.TabIndex = 6;
            this.addbarangBtn.Text = "button1";
            this.addbarangBtn.UseVisualStyleBackColor = true;
            // 
            // simpandonasiBtn
            // 
            this.simpandonasiBtn.Location = new System.Drawing.Point(96, 428);
            this.simpandonasiBtn.Name = "simpandonasiBtn";
            this.simpandonasiBtn.Size = new System.Drawing.Size(289, 23);
            this.simpandonasiBtn.TabIndex = 7;
            this.simpandonasiBtn.Text = "button2";
            this.simpandonasiBtn.UseVisualStyleBackColor = true;
            // 
            // UpBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.simpandonasiBtn);
            this.Controls.Add(this.addbarangBtn);
            this.Controls.Add(this.fotobarangBox);
            this.Controls.Add(this.deskripsiBox);
            this.Controls.Add(this.pilihkondisiBox);
            this.Controls.Add(this.namabarangBox);
            this.Controls.Add(this.pilihkategoriBox);
            this.Name = "UpBarang";
            this.Text = "UpBarang";
            ((System.ComponentModel.ISupportInitialize)(this.fotobarangBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pilihkategoriBox;
        private System.Windows.Forms.TextBox namabarangBox;
        private System.Windows.Forms.ComboBox pilihkondisiBox;
        private System.Windows.Forms.TextBox deskripsiBox;
        private System.Windows.Forms.PictureBox fotobarangBox;
        private System.Windows.Forms.Button addbarangBtn;
        private System.Windows.Forms.Button simpandonasiBtn;
    }
}