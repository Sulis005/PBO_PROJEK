using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_PROJEK.Models;

namespace PBO_PROJEK.Models
{
    class Pengelola : User
    {
        public int id_pengelola { get; set; }
        public void GetPengelola()
        {
            Console.WriteLine("ID Pengelola: " + id_pengelola);
        }
    }
}
