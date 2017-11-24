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

//what is commented is because it doesn't work. Watch video4

namespace Project
{
    public partial class CreditCards : Form
    {
        public string connectionString;
        public string customer_id { get; set; }
        public string number { get; set; }
        public string numSel { get; set; }
        public string newCC { get; set; }

        public CreditCards()
        {
            InitializeComponent();
        }

        private void creditCardList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreditCards_Load(object sender, EventArgs e)
        {
            populateCreditCardList();
        }

        private void populateCreditCardList()
        {
            string query = "select number from Credit_Card inner join Customer on Customer.customer_id = Credit_Card.customer_id where Credit_Card.customer_id=@customer_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@customer_id", customer_id);
                connection.Close();

                DataTable creditCards = new DataTable();
                adapter.Fill(creditCards);
                creditCardList.DisplayMember = "number";
                creditCardList.ValueMember = "number";
                creditCardList.DataSource = creditCards;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            //this.numSel = creditCardList.SelectedValue.ToString();

            //string query = "delete from Credit_Card where (number=@number and Credit_Card.customer_id=@customer_id)";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //{
            //    command.Parameters.AddWithValue("@number", numSel);
            //    command.Parameters.AddWithValue("@customer_id", customer_id);
            //    populateCreditCardList();
            //}

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            //this.newCC = creditCard_txt.Text.ToString();

            //string query = "insert into Credit_Card (customer_id,number) values (@customer_id,@newCC)";
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //using (SqlCommand command = new SqlCommand(query, connection))
            //using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //{
            //    command.Parameters.AddWithValue("@newCC", newCC);
            //    command.Parameters.AddWithValue("@customer_id", customer_id);
            //    populateCreditCardList();
            //}


        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
