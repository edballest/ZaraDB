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
    public partial class orderForm : Form
    {
        public string connectionString { get; set; }
        public int store_id { get; set; }
        public string UPC_code { get; set; }
        public int currentQuantity { get; set; }
        //private string product_name { get; set;}

        public orderForm()
        {
            InitializeComponent();
        }

        private void orderForm_Load(object sender, EventArgs e)
        {

            //    string query = "SELECT description FROM product WHERE UPC_code=@UPC_code";

            //    using (SqlConnection connection = new SqlConnection(connectionString))
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //    {
            //        command.Parameters.AddWithValue("@UPC_code", this.UPC_code);
            //        DataTable queryResult = new DataTable();
            //        adapter.Fill(queryResult);

            //        this.product_name = queryResult.Rows[0].ItemArray[0].ToString();

            //    }

            this.CancelButton = cancel_btn;
            info_lbl.Text = string.Format("YOU ARE ABOUT TO ORDER {0} UNITS OF '{1}'." + Environment.NewLine +
                "WE ALREADY HAVE {2} IN STOCK" + Environment.NewLine +
                "WOULD YOU LIKE TO PLACE THE ORDER?", quantity_NUD.Value, this.UPC_code, this.currentQuantity);
        }

        private void quantity_NUD_ValueChanged(object sender, EventArgs e)
        {
            info_lbl.Text = string.Format("YOU ARE ABOUT TO ORDER {0} UNITS OF '{1}'." + Environment.NewLine +
                "WE ALREADY HAVE {2} IN STOCK" + Environment.NewLine +
                "WOULD YOU LIKE TO PLACE THE ORDER?", quantity_NUD.Value, this.UPC_code, this.currentQuantity);
        }

        private void placeOrder_btn_Click(object sender, EventArgs e)
        {
            int max_inventory;
            int objectsInInventory;
            
            string max_inventory_query = "SELECT max_inventory FROM store WHERE store.store_id = @store_ID";
            string objectsInInventory_query = "SELECT SUM(Inventory.quantity) as objectsInInventory " +
                "FROM store INNER JOIN Inventory ON store.store_id = Inventory.store_id " +
                "WHERE store.store_id = @store_ID";


            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand max_inventory_command = new SqlCommand(max_inventory_query, connection))
            using (SqlCommand objectsInInventory_command = new SqlCommand(objectsInInventory_query, connection))

            using (SqlDataAdapter max_inventory_adapter = new SqlDataAdapter(max_inventory_command))
            using (SqlDataAdapter objectsInInventory_adapter = new SqlDataAdapter(objectsInInventory_command))
            {
                max_inventory_command.Parameters.AddWithValue("@store_ID", this.store_id);
                objectsInInventory_command.Parameters.AddWithValue("@store_ID", this.store_id);
                DataTable max_inventory_Result = new DataTable();
                DataTable objectsInInventory_Result = new DataTable();
                max_inventory_adapter.Fill(max_inventory_Result);
                objectsInInventory_adapter.Fill(objectsInInventory_Result);

                max_inventory = Int32.Parse((max_inventory_Result.Rows[0][0].ToString()));

                //max_inventory = Int32.Parse(queryResult1.Rows[0].ItemArray[0].ToString());
                objectsInInventory = Int32.Parse(objectsInInventory_Result.Rows[0].ItemArray[0].ToString());

                if (objectsInInventory + quantity_NUD.Value > max_inventory)
                {
                    MessageBox.Show(string.Format("NOT ENOUGH SPACE IN INVENTORY\nTHERE IS ONLY ENOUGH SPACE FOR {0} MORE ITEMS",
                        max_inventory - objectsInInventory), "NOT ENOUGH SPACE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    quantity_NUD.Value = max_inventory - objectsInInventory;
                }
                else
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    
                    adapter.UpdateCommand = new SqlCommand("UPDATE Inventory SET quantity=@newQuantity WHERE store_id=@storeID and UPC_code=@UPC_code",connection);

                    adapter.UpdateCommand.Parameters.AddWithValue("@newQuantity", this.currentQuantity + quantity_NUD.Value);
                    adapter.UpdateCommand.Parameters.AddWithValue("@storeID", this.store_id);
                    adapter.UpdateCommand.Parameters.AddWithValue("@UPC_code", this.UPC_code);

                    connection.Open();
                    adapter.UpdateCommand.ExecuteNonQuery();

                    MessageBox.Show("ORDER SUCCESFULLY PLACED");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
