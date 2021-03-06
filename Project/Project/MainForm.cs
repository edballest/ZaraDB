﻿using System;
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
    public partial class FormMain : Form
    {
        string connectionString;
        int storeID;
        string storeLocation;
        string storeCity;
        string storeStreet;
        public static int loggedIn;
        public static string customer_id { get; set; }

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Project.Properties.Settings.ZaraDBConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            using(selectStore ss1 = new selectStore())
            {
                ss1.connectionString = connectionString;
                var result = ss1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    storeID = ss1.storeID;
                    storeLocation = ss1.storeLocation;
                    storeCity = ss1.storeCity;
                    storeStreet = ss1.storeStreet;
                }
            }
            store_lbl.Text = storeLocation;

        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(employeeForm eF1 = new employeeForm())
            {
                eF1.connectionString = connectionString;
                eF1.store_id = storeID;
                eF1.ShowDialog();
            }
            this.Show();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using(logIn login = new logIn())
            {
                login.connectionString = connectionString;
                login.ShowDialog();
                loggedIn = logIn.alreadyLogIn;
                customer_id = logIn.customer_id;
            }

        }

        private void catalog_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using (catalog c1 = new catalog())
            {
                c1.connectionString = connectionString;
                c1.storeCity = storeCity;
                c1.storeStreet = storeStreet;
                var result = c1.ShowDialog();
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using (Register register = new Register())
            {
                register.connectionString = connectionString;
                register.ShowDialog();

            }

        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (loggedIn == 1)
            {
                using (CheckOut checkOut = new CheckOut())
                {
                    checkOut.connectionString = connectionString;
                    checkOut.customer_id = customer_id;
                    checkOut.store_id = storeID; 
                    checkOut.ShowDialog();
                }
            }
            else
            {

                using (CustomerCheckOut customer = new CustomerCheckOut())
                {
                    customer.connectionString = connectionString;
                    customer.store_id = storeID;
                    customer.ShowDialog();
                }
            }
        }
    }
}
