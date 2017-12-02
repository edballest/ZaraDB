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
    public partial class CustomerCheckOut : Form
    {
        SqlConnection connection;

        public string connectionString { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public static string customer_id { get; set; }
        public string store_id { get; set; }

        public CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void CustomerCheckOut_Load(object sender, EventArgs e)
        {
            pswd_txt.PasswordChar = '*';
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            if ((email_txt.Text.ToString() != "") && (pswd_txt.Text.ToString() != ""))
            {
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
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password");
                        }
                        reader.Close();
                    }
                }

                this.Hide();

                using (CheckOut checkOut = new CheckOut())
                {
                    checkOut.connectionString = connectionString;
                    checkOut.customer_id = customer_id;
                    checkOut.store_id = store_id;
                    checkOut.ShowDialog();
                }
            }
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (CheckOut checkOut = new CheckOut())
            {
                checkOut.connectionString = connectionString;
                checkOut.customer_id = "1";
                checkOut.store_id = store_id;
                checkOut.ShowDialog();
            }
        }
    }
}
