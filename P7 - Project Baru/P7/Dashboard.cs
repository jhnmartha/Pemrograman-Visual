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
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;

namespace P7
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void LoadKeuangan()
        {
            string connectionString = "server=localhost;user=root;password=;database=keuangan;";
            decimal totalPemasukan = 0;
            decimal totalPengeluaran = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Ambil total pemasukan
                    string queryPemasukan = "SELECT SUM(jumlah) FROM transaksi WHERE tipe = 'Pemasukan'";
                    MySqlCommand cmdPemasukan = new MySqlCommand(queryPemasukan, conn);
                    object resultPemasukan = cmdPemasukan.ExecuteScalar();
                    if (resultPemasukan != DBNull.Value)
                        totalPemasukan = Convert.ToDecimal(resultPemasukan);

                    // Ambil total pengeluaran
                    string queryPengeluaran = "SELECT SUM(jumlah) FROM transaksi WHERE tipe = 'Pengeluaran'";
                    MySqlCommand cmdPengeluaran = new MySqlCommand(queryPengeluaran, conn);
                    object resultPengeluaran = cmdPengeluaran.ExecuteScalar();
                    if (resultPengeluaran != DBNull.Value)
                        totalPengeluaran = Convert.ToDecimal(resultPengeluaran);

                    // Hitung sisa saldo
                    decimal sisaSaldo = totalPemasukan - totalPengeluaran;

                    // Tampilkan ke label
                    Ltotalpemasukan.Text = "Rp" + totalPemasukan.ToString("N0");
                    Ltotalpengeluaran.Text = "Rp" + totalPengeluaran.ToString("N0");
                    Lsisasaldo.Text = "Rp" + sisaSaldo.ToString("N0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data: " + ex.Message);
                }
            }
        }


        private void LoadChart()
        {
            var plotModel = new PlotModel(); // Tidak ada Title

            // Sumbu X (Tanggal)
            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Tanggal",
                Angle = 45
            };

            // Sumbu Y (Jumlah)
            var linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Jumlah (Rp)",
                LabelFormatter = value => value.ToString("N0") // Format angka ribuan
            };

            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(linearAxis);

            var pemasukanSeries = new LineSeries { Title = "Pemasukan", MarkerType = MarkerType.Circle };
            var pengeluaranSeries = new LineSeries { Title = "Pengeluaran", MarkerType = MarkerType.Diamond };

            string connectionString = "server=localhost;user=root;password=;database=keuangan;";
            string query = @"
        SELECT tanggal, 
               SUM(CASE WHEN tipe = 'Pemasukan' THEN jumlah ELSE 0 END) AS total_pemasukan,
               SUM(CASE WHEN tipe = 'Pengeluaran' THEN jumlah ELSE 0 END) AS total_pengeluaran
        FROM transaksi
        GROUP BY tanggal
        ORDER BY tanggal ASC";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            string tanggal = Convert.ToDateTime(reader["tanggal"]).ToString("dd-MM");
                            decimal pemasukan = Convert.ToDecimal(reader["total_pemasukan"]);
                            decimal pengeluaran = Convert.ToDecimal(reader["total_pengeluaran"]);

                            categoryAxis.Labels.Add(tanggal);
                            pemasukanSeries.Points.Add(new DataPoint(index, (double)pemasukan));
                            pengeluaranSeries.Points.Add(new DataPoint(index, (double)pengeluaran));
                            index++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat grafik: " + ex.Message);
                }
            }

            plotModel.Series.Add(pemasukanSeries);
            plotModel.Series.Add(pengeluaranSeries);
            plotView1.Model = plotModel;
        }





        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadKeuangan();
            LoadChart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.Show();
            this.Hide(); // atau this.Close(); jika ingin menutup form saat ini
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
    }
}
