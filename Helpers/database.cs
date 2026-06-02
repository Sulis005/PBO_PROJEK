using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_PROJEK.Helpers
{
    public class Koneksi
    {
        public static NpgsqlConnection GetConnection()
        {
            string connString =
                "Host=localhost;" +
                "Port=5432;" +
                "Database=projek_pbo;" +
                "Username=postgres;" +
                "Password=Usfur.1975";

            return new NpgsqlConnection(connString);
        }
    }
}