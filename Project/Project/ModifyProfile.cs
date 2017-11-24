using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ModifyProfile : Form
    {
        public string connectionString;
        public string customer_id { get; set; }
        string firstName;
        string lastName;
        string email;
        string password;
        string country;
        string city;
        string street;
        string number;
        string apartment;
        string zipCode;

        public ModifyProfile()
        {
            InitializeComponent();
        }

        private void ModifyProfile_Load(object sender, EventArgs e)
        {

        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            firstName = firstName_txt.Text.ToString();
            lastName = lastName_txt.Text.ToString();
            email = email_txt.Text.ToString();
            password = pswd_txt.Text.ToString();
            country = country_txt.Text.ToString();
            city = city_txt.Text.ToString();
            street = street_txt.Text.ToString();
            number = number_txt.Text.ToString();
            apartment = apt_txt.Text.ToString();
            zipCode = zipCode_txt.Text.ToString();

            //queries to update tables Customer & Address
        }
    }
}
