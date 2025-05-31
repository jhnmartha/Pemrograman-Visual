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
using OxyPlot;
using P7.Controllers;

namespace P7
{
    public partial class Register : Form
    {
        private readonly RegisterController controller;

        public Register()
        {
            InitializeComponent();
            controller = new RegisterController();
            textBox2.PasswordChar = '●';
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (controller.DaftarAkun(username, password, out string message))
            {
                MessageBox.Show(message);
                this.Hide();
                new Login().ShowDialog();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void tampilkanpw_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = tampilkanpw.Checked ? '\0' : '●';
        }

        private void buttonSignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().ShowDialog();
        }

        private void tutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
