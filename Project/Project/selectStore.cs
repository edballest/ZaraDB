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
        public string storeID { get; set; }
        //public string storeLocation { get; set; }
        public string connectionString { get; set; }

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
            //igual aquí puedo meter un query para que devuelva el storeID
            this.storeID = cityList.SelectedValue.ToString() + "\n" + streetList.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void populateCityList()
        {
            string query = "select city,store_id from Store inner join Address on Store.address_id = Address.address_id";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                //DataTable StoreId = new DataTable();
                //adapter.Fill(StoreId);
                //cityList.DisplayMember = "city";
                //cityList.ValueMember = "store_id";
                ////cityList.ValueMember = "store_id";
                //cityList.DataSource = StoreId;
                //this.storeLocation = cityList.SelectedValue.ToString();

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
            string query = "select street from Address inner join Store on Store.address_id = Address.address_id where city=@cityName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@cityName", cityList.SelectedValue);
                DataTable streets = new DataTable();
                adapter.Fill(streets);

                streetList.DisplayMember = "street";
                streetList.ValueMember = "street";
                streetList.DataSource = streets;
            }
        }

        private void cityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateStreetList();

        }
    }
}
