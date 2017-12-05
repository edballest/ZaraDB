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
    public partial class selectStore : Form
    {
        SqlConnection connection;
        //public string storeID { get; set; }
        public string storeLocation { get; set; }
        public string storeCity { get; set; }
        public string storeStreet { get; set; }
        public string connectionString { get; set; }
        public int storeID { get; set; }

        public selectStore()
        {
            InitializeComponent();
        }

        private void selectStore_Load(object sender, EventArgs e)
        {
            populateCityList();
            
    }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            this.storeCity = cityList.SelectedValue.ToString();
            //this.storeLocation = cityList.SelectedValue.ToString() + "\n" + streetList.SelectedValue.ToString();
            //this.storeStreet = streetList.SelectedValue.ToString();

            var selectedRow = (streetList.SelectedItem as DataRowView);
            
            this.storeStreet = selectedRow["street"].ToString();
            this.storeLocation = cityList.SelectedValue.ToString() + "\n" + storeStreet;
            this.storeID = Int32.Parse(selectedRow["store_id"].ToString());
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void populateCityList()
        {
            string query = "select city,store_id from Store inner join Address on Store.address_id = Address.address_id";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {

                DataTable cities = new DataTable();
                adapter.Fill(cities);
                cityList.DisplayMember = "city";
                cityList.ValueMember = "city";
                //cityList.ValueMember = "store_id";
                cityList.DataSource = cities;

               
            }
        }

        private void populateStreetList()
        {
            string query = "select street,store_id from Address inner join Store on Store.address_id = Address.address_id where city=@cityName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@cityName", cityList.SelectedValue);
                DataTable streets = new DataTable();
                adapter.Fill(streets);

                streetList.DisplayMember = "street";
                //streetList.ValueMember = "street";
                streetList.DataSource = streets;
            }
        }

        private void cityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateStreetList();

        }

        private void streetList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
