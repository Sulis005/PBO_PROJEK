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
    public partial class FrmVerifikasi : Form
    {
        public int idBarang;

        public FrmVerifikasi(int id)
        {
            InitializeComponent();
            idBarang = id;
        }
        private void LoadDetailBarang()
        {
            try
            {
                using (NpgsqlConnection conn =
                    Koneksi.GetConnection())
                {
                    conn.Open();

                    string query =
                    @"SELECT
                b.*,
                k.nama_kategori
              FROM barang b
              JOIN kategori k
              ON b.id_kategori =
                 k.id_kategori
              WHERE b.id_barang=@id";

                    NpgsqlCommand cmd =
                        new NpgsqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@id",
                        idBarang);

                    NpgsqlDataReader dr =
                        cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNamaBarang.Text =
                            dr["nama_barang"].ToString();

                        lblKategori.Text =
                            dr["nama_kategori"].ToString();

                        lblKondisi.Text =
                            dr["kondisi"].ToString();

                        txtDeskripsi.Text =
                            dr["deskripsi"].ToString();

                        txtLokasi.Text =
                            dr["lokasi"].ToString();

                        lblTanggal.Text =
                            Convert.ToDateTime(
                            dr["tanggal_upload"])
                            .ToString("dd/MM/yyyy");

                        string foto =
                            dr["foto"].ToString();

                        if (File.Exists(foto))
                        {
                            picBarang.Image =
                                Image.FromFile(foto);

                            picBarang.SizeMode =
                                PictureBoxSizeMode.Zoom;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
