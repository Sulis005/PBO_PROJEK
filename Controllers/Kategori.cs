using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBO_PROJEK.Models;

namespace PBO_PROJEK.Controllers
{
    public class KategoriController
    {
        private readonly KategoriService _kategoriService;
        public KategoriController()
        {
            _kategoriService = new KategoriService();
        }
        public List<Kategori> GetListKategori ()
        {
            return _kategoriService.GetListKategori();
        }
    }
}