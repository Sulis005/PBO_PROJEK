using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_PROJEK.Views
{
    public partial class FrmRiwayatDonasi : Form
    {
        public FrmRiwayatDonasi()
        {
            InitializeComponent();
        }

        private void FrmRiwayatDonasi_Load(object sender, EventArgs e)
        {
            TambahCard("Baju Anak Laki-laki", "20/05/2024", "Menunggu");
            TambahCard("Buku Pelajaran SMP", "19/05/2024", "Diterima");
            TambahCard("Kipas Angin", "18/05/2024", "Ditolak");
            TambahCard("Meja Belajar", "17/05/2024", "Selesai");
        }

        private void TambahCard(string namaBarang, string tanggal, string status)
        {
            Panel card = new Panel();
            card.Width = 430;
            card.Height = 85;
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(10);

            PictureBox pic = new PictureBox();
            pic.Size = new Size(50, 50);
            pic.Location = new Point(10, 15);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblNama = new Label();
            lblNama.Text = namaBarang;
            lblNama.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblNama.Location = new Point(75, 15);
            lblNama.AutoSize = true;

            Label lblTanggal = new Label();
            lblTanggal.Text = tanggal;
            lblTanggal.Location = new Point(75, 40);
            lblTanggal.AutoSize = true;

            Label lblStatus = new Label();
            lblStatus.Text = status;
            lblStatus.AutoSize = false;
            lblStatus.Size = new Size(85, 25);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Location = new Point(315, 28);

            switch (status)
            {
                case "Menunggu":
                    lblStatus.BackColor = Color.Moccasin;
                    lblStatus.ForeColor = Color.DarkOrange;
                    break;

                case "Diterima":
                    lblStatus.BackColor = Color.Honeydew;
                    lblStatus.ForeColor = Color.Green;
                    break;

                case "Ditolak":
                    lblStatus.BackColor = Color.MistyRose;
                    lblStatus.ForeColor = Color.Red;
                    break;

                case "Selesai":
                    lblStatus.BackColor = Color.Lavender;
                    lblStatus.ForeColor = Color.Purple;
                    break;
            }

            Label lblArrow = new Label();
            lblArrow.Text = ">";
            lblArrow.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblArrow.Location = new Point(405, 28);
            lblArrow.AutoSize = true;

            card.Controls.Add(pic);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblTanggal);
            card.Controls.Add(lblStatus);
            card.Controls.Add(lblArrow);

            flpRiwayat.Controls.Add(card);
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}