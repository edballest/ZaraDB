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
        public string connectionString { get; set; }    
        public string customer_id { get; set; }      //be careful because it's a string and in table it's an int
        public int store_id { get; set; }
        string upcCode;
        string qty;
        string name;
        int quantity;
        double total=0;
        double price;
        int number = 0;

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            
            if (customer_id != "1")
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

            else name_lbl.Text = "GUEST";

        }

        private void checkOut_btn_Click(object sender, EventArgs e)
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            if ((upcCode_txt.Text.ToString() != "") && (qty_txt.Text.ToString() != ""))
            {
                number = Int32.Parse(qty_txt.Text);
                this.upcCode = upcCode_txt.Text.ToString();
                NewItem();
                //this.qty = qty_txt.Text.ToString();

                //add that product to bag & update stuff in DB or what?

                //string query = "";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    connection.Open();
                //    command.Parameters.AddWithValue("@upc", upcCode_txt.Text);
                //    command.Parameters.AddWithValue("@qty", qty_txt.Text);
                //    this.name = command.ExecuteScalar().ToString();
                //    command.ExecuteNonQuery();
                //}


                //delete text in UPC & qty txt boxes so i can put new ones
                upcCode_txt.Clear();
                qty_txt.Clear();
            }
        }

        private void NewItem()
        {
            string query = "select quantity, price from Inventory where UPC_code=@UPC_code and store_id=@Store_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UPC_code", upcCode_txt.Text);
                command.Parameters.AddWithValue("@Store_id", store_id.ToString());
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        quantity = Int32.Parse(reader[0].ToString());
                        price = Double.Parse(reader[1].ToString());
                    }
                    reader.Close();
                }
            }

            if (number < quantity)
            {
                total = number * price + total;
                total_lbl.Text = total.ToString();
            }
            else MessageBox.Show("Please select another quantity");
        }
    }
}
