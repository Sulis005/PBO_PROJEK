using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_PROJEK.Models
{
    class Donasi
    {
        public int id_donasi { get; set; }
        public string nama_barang { get; set; }
        public byte[] foto_barang { get; set; }
        public string deskripsi_barang { get; set; }

        public string kondisi_barang { get; set; }
        public DateTime tanggal_donasi { get; set; }
        public string status_donasi { get; set; }

    }
}
