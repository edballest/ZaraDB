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
    public partial class profile : Form
    {
        public string connectionString;
        public string email { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string customer_id { get; set; }

        public profile()
        {
            InitializeComponent();
        }

        private void profile_Load(object sender, EventArgs e)
        {

            string query = "select first_name from Customer where customer_id=@customer_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@customer_id", customer_id);
                this.name = command.ExecuteScalar().ToString();
                connection.Close();
            }
            name_lbl.Text = name;
        }

        private void creditCard_btn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            using (CreditCards cc = new CreditCards())
            {
                cc.connectionString = connectionString;
                cc.customer_id = customer_id;
                cc.ShowDialog();
            }
        }

        private void editProf_btn_Click(object sender, EventArgs e)
        {
            using (ModifyProfile modifyProf = new ModifyProfile())
            {
                modifyProf.connectionString = connectionString;
                modifyProf.customer_id = customer_id;
                modifyProf.ShowDialog();
            }

        }
    }
}
