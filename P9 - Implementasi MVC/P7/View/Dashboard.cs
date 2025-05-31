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
using P7.Controllers;
using P7.Models;

namespace P7
{
    public partial class Dashboard : Form
    {
        private readonly DashboardModel model;
        private readonly DashboardController controller;

        public Dashboard()
        {
            InitializeComponent();
            model = new DashboardModel();
            controller = new DashboardController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            model.LoadData();
            UpdateView();
            plotView1.Model = controller.GenerateChart();
        }

        private void UpdateView()
        {
            Ltotalpemasukan.Text = "Rp" + model.TotalPemasukan.ToString("N0");
            Ltotalpengeluaran.Text = "Rp" + model.TotalPengeluaran.ToString("N0");
            Lsisasaldo.Text = "Rp" + model.SisaSaldo.ToString("N0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaksi transaksiForm = new Transaksi();
            transaksiForm.Show();
            this.Hide(); // atau this.Close(); jika ingin menutup form saat ini
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
