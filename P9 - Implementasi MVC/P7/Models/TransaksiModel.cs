using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P7.Models
{
    internal class TransaksiModel
    {
        public int Id { get; set; }
        public string Tipe { get; set; }
        public string Kategori { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Jumlah { get; set; }
        public string Catatan { get; set; }

        public static List<TransaksiModel> GetAll()
        {
            var list = new List<TransaksiModel>();

            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transaksi";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TransaksiModel
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Tipe = reader["tipe"].ToString(),
                            Kategori = reader["kategori"].ToString(),
                            Tanggal = Convert.ToDateTime(reader["tanggal"]),
                            Jumlah = Convert.ToDecimal(reader["jumlah"]),
                            Catatan = reader["catatan"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public void Insert()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO transaksi (tipe, kategori, tanggal, jumlah, catatan) VALUES (@tipe, @kategori, @tanggal, @jumlah, @catatan)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipe", Tipe);
                    cmd.Parameters.AddWithValue("@kategori", Kategori);
                    cmd.Parameters.AddWithValue("@tanggal", Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", Catatan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE transaksi SET tipe=@tipe, kategori=@kategori, tanggal=@tanggal, jumlah=@jumlah, catatan=@catatan WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tipe", Tipe);
                    cmd.Parameters.AddWithValue("@kategori", Kategori);
                    cmd.Parameters.AddWithValue("@tanggal", Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", Jumlah);
                    cmd.Parameters.AddWithValue("@catatan", Catatan);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete()
        {
            using (var conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM transaksi WHERE id=@id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
