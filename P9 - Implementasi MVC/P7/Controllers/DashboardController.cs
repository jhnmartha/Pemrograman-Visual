using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;

namespace P7.Controllers
{
    internal class DashboardController
    {
        public PlotModel GenerateChart()
        {
            var model = new PlotModel();
            var axisX = new CategoryAxis { Position = AxisPosition.Bottom, Title = "Tanggal", Angle = 45 };
            var axisY = new LinearAxis { Position = AxisPosition.Left, Title = "Jumlah", LabelFormatter = val => val.ToString("N0") };

            var pemasukanSeries = new LineSeries { Title = "Pemasukan", MarkerType = MarkerType.Circle };
            var pengeluaranSeries = new LineSeries { Title = "Pengeluaran", MarkerType = MarkerType.Diamond };

            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT tanggal, 
                           SUM(CASE WHEN tipe = 'Pemasukan' THEN jumlah ELSE 0 END) AS pemasukan,
                           SUM(CASE WHEN tipe = 'Pengeluaran' THEN jumlah ELSE 0 END) AS pengeluaran
                    FROM transaksi
                    GROUP BY tanggal ORDER BY tanggal";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int index = 0;
                    while (reader.Read())
                    {
                        string tanggal = Convert.ToDateTime(reader["tanggal"]).ToString("MM-dd");
                        axisX.Labels.Add(tanggal);
                        pemasukanSeries.Points.Add(new DataPoint(index, Convert.ToDouble(reader["pemasukan"])));
                        pengeluaranSeries.Points.Add(new DataPoint(index, Convert.ToDouble(reader["pengeluaran"])));
                        index++;
                    }
                }
            }

            model.Axes.Add(axisX);
            model.Axes.Add(axisY);
            model.Series.Add(pemasukanSeries);
            model.Series.Add(pengeluaranSeries);
            return model;
        }
    }
}
