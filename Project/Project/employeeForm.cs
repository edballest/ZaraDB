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
    public partial class employeeForm : Form
    {
        int chapuza = 0;
        SqlConnection connection;
        public string connectionString { get; set; }

        DataTable produtcTable = new DataTable();

        public employeeForm()
        {
            InitializeComponent();
        }

        private void employeeForm_Load(object sender, EventArgs e)
        {
            department_lbl.Enabled = false;
            department_cb.Enabled = false;
            category_lbl.Enabled = false;
            category_cb.Enabled = false;
            type_lbl.Enabled = false;
            type_cb.Enabled = false;

            getProductTable();
            PopulateAllForms();
        }

        
        private void getProductTable()
        {
            string query = "SELECT * FROM product INNER JOIN category ON category.type=product.type ORDER BY description ASC";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(produtcTable);
            }
        }

        private void PopulateAllForms()
        {
            PopulateCBs();
            PopulateProductList();
        }

        private void PopulateProductList()
        {
            DataView View = new DataView(produtcTable);
            //string query = "department = '" + department_cb.SelectedValue.ToString() + "' " +
            //            "AND category = '" + category_cb.SelectedValue.ToString() + "' " +
            //            "AND type = '" + type_cb.SelectedValue.ToString() + "'";
            //View.RowFilter = query;

            DataTable displayTable = View.ToTable(true, "description");  //This is to display only distinct values.


            products_lb.DisplayMember = "description";
            products_lb.ValueMember = "description";
            products_lb.DataSource = displayTable;
        }

        private void PopulateCBs()
        {
            DataView View = new DataView(produtcTable);                  //This is to display only distinct values.
            DataTable departments = View.ToTable(true, "department");
            DataTable types = View.ToTable(true, "type");
            DataTable categories = View.ToTable(true, "category");

            
            department_cb.DisplayMember = "department";
            department_cb.ValueMember = "department";
            department_cb.DataSource = departments;
            
            category_cb.DisplayMember = "category";
            category_cb.ValueMember = "category";
            category_cb.DataSource = categories;

            type_cb.DisplayMember = "type";
            type_cb.ValueMember = "type";
            type_cb.DataSource = types;
        }

        private void department_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filter_CB_CheckedChanged(object sender, EventArgs e)
        {
            department_lbl.Enabled = filter_CB.Checked;
            department_cb.Enabled = filter_CB.Checked;
            category_lbl.Enabled = filter_CB.Checked;
            category_cb.Enabled= filter_CB.Checked;
            type_lbl.Enabled = filter_CB.Checked;
            type_cb.Enabled= filter_CB.Checked;
        }
    }
}
