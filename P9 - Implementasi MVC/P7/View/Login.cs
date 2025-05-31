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
using P7;
using P7.Controllers;

namespace P7
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '●';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            bool loginBerhasil = LoginController.Login(username, password);

            if (loginBerhasil)
            {
                MessageBox.Show("Login berhasil!");
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah.");
            }
        }

        private void tampilkanpw_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = tampilkanpw.Checked ? '\0' : '●';
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
        }

        private void tutup_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
