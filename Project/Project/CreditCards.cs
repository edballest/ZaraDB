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
    public partial class CreditCards : Form
    {
        public string connectionString;
        public string customer_id { get; set; }
        //public string number { get; set; }
        //public string numSel { get; set; }
        //public string newCC { get; set; }

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
                command.Parameters.AddWithValue("@customer_id", customer_id);

                DataTable creditCards = new DataTable();
                adapter.Fill(creditCards);
                creditCardList.DisplayMember = "number";
                creditCardList.ValueMember = "number";
                creditCardList.DataSource = creditCards;
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            string query = "delete from Credit_Card where number=@CreditCardNumber and customer_id=@customer_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@CreditCardNumber", creditCardList.SelectedValue);
                command.Parameters.AddWithValue("@customer_id", customer_id);
                command.ExecuteNonQuery();
            }
            populateCreditCardList();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (creditCard_txt.Text!="")
            {
                bool a = true;
                foreach (char c in creditCard_txt.Text)
                {
                    if ((c < '0') || (c > '9'))
                    {
                        a = false;
                    }
                }
                if (a)
                {
                    string query = "insert into Credit_Card values(@customer_id, @NewCreditCardNumber)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@NewCreditCardNumber", creditCard_txt.Text);
                        command.Parameters.AddWithValue("@customer_id", customer_id);
                        command.ExecuteNonQuery();
                    }
                    populateCreditCardList();
                    creditCard_txt.Clear();
                }
                else
                {
                    MessageBox.Show("Please introduce only numbers");
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (creditCard_txt.Text != "")
            {
                bool a = true;
                foreach (char c in creditCard_txt.Text)
                {
                    if ((c < '0') || (c > '9'))
                    {
                        a = false;
                    }
                }
                if (a) { 
                    string query = "update Credit_Card set number=@ChangeCC where number=@CreditCardNumber and customer_id=@customer_id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@CreditCardNumber", creditCardList.SelectedValue);
                        command.Parameters.AddWithValue("@ChangeCC", creditCard_txt.Text);
                        command.Parameters.AddWithValue("@customer_id", customer_id);

                        command.ExecuteNonQuery();
                    }
                    populateCreditCardList();
                    creditCard_txt.Clear();
                }
            }
        }
    }
}
