using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P7
{
    public partial class Transaksi : Form
    {
        private int selectedId = -1;

        public Transaksi()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string connStr = "server=localhost;user=root;database=keuangan;port=3306;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, tipe, kategori, tanggal, jumlah, catatan FROM transaksi";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Hapus data lama, tapi kolom tetap

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["id"],
                                reader["tipe"],
                                reader["kategori"],
                                Convert.ToDateTime(reader["tanggal"]).ToString("yyyy-MM-dd"),
                                reader["jumlah"],
                                reader["catatan"]
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memuat data: " + ex.Message);
                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Pastikan baris yang diklik valid
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Simpan ID untuk update/hapus
                selectedId = Convert.ToInt32(row.Cells["id"].Value);

                string tipe = row.Cells["tipe"].Value?.ToString();
                string kategori = row.Cells["kategori"].Value?.ToString();
                string tanggal = row.Cells["tanggal"].Value?.ToString();
                string jumlah = row.Cells["jumlah"].Value?.ToString();
                string catatan = row.Cells["catatan"].Value?.ToString();

                // Tampilkan ke inputan
                if (tipe == "Pemasukan")
                    Rbpemasukan.Checked = true;
                else if (tipe == "Pengeluaran")
                    Rbpengeluaran.Checked = true;

                Lkategori.Text = kategori;
                Ltanggal.Text = tanggal;
                Ljumlah.Text = jumlah;
                Lcatatan.Text = catatan;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rbpemasukan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Rbpengeluaran_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Ambil nilai dari input
            string tipe = Rbpemasukan.Checked ? Rbpemasukan.Text :
                          Rbpengeluaran.Checked ? Rbpengeluaran.Text : "";

            string kategori = Lkategori.Text;
            string tanggal = Ltanggal.Text;
            string jumlah = Ljumlah.Text;
            string catatan = Lcatatan.Text;

            // Koneksi ke MySQL
            string connStr = "server=localhost;user=root;database=keuangan;port=3306;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO transaksi (tipe, kategori, tanggal, jumlah, catatan) " +
                                   "VALUES (@tipe, @kategori, @tanggal, @jumlah, @catatan)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tipe", tipe);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@catatan", catatan);
                        cmd.ExecuteNonQuery();

                        // Ambil ID terakhir yang otomatis dibuat
                        long insertedId = cmd.LastInsertedId;
                    }

                    MessageBox.Show("Data berhasil disimpan ke database!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // Setelah data disimpan, update DataGridView dengan memuat ulang data
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang akan diedit terlebih dahulu!");
                return;
            }

            string tipe = Rbpemasukan.Checked ? Rbpemasukan.Text :
                          Rbpengeluaran.Checked ? Rbpengeluaran.Text : "";
            string kategori = Lkategori.Text;
            string tanggal = Ltanggal.Text;
            string jumlah = Ljumlah.Text;
            string catatan = Lcatatan.Text;

            string connStr = "server=localhost;user=root;database=keuangan;port=3306;password=;";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE transaksi SET tipe=@tipe, kategori=@kategori, tanggal=@tanggal, jumlah=@jumlah, catatan=@catatan WHERE id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tipe", tipe);
                        cmd.Parameters.AddWithValue("@kategori", kategori);
                        cmd.Parameters.AddWithValue("@tanggal", tanggal);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@catatan", catatan);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data berhasil diupdate!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu!");
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connStr = "server=localhost;user=root;database=keuangan;port=3306;password=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM transaksi WHERE id=@id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data berhasil dihapus!");
                        selectedId = -1; // reset
                        LoadData(); // refresh tabel
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();
            this.Hide(); // atau this.Close(); jika ingin form ini ditutup
        }
    }
}
