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
    public partial class CheckOut : Form
    {
        SqlConnection connection;

        public string connectionString { get; set; }    
        public string customer_id { get; set; }             //be careful because it's a string and in table it's an int
        string upcCode;
        string qty;
        string name;

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
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

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            if ((upcCode_txt.Text.ToString() != "") && (qty_txt.Text.ToString() != ""))
            {
                //for now i'm only putting one but it's going to need to be a list for the several txt boxes
                this.upcCode = upcCode_txt.Text.ToString();
                this.qty = qty_txt.Text.ToString();

                //i'm also gonna need credit_card number (need to modify SCHEMA and DB ---> OMG!!)


                this.Hide();

                using (ChooseCreditCard chooseCC = new ChooseCreditCard())
                {
                    chooseCC.connectionString = connectionString;
                    chooseCC.customer_id = customer_id;
                    chooseCC.upcCode = upcCode;
                    chooseCC.qty = qty;
                    chooseCC.ShowDialog();
                }

            }
        }
    }
}
