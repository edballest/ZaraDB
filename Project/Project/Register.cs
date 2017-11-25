using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Project
{
    public partial class Register : Form
    {
        SqlConnection connection;

        public string connectionString { get; set; }

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Code to add customer tu Database. Just like ModifyProfile

        }

        private void IntroduceMember()
        {
            if ((pswd_txt.Text != "")&& (email_txt.ToString().IndexOfAny(new char[] { '@' }) != -1))
            {
                string query = "insert into Customer(email, password, address_id, first_name, last_name) values(@Email, @Password,@Address_id, @FirstName, @LastName)";

                //Si no meto address_id, me lo genera solo?
                //meter código de verificación de que todos los campos de arriba tienen valor, sino asignar NULL
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Email", email_txt.Text);
                    command.Parameters.AddWithValue("@Password", pswd_txt.Text);
                    //command.Parameters.AddWithValue("@Address_id", pswd_txt.Text);
                    command.Parameters.AddWithValue("@FirstName", firstName_txt.Text);
                    command.Parameters.AddWithValue("@LastName", lastName_txt.Text);
                    command.ExecuteNonQuery();
                }

                //pswd_txt.Clear();
            }
            else
            {
                MessageBox.Show("Make sure you've introduced an email and a password");
            }
        }
    }
}
