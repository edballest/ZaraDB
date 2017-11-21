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
            this.storeID = cityList.SelectedValue.ToString();
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
                cityList.ValueMember = "store_id";
                cityList.DataSource = cities;
            }
        }
    }
}
