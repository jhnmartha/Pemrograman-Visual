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

namespace weatherTrail
{
    public partial class User : Form
    {


        MySqlConnection connection = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=user");
       

        public User()
        {
            InitializeComponent();
            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new Size(this.txtPassword.Size.Width, 20);  
        }

        private void User_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            String username = txtUsername.Text;
            String password = txtPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  username = @usn and password = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if the user exists or not
            if (table.Rows.Count > 0)
            {
                this.Hide();
                Weather weather = new Weather();
                weather.Show();
            }
            else
            {

                if (username.Trim().Equals(""))
                {


                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else if (password.Trim().Equals(""))
                {


                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else {

                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();

        }
    }
}
