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
    public partial class logIn : Form
    {
        SqlConnection connection;

        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public static string customer_id { get; set; }
        public string connectionString { get; set; }
        public static int alreadyLogIn { get; set; }

        public logIn()
        {
            InitializeComponent();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            pswd_txt.PasswordChar = '*';
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            if ((email_txt.Text.ToString() != "") && (pswd_txt.Text.ToString() != ""))
            {
                alreadyLogIn = 1;
                this.email = email_txt.Text.ToString();
                this.password = pswd_txt.Text.ToString();

                string query = "select customer_id from Customer where (email=@email and password=@password)";

                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@email", this.email);
                    command.Parameters.AddWithValue("@password", this.password);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer_id = reader[0].ToString();
                            this.Hide();

                            using (profile profile = new profile())
                            {
                                profile.connectionString = connectionString;
                                profile.customer_id = customer_id;
                                profile.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");
                        }
                        reader.Close();
                    }
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
