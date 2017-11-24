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
    public partial class ChooseCreditCard : Form
    {
        SqlConnection connection;

        public string connectionString { get; set; }
        public string customer_id { get; set; }
        public string upcCode { get; set; }
        public string qty { get; set; }
        string date_time;
        string creditCardNum;

        public ChooseCreditCard()
        {
            InitializeComponent();
        }

        private void ChooseCreditCard_Load(object sender, EventArgs e)
        {
            populateCreditCardList();

        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR" + "\n" + "   SHOPPING AT" + "\n" + "          ZARA");
            creditCardNum = creditCardList.SelectedValue.ToString();
            //record date & time
            //put transaction into DB
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
    }
}
