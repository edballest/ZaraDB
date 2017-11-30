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
    public partial class updateForm : Form
    {
        public string connectionString { get; set; }
        public int store_id { get; set; }

        public string UPC_code { get; set; }
        public Decimal  currentPrice { get; set; }
        public int currentQuantity { get; set; }


        public updateForm()
        {
            InitializeComponent();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
            this.CancelButton = cancel_btn;
            UPC_code_lbl.Text = "ITEM: " +this.UPC_code;
            price_UD.Value = this.currentPrice;
            quantity_UD.Value = this.currentQuantity;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.UpdateCommand = new SqlCommand("UPDATE Inventory SET price=@newPrice, quantity=@newQuantity " +
                    "WHERE store_id=@storeID and UPC_code=@UPC_code", connection);

                adapter.UpdateCommand.Parameters.AddWithValue("@newPrice", price_UD.Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@newQuantity", quantity_UD.Value);
                adapter.UpdateCommand.Parameters.AddWithValue("@storeID", this.store_id);
                adapter.UpdateCommand.Parameters.AddWithValue("@UPC_code", this.UPC_code);

                connection.Open();
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("UPDATE SUCCESFUL");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
    }
}
