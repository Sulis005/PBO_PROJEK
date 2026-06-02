using System.Drawing;
using System.Windows.Forms;

namespace PBO_PROJEK.Views
{
    partial class FrmRiwayatDonasi
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblJudul;
        private Button btnKembali;

        private Button btnSemua;
        private Button btnMenunggu;
        private Button btnDiterima;
        private Button btnDitolak;
        private Button btnSelesai;

        private FlowLayoutPanel flpRiwayat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new Label();
            this.btnKembali = new Button();

            this.btnSemua = new Button();
            this.btnMenunggu = new Button();
            this.btnDiterima = new Button();
            this.btnDitolak = new Button();
            this.btnSelesai = new Button();

            this.flpRiwayat = new FlowLayoutPanel();

            this.SuspendLayout();

            // btnKembali
            this.btnKembali.Location = new Point(15, 15);
            this.btnKembali.Size = new Size(40, 30);
            this.btnKembali.Text = "<";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);

            // Judul
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.lblJudul.Location = new Point(175, 18);
            this.lblJudul.Text = "Riwayat Donasi";

            // Filter
            this.btnSemua.Location = new Point(20, 70);
            this.btnSemua.Size = new Size(70, 30);
            this.btnSemua.Text = "Semua";

            this.btnMenunggu.Location = new Point(95, 70);
            this.btnMenunggu.Size = new Size(90, 30);
            this.btnMenunggu.Text = "Menunggu";

            this.btnDiterima.Location = new Point(190, 70);
            this.btnDiterima.Size = new Size(80, 30);
            this.btnDiterima.Text = "Diterima";

            this.btnDitolak.Location = new Point(275, 70);
            this.btnDitolak.Size = new Size(70, 30);
            this.btnDitolak.Text = "Ditolak";

            this.btnSelesai.Location = new Point(350, 70);
            this.btnSelesai.Size = new Size(70, 30);
            this.btnSelesai.Text = "Selesai";

            // FlowLayoutPanel
            this.flpRiwayat.Location = new Point(20, 120);
            this.flpRiwayat.Size = new Size(450, 420);
            this.flpRiwayat.AutoScroll = true;
            this.flpRiwayat.FlowDirection = FlowDirection.TopDown;
            this.flpRiwayat.WrapContents = false;
            this.flpRiwayat.BackColor = Color.WhiteSmoke;

            // Form
            this.ClientSize = new Size(500, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Riwayat Donasi";

            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.lblJudul);

            this.Controls.Add(this.btnSemua);
            this.Controls.Add(this.btnMenunggu);
            this.Controls.Add(this.btnDiterima);
            this.Controls.Add(this.btnDitolak);
            this.Controls.Add(this.btnSelesai);

            this.Controls.Add(this.flpRiwayat);

            this.Load += new System.EventHandler(this.FrmRiwayatDonasi_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}