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
        public string connectionString;
        public string address_id { get; set; }
        bool finished = false;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //pswd_txt.PasswordChar = '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            IntroduceMember();
            if (finished)
            {
                this.Hide();
                //Code to add customer tu Database. Just like ModifyProfile
            }
        }

        private void IntroduceMember()
        {
             if ((pswd_txt.Text != "") && (email_txt.ToString().IndexOfAny(new char[] { '@' }) != -1) && (country_txt.Text != "") && (city_txt.Text != "") && (street_txt.Text != "") && (number_txt.Text != "") && (zipCode_txt.Text != ""))
                {
                    string query = "insert into Address(country, city, street, number, apartment, zip_code) values(@Country, @City, @Street, @Number, @Apartment, @ZipCode)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Country", country_txt.Text);
                        command.Parameters.AddWithValue("@City", city_txt.Text);
                        command.Parameters.AddWithValue("@Street", street_txt.Text);
                        command.Parameters.AddWithValue("@Number", number_txt.Text);
                        command.Parameters.AddWithValue("@ZipCode", zipCode_txt.Text);
                        if (apt_txt.Text != "")
                        {
                            command.Parameters.AddWithValue("@Apartment", apt_txt.Text);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Apartment", Convert.DBNull);
                        }
                        command.ExecuteNonQuery();
                    }
                    
                    string query2 = "select address_id from Address where country=@Country and city=@City and street=@Street";

                    using (SqlConnection connection2 = new SqlConnection(connectionString))
                    using (SqlCommand command2 = new SqlCommand(query2, connection2))
                    {
                        connection2.Open();
                        command2.Parameters.AddWithValue("@Country", country_txt.Text);
                        command2.Parameters.AddWithValue("@City", city_txt.Text);
                        command2.Parameters.AddWithValue("@Street", street_txt.Text);
                        using (SqlDataReader reader = command2.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                address_id = reader[0].ToString();
                            }
                            reader.Close();
                        }
                    }

                    string query3 = "insert into Customer(email, password, address_id, first_name, last_name) values(@Email, @Password,@Address_id, @FirstName, @LastName)";
                
                    using (SqlConnection connection3 = new SqlConnection(connectionString))
                    using (SqlCommand command3 = new SqlCommand(query3, connection3))
                    {
                        connection3.Open();
                        command3.Parameters.AddWithValue("@Email", email_txt.Text);
                        command3.Parameters.AddWithValue("@Password", pswd_txt.Text);
                        command3.Parameters.AddWithValue("@Address_id", address_id);
                        if (firstName_lbl.Text != "")
                        {
                            command3.Parameters.AddWithValue("@FirstName", firstName_txt.Text);
                        }
                        else
                        {
                            command3.Parameters.AddWithValue("@FirstName", Convert.DBNull);
                        }
                        if (lastName_lbl.Text != "")
                        {
                            command3.Parameters.AddWithValue("@LastName", lastName_txt.Text);
                        }
                        else
                        {
                            command3.Parameters.AddWithValue("@LastName", Convert.DBNull);
                        }
                        finished = true;
                        command3.ExecuteNonQuery();
                    }
                    
             }else
            {
                finished = false;
                MessageBox.Show("Make sure you've introduced an address, an email and a password");
            }
        }
    }
}
