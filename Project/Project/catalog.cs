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
    public partial class catalog : Form
    {
        SqlConnection connection;
        public string connectionString { get; set; }
        public string storeCity { get; set; }
        public string storeStreet { get; set; }
        public string price { get; set; }

        public catalog()
        {
            InitializeComponent();
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            populateDepartmentList();
        }

        private void populateDepartmentList()
        {
            string query = "select distinct department from Product";
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable departments = new DataTable();
                adapter.Fill(departments);

                departmentList.DisplayMember = "department";
                departmentList.ValueMember = "department";
                departmentList.DataSource = departments;
            }
        }

        private void populateCategoryList()
        {
            string query = "select distinct category from Product inner join Category on Product.type=Category.type where department=@departmentName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@departmentName", departmentList.SelectedValue);
                DataTable categories = new DataTable();
                adapter.Fill(categories);

                categoryList.DisplayMember = "category";
                categoryList.ValueMember = "category";
                categoryList.DataSource = categories;
            }
        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateCategoryList();
        }

        private void populateTypeList()
        {
            string query = "select distinct Product.type from Category inner join Product on Product.type=Category.type where category=@categoryName and department=@departmentName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@departmentName", departmentList.SelectedValue);
                command.Parameters.AddWithValue("@categoryName", categoryList.SelectedValue);
                DataTable types = new DataTable();
                adapter.Fill(types);

                typeList.DisplayMember = "type";
                typeList.ValueMember = "type";
                typeList.DataSource = types;
            }
        }

        private void populateDescriptionList()
        {
            string query = "select distinct description from Category inner join Product on Product.type=Category.type where category=@categoryName and department=@departmentName and Product.type=@typeName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@departmentName", departmentList.SelectedValue);
                command.Parameters.AddWithValue("@categoryName", categoryList.SelectedValue);
                command.Parameters.AddWithValue("@typeName", typeList.SelectedValue);

                DataTable description = new DataTable();
                adapter.Fill(description);

                descriptionList.DisplayMember = "description";
                descriptionList.ValueMember = "UPC_code";
                descriptionList.DataSource = description;
            }
        }

        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateTypeList();
        }

        private void typeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateDescriptionList();
        }

        private void descriptionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select price from Store inner join Address on Store.address_id=Address.address_id, Inventory where (Inventory.store_id=Store.store_id and city=@storeCity and street=@streetName and UPC_code=@UPC_code)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                command.Parameters.AddWithValue("@UPC_code", descriptionList.SelectedValue);
                command.Parameters.AddWithValue("@cityName", storeCity);
                command.Parameters.AddWithValue("@streetName", storeStreet);
                
                //ESTO NO FUNCIONA
                price = command.ExecuteScalar().ToString();
                connection.Close();
                price_lbl.Text = price;
            }

        }
    }
}
