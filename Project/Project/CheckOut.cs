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
        string qty;
        string name;
        DataTable cart;
        double total=0;
        double price;

        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            total_lbl.Hide();
            decor_lbl.Hide();
            checkOut_btn.Enabled = false;

            cart = new DataTable();
            cart.Columns.Add("UPC_code", typeof(string));
            cart.Columns.Add("quantity", typeof(int));
            cart.Columns.Add("inStock", typeof(int));
            itemsList.DisplayMember = "UPC_code";

            populateCreditCardList();
            
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
            int quantity;
            int remaining;
            string UPC_code;

            foreach (DataRow row in cart.Rows)
            {
                quantity = Int32.Parse(row["quantity"].ToString());
                remaining = Int32.Parse(row["inStock"].ToString()) - quantity;
                UPC_code = row["UPC_code"].ToString();

                using (SqlConnection connection = new SqlConnection(this.connectionString))
                {
                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    SqlDataAdapter adapter2 = new SqlDataAdapter();

                    adapter1.UpdateCommand = new SqlCommand("UPDATE Inventory SET quantity=@newQuantity " +
                        "WHERE store_id=@storeID and UPC_code=@UPC_code", connection);


                    adapter1.UpdateCommand.Parameters.AddWithValue("@newQuantity", remaining);
                    adapter1.UpdateCommand.Parameters.AddWithValue("@storeID", this.store_id);
                    adapter1.UpdateCommand.Parameters.AddWithValue("@UPC_code", UPC_code);

                    connection.Open();
                    adapter1.UpdateCommand.ExecuteNonQuery();

                    adapter2.UpdateCommand = new SqlCommand("INSERT INTO Transactions" +
                        " VALUES(@UPC_code,@customerID,@storeID,@quantity,@date_time)", connection);

                    adapter2.UpdateCommand.Parameters.AddWithValue("@newQuantity", remaining);

                    adapter2.UpdateCommand.Parameters.AddWithValue("@UPC_code", UPC_code);
                    adapter2.UpdateCommand.Parameters.AddWithValue("@customerID", this.customer_id);
                    adapter2.UpdateCommand.Parameters.AddWithValue("@storeID", this.store_id);
                    adapter2.UpdateCommand.Parameters.AddWithValue("@quantity", quantity );
                    adapter2.UpdateCommand.Parameters.AddWithValue("@date_time", System.DateTime.Now);

                    adapter2.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("THANK YOU FOR" + "\n" + "   SHOPPING AT" + "\n" + "          ZARA");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if ((upcCode_txt.Text.ToString() != "") && (qty_txt.Text.ToString() != ""))
            {
                NewItem();
                

                //METER UN ARRAY DINAMICO QUE GUARDE LA CANTIDAD DE PRODUCTO
                //METER AQUÍ LAS TRANSACTIONS -> HAY QUE MODIFICAR LA DB

                //add that product to bag & update stuff in DB or what?

                //DateTime myDateTime = DateTime.Now;
                //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                //delete text in UPC & qty txt boxes so i can put new ones
                upcCode_txt.Clear();
                qty_txt.Clear();
            }
        }

        private void NewItem()
        {
            int inStock;
            int quantity;
            string UPC_code;

            string query = "select quantity, price from Inventory where UPC_code=@UPC_code and store_id=@Store_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UPC_code", upcCode_txt.Text);
                command.Parameters.AddWithValue("@Store_id", store_id);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        inStock = Int32.Parse(reader[0].ToString());
                        price = Double.Parse(reader[1].ToString());
                        quantity = Int32.Parse(qty_txt.Text);
                        UPC_code = upcCode_txt.Text.ToString();

                        if (quantity <= inStock)
                        {
                            total_lbl.Show();
                            decor_lbl.Show();
                            checkOut_btn.Enabled = true;
                            total = quantity * price + total;
                            total_lbl.Text = total.ToString();
                            cart.Rows.Add(UPC_code, quantity, inStock);

                            updateItemList();
                        }
                        else MessageBox.Show("NOT ENOUGH ITEMS IN STOCK\nPLEASE SELECT A LOWER QUANTITY"
                                                    , "NOT ENOUGH ITEMS IN STOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("OBJECT UPC_CODE NOT RECOGNISED"
                                        ,"INCORRECT UPC_CODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader.Close();
                }
            }
        }

        private void updateItemList()
        {
            itemsList.DataSource = cart;
        }
        private void populateCreditCardList()
        {
            string query = "select number from Credit_Card inner join Customer on Customer.customer_id = Credit_Card.customer_id " +
                "where Credit_Card.customer_id=@customer_id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //connection.Open();
                command.Parameters.AddWithValue("@customer_id", this.customer_id);
                // connection.Close();

                DataTable creditCards = new DataTable();
                adapter.Fill(creditCards);

                if (creditCards.Rows.Count==0)
                {
                    using (insertCreditCardForm iCC1 = new insertCreditCardForm())
                    {
                        var result = iCC1.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            creditCards.Rows.Add(iCC1.credit_card_number);
                        }
                    }
                }
                creditCardCB.DisplayMember = "number";
                creditCardCB.ValueMember = "number";
                creditCardCB.DataSource = creditCards;
            }
        }

        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
