using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Net;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace weatherTrail
{
    public partial class Weather : Form
    {
        public Weather()
        {
            InitializeComponent();
        }

        private void txthumidity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weather_Load(object sender, EventArgs e)
        {

        }

        string city;

        private void currentbtn_Click(object sender, EventArgs e)
        {

          

            city = txtcity.Text;

            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=46d22bedb4824b5485a172113201209&q={0}&days=1", city);

            XDocument doc = XDocument.Load(url);

            string iconUrl = (string)doc.Descendants("icon").FirstOrDefault();

            WebClient client = new WebClient();

            byte[] image = client.DownloadData("http:" + iconUrl);

            MemoryStream stream = new MemoryStream(image);

            Bitmap newBitMap = new Bitmap(stream);
            string maxtemp = (string)doc.Descendants("maxtemp_c").FirstOrDefault();
            string mintemp = (string)doc.Descendants("mintemp_c").FirstOrDefault();
            string maxwindk = (string)doc.Descendants("maxwind_kph").FirstOrDefault();
            string humidity = (string)doc.Descendants("avghumidity").FirstOrDefault();
            string country = (string)doc.Descendants("country").FirstOrDefault();
            string cloud = (string)doc.Descendants("text").FirstOrDefault();

            Bitmap icon = newBitMap;

            txtmaxtemp.Text = maxtemp;
            txtmintemp.Text = mintemp;
            txtwindk.Text = maxwindk;
            txthumidity.Text = humidity;
            txtcountry.Text = country;
            status.Text = cloud;
            pictureBox1.Image = icon;
           



        }







        private void weekbtn_Click(object sender, EventArgs e)
        {
         
            DataTable dt = new DataTable();
            dt.Columns.Add("country", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Max Temp", typeof(string));
            dt.Columns.Add("Min Temp", typeof(string));
            dt.Columns.Add("Maxwindkph", typeof(string));
            dt.Columns.Add("Humidity", typeof(string));
            dt.Columns.Add("Cloud", typeof(string));
            dt.Columns.Add("Icon", typeof(Image));

            city = txtcity.Text;

            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=46d22bedb4824b5485a172113201209&q={0}&days=7", city);

            XDocument doc = XDocument.Load(url);

            foreach (var npc in doc.Descendants("forecastday"))
            {

                string iconUrl = (string)npc.Descendants("icon").FirstOrDefault();

                WebClient client = new WebClient();

                byte[] image = client.DownloadData("http:" + iconUrl);

                MemoryStream stream = new MemoryStream(image);

                Bitmap newBitmap = new Bitmap(stream);


                
                    dt.Rows.Add(new object[]
                {

                (string)doc.Descendants("country").FirstOrDefault(),
                (string)npc.Descendants("date").FirstOrDefault(),
                (string)npc.Descendants("maxtemp_c").FirstOrDefault(),
                (string)npc.Descendants("mintemp_c").FirstOrDefault(),
                (string)npc.Descendants("maxwind_kph").FirstOrDefault(),
                (string)npc.Descendants("avghumidity").FirstOrDefault(),
                (string)npc.Descendants("text").FirstOrDefault(),
                newBitmap


                });

                
            }
            dataGridView1.DataSource = dt;
          
        }

        private void astrobtn_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("country", typeof(string));
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Sunrise", typeof(string));
            dt.Columns.Add("Sunset", typeof(string));
            dt.Columns.Add("Moonrise", typeof(string));
            dt.Columns.Add("Moonset", typeof(string));
            

            city = txtcity.Text;

            string url = string.Format("http://api.weatherapi.com/v1/forecast.xml?key=46d22bedb4824b5485a172113201209&q={0}&days=7", city);

            XDocument doc = XDocument.Load(url);

            foreach (var ast in doc.Descendants("forecastday"))
            {

            



                dt.Rows.Add(new object[]
            {

                (string)doc.Descendants("country").FirstOrDefault(),
                (string)ast.Descendants("date").FirstOrDefault(),
                (string)ast.Descendants("sunrise").FirstOrDefault(),
                (string)ast.Descendants("sunset").FirstOrDefault(),
                (string)ast.Descendants("moonrise").FirstOrDefault(),
                (string)ast.Descendants("moonset").FirstOrDefault(),
                


            });


            }
            dataGridView1.DataSource = dt;

        }



        private void expbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++) {

                    xcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;   
                
                
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++) {


                    for (int j = 0; j < dataGridView1.Rows.Count; j++) {

                        xcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    
                    }

                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            
            
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        
    }
            }
    
}
