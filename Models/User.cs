using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJEK.Models
{
    class User
    {
        public int id_user { get; set; }
        public string nama { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public void GetUser()
        {
            Console.WriteLine("ID User: " + id_user);
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Password: " + password);
        }
        public void SetUser(int id_user, string nama, string email, string password)
        {
            this.id_user = id_user;
            this.nama = nama;
            this.email = email;
            this.password = password;
        }
    }

}
       
