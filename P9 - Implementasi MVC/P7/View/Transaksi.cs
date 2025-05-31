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
using P7.Controllers;
using P7.Models;

namespace P7
{
    public partial class Transaksi : Form
    {
        private readonly TransaksiController controller = new TransaksiController();
        private int selectedId = -1;

        public Transaksi()
        {
            InitializeComponent();
            LoadData();
        }


        private void LoadData()
        {
            var data = controller.AmbilSemuaTransaksi();
            dataGridView1.Rows.Clear();

            foreach (var item in data)
            {
                dataGridView1.Rows.Add(item.Id, item.Tipe, item.Kategori,
                    item.Tanggal.ToString("yyyy-MM-dd"), item.Jumlah, item.Catatan);
            }
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


        private void button4_Click(object sender, EventArgs e)
        {
            var transaksi = new TransaksiModel
            {
                Tipe = Rbpemasukan.Checked ? "Pemasukan" : "Pengeluaran",
                Kategori = Lkategori.Text,
                Tanggal = DateTime.Parse(Ltanggal.Text),
                Jumlah = decimal.Parse(Ljumlah.Text),
                Catatan = Lcatatan.Text
            };

            controller.TambahTransaksi(transaksi);
            LoadData();
            MessageBox.Show("Data berhasil ditambahkan.");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            var transaksi = new TransaksiModel
            {
                Id = selectedId,
                Tipe = Rbpemasukan.Checked ? "Pemasukan" : "Pengeluaran",
                Kategori = Lkategori.Text,
                Tanggal = DateTime.Parse(Ltanggal.Text),
                Jumlah = decimal.Parse(Ljumlah.Text),
                Catatan = Lcatatan.Text
            };

            controller.UbahTransaksi(transaksi);
            LoadData();
            MessageBox.Show("Data berhasil diupdate.");
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedId == -1) return;

            controller.HapusTransaksi(selectedId);
            LoadData();
            MessageBox.Show("Data berhasil dihapus.");
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


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
