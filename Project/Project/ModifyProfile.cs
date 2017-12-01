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
    public partial class ModifyProfile : Form
    {
        public string connectionString;
        public string customer_id { get; set; }
        public string address_id { get; set; }

        public ModifyProfile()
        {
            InitializeComponent();
        }

        private void ModifyProfile_Load(object sender, EventArgs e)
        {
            populateProfile();
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            changeName();
            changeLastName();
            changeEmail();
            changePassword();
            changeCountry();
            changeCity();
            changeStreet();
            changeNumber();
            changeApt();
            changezipCode();
        }

        private void populateProfile()
        {
            string query = "select first_name, last_name, email, password, country, city, street, number, apartment, zip_code, Address.address_id from Customer inner join Address on Address.address_id=Customer.address_id where customer_id=@customer_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@customer_id", customer_id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        firstName_lbl.Text = reader[0].ToString();
                        lastName_lbl.Text = reader[1].ToString();
                        email_lbl.Text = reader[2].ToString();
                        pswd_lbl.Text = reader[3].ToString();
                        country_lbl.Text = reader[4].ToString();
                        city_lbl.Text = reader[5].ToString();
                        street_lbl.Text = reader[6].ToString();
                        number_lbl.Text = reader[7].ToString();
                        apt_lbl.Text = reader[8].ToString();
                        zipCode_lbl.Text = reader[9].ToString();
                        address_id = reader[10].ToString();
                    }
                    reader.Close();
                }
            }
        }

        private void changeName()
        {
            if(firstName_txt.Text!="")
            { 
                string query = "update Customer set first_name=@FirstName where customer_id=@customer_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    command.Parameters.AddWithValue("@FirstName", firstName_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                firstName_txt.Clear();
            }
        }

        private void changeLastName()
        {
            if (lastName_txt.Text != "")
            {
                string query = "update Customer set last_name=@LastName where customer_id=@customer_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    command.Parameters.AddWithValue("@LastName", lastName_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                lastName_txt.Clear();
            }
        }

        private void changeEmail()
        {
            if (email_txt.Text != "")
            { 
                if (email_txt.ToString().IndexOfAny(new char[] { '@' }) != -1)
                {
                    //Check that the email has a "@"
                    string query = "update Customer set email=@EmailName where customer_id=@customer_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@customer_id", customer_id);
                        command.Parameters.AddWithValue("@EmailName", email_txt.Text);
                        command.ExecuteNonQuery();
                    }
                    populateProfile();
                    email_txt.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid email address");
                }
            }
        }

        private void changePassword()
        {
            if (pswd_txt.Text != "")
            {
                string query = "update Customer set password=@password where customer_id=@customer_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@customer_id", customer_id);
                    command.Parameters.AddWithValue("@password", pswd_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                pswd_txt.Clear();
            }
        }

        private void changeCountry()
        {
            if (country_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set country=@Country where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@Country", country_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                country_txt.Clear();
            }
        }

        private void changeCity()
        {
            if (city_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set city=@City where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@City", city_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                city_txt.Clear();
            }
        }

        private void changeStreet()
        {
            if (street_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set street=@Street where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@Street", street_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                street_txt.Clear();
            }
        }

        private void changeNumber()
        {
            if (number_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set number=@Number where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@Number", number_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                number_txt.Clear();
            }
        }

        private void changeApt()
        {
            if (apt_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set apartment=@Apartment where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@Apartment", apt_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                apt_txt.Clear();
            }
        }

        private void changezipCode()
        {
            if (zipCode_txt.Text != "")
            {
                //Ojo hay varios customers con el mismo address_id. Si cambio uno cambio todos
                string query = "update Address set zip_code=@zipCode where address_id=@AddressID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AddressID", address_id);
                    command.Parameters.AddWithValue("@zipCode", zipCode_txt.Text);
                    command.ExecuteNonQuery();
                }
                populateProfile();
                zipCode_txt.Clear();
            }
        }
    }
}
