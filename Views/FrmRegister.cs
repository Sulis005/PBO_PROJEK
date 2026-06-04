using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PBO_PROJEK.Views
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (ValidasiInput())
            {
                SimpanData();
            }
        }
        private bool ValidasiInput()
        {
            if (txtNama.Text.Trim() == "")
            {
                MessageBox.Show("Nama lengkap harus diisi.");
                txtNama.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email harus diisi.");
                txtEmail.Focus();
                return false;
            }
            if (txtNoHP.Text.Trim() == "")
            {
                MessageBox.Show("No HP harus diisi.");
                txtNoHP.Focus();
                return false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password harus diisi.");
                txtPassword.Focus();
                return false;
            }
            if (txtKonfirmasi.Text.Trim() == "")
            {
                MessageBox.Show("Konfirmasi password harus diisi.");
                txtKonfirmasi.Focus();
                return false;
            }
            if (txtPassword.Text != txtKonfirmasi.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok.");
                txtKonfirmasi.Focus();
                return false;
            }
            return true;
        }
        private void SimpanData()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("YourConnectionString"))
                {
                    conn.Open();
                    string cekEmail =
                        @"SELECT COUNT(*) FROM Donatur WHERE email = @email";

                    NpgsqlCommand cekCmd = new NpgsqlCommand(cekEmail, conn);
                    cekCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    int jumlah = Convert.ToInt32(cekCmd.ExecuteScalar());
                    if (jumlah > 0)
                    {
                        MessageBox.Show("Email sudah terdaftar. Silakan gunakan email lain.");
                        return;
                    }

                    string query =
                        @"INSERT INTO Donatur (nama, email, password, nomor_hp, alamat) 
                          VALUES (@nama, @email, @password, @nomor_hp, @alamat)";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@nomor_hp", txtNoHP.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.ExecuteNonQuery(); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
