using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P7.Models
{
    internal class DashboardModel
    {
        public decimal TotalPemasukan { get; private set; }
        public decimal TotalPengeluaran { get; private set; }
        public decimal SisaSaldo => TotalPemasukan - TotalPengeluaran;

        public void LoadData()
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();

                var queryPemasukan = "SELECT SUM(jumlah) FROM transaksi WHERE tipe = 'Pemasukan'";
                var queryPengeluaran = "SELECT SUM(jumlah) FROM transaksi WHERE tipe = 'Pengeluaran'";

                MySqlCommand cmd = new MySqlCommand(queryPemasukan, conn);
                object pemasukan = cmd.ExecuteScalar();
                TotalPemasukan = pemasukan != DBNull.Value ? Convert.ToDecimal(pemasukan) : 0;

                cmd.CommandText = queryPengeluaran;
                object pengeluaran = cmd.ExecuteScalar();
                TotalPengeluaran = pengeluaran != DBNull.Value ? Convert.ToDecimal(pengeluaran) : 0;
            }
        }
    }
}
