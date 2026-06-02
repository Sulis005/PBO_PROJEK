using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJEK.Views
{
    partial class FrmProfil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBoxProfil = new System.Windows.Forms.PictureBox();

            this.lblNama = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();

            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();

            this.lblTeleponTitle = new System.Windows.Forms.Label();
            this.lblTeleponValue = new System.Windows.Forms.Label();

            this.lblAlamatTitle = new System.Windows.Forms.Label();
            this.lblAlamatValue = new System.Windows.Forms.Label();

            this.btnKeluar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).BeginInit();
            this.SuspendLayout();

            // pictureBoxProfil
            this.pictureBoxProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfil.Location = new System.Drawing.Point(160, 30);
            this.pictureBoxProfil.Name = "pictureBoxProfil";
            this.pictureBoxProfil.Size = new System.Drawing.Size(180, 120);
            this.pictureBoxProfil.TabIndex = 0;
            this.pictureBoxProfil.TabStop = false;

            // lblNama
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblNama.Location = new System.Drawing.Point(140, 170);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(0, 32);

            // lblRole
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.Location = new System.Drawing.Point(200, 210);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(0, 23);

            // Email Title
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmailTitle.Location = new System.Drawing.Point(50, 280);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Text = "Email";

            // Email Value
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmailValue.Location = new System.Drawing.Point(50, 310);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(0, 20);

            // Telepon Title
            this.lblTeleponTitle.AutoSize = true;
            this.lblTeleponTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTeleponTitle.Location = new System.Drawing.Point(50, 360);
            this.lblTeleponTitle.Name = "lblTeleponTitle";
            this.lblTeleponTitle.Text = "No Telepon";

            // Telepon Value
            this.lblTeleponValue.AutoSize = true;
            this.lblTeleponValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTeleponValue.Location = new System.Drawing.Point(50, 390);
            this.lblTeleponValue.Name = "lblTeleponValue";
            this.lblTeleponValue.Size = new System.Drawing.Size(0, 20);

            // Alamat Title
            this.lblAlamatTitle.AutoSize = true;
            this.lblAlamatTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAlamatTitle.Location = new System.Drawing.Point(50, 440);
            this.lblAlamatTitle.Name = "lblAlamatTitle";
            this.lblAlamatTitle.Text = "Alamat";

            // Alamat Value
            this.lblAlamatValue.AutoSize = true;
            this.lblAlamatValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAlamatValue.Location = new System.Drawing.Point(50, 470);
            this.lblAlamatValue.Name = "lblAlamatValue";
            this.lblAlamatValue.Size = new System.Drawing.Size(0, 20);

            // btnKeluar
            this.btnKeluar.BackColor = System.Drawing.Color.Red;
            this.btnKeluar.ForeColor = System.Drawing.Color.White;
            this.btnKeluar.Location = new System.Drawing.Point(350, 520);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(100, 40);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);

            // FrmProfil
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);

            this.Controls.Add(this.pictureBoxProfil);

            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblRole);

            this.Controls.Add(this.lblEmailTitle);
            this.Controls.Add(this.lblEmailValue);

            this.Controls.Add(this.lblTeleponTitle);
            this.Controls.Add(this.lblTeleponValue);

            this.Controls.Add(this.lblAlamatTitle);
            this.Controls.Add(this.lblAlamatValue);

            this.Controls.Add(this.btnKeluar);

            this.Name = "FrmProfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profil";

            this.Load += new System.EventHandler(this.FrmProfil_Load);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfil;

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblRole;

        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmailValue;

        private System.Windows.Forms.Label lblTeleponTitle;
        private System.Windows.Forms.Label lblTeleponValue;

        private System.Windows.Forms.Label lblAlamatTitle;
        private System.Windows.Forms.Label lblAlamatValue;

        private System.Windows.Forms.Button btnKeluar;
    }
}