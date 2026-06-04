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
using PBO_PROJEK.Models;

namespace PBO_PROJEK.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private bool passwordVisible = false;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            rbDonatur.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("Email tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoginUser();
        }

        private void LoginUser()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=donasi"))
            {
                conn.Open();

                rbDonatur.Checked = true;
                string tabel =
                    rbDonatur.Checked ?
                    "Donatur" : "Admin";

                string queryDonatur =
                   @"SELECT * FROM donatur
                    WHERE email=@Email
                    AND password=@Password";

                NpgsqlCommand cmd = new NpgsqlCommand(queryDonatur, conn);

                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();

                    //FrmDashboardDonatur frm = new FrmDashboardDonatur();

                    //frm.Show();

                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Email atau Password salah");
                }

                dr.Close();

                string queryPengelola =
                   @"SELECT * FROM Pengelola
                    WHERE email=@Email
                    AND password=@Password";

                cmd = new NpgsqlCommand(queryPengelola, conn);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    //FrmDashboardAdmin frm = new FrmDashboardAdmin();
                    //frm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Email atau password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void lblDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }

        private void lblLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FrmLupaPassword frmLupaPassword = new FrmLupaPassword();
            //frmLupaPassword.ShowDialog();
        }
    }
}