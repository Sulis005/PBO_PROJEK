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
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();
        }

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            lblNama.Text = "Anggun Cantika";
            lblRole.Text = "Pengelola";

            txtEmail.Text = "pengelola@gmail.com";
            txtTelepon.Text = "081212879916";
            txtAlamat.Text = "Jl. Semeru Gg. Maya";
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

