using PBO_PROJEK.Views

namespace PBO_PROJEK.Controllers
{
    public class Auth
    {
        public bool Login(string email, string password)
        {
            if (email == "pengelola@gmail.com" && password == "admin123")
            {
                MessageBox.Show(
                    "Login Berhasil sebagai Pengelola",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                V_DaftarBarangMasuk dashboard =
                    new V_DaftarBarangMasuk();

                dashboard.Show();

                return true;
            }

            if (email == "donaturr@gmail.com" && password == "donatur123")
            {
                MessageBox.Show(
                   "Login berhasil sebagai Donatur",
                   "Sukses",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                V_FormInputDonasi formDonasi =
                    new V_FormInputDonasi();

                formDonasi.Show();

                return true;
            }

            MessageBox.Show(
                "Email atau Password salah",
                "Login Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return false;
        }

        public bool Register(
            string nama,
            string email,
            string password,
            string konfirmasiPassword)
        {
            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Semua data harus diisi",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (password != konfirmasiPassword)
            {
                MessageBox.Show(
                    "Konfirmasi password tidak sesuai",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            MessageBox.Show(
                "Registrasi berhasil",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        public void Logout(Form currentForm)
        {
            DialogResult result =
                MessageBox.Show(
                    "Apakah Anda yakin ingin logout?",
                    "Konfirmasi Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                V_Login loginForm = new V_Login();

                loginForm.Show();

                currentForm.Close();

                MessageBox.Show(
                    "Logout berhasil",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
        }
    }
}
