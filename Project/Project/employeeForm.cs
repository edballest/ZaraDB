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
        
        SqlConnection connection;
        public string connectionString { get; set; }
        public int store_id { get; set; }

        DataTable produtcTable = new DataTable();
        enum ComboBoxes { All, Dep, Cat, Type };


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

            debug_dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        
        private void getProductTable()
        {
            produtcTable.Clear();
            string query = "SELECT * " +
                "FROM product INNER JOIN category ON category.type=product.type " +
                "INNER JOIN Inventory ON product.UPC_code = Inventory.UPC_code " +
                "WHERE store_id = @storeID " +
                "ORDER BY description ASC";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@storeID", this.store_id);
                adapter.Fill(produtcTable);
            }
        }

        private void PopulateAllForms(Boolean filter = false)
        {
            PopulateFilterCBs(ComboBoxes.All);
            PopulateProductList(filter);
        }

        private void PopulateProductList(Boolean filter = false)
        {
            DataView View = new DataView(produtcTable);
            if (filter)
            {
                string query = "department = '" + department_cb.SelectedValue.ToString() + "' " +
                                "AND category = '" + category_cb.SelectedValue.ToString() + "' ";
                                //"AND type = '" + type_cb.SelectedValue.ToString() + "'";
                View.RowFilter = query;
            }

            DataTable displayTable = View.ToTable(true, "description");  //This is to display only distinct values.


            products_lb.DisplayMember = "description";
            products_lb.ValueMember = "description";
            products_lb.DataSource = displayTable;
        }

        private void PopulateFilterCBs(ComboBoxes CBs = ComboBoxes.All)
        {
            DataView View = new DataView(produtcTable);                  

            if (CBs == ComboBoxes.All)
            {
                DataTable departments = View.ToTable(true, "department"); //This is to display only distinct values.
                department_cb.DisplayMember = "department";
                department_cb.ValueMember = "department";
                department_cb.DataSource = departments;
            }

            if (CBs == ComboBoxes.All || CBs == ComboBoxes.Dep)
            {
                View.RowFilter = "department = '" + department_cb.SelectedValue.ToString() + "' ";
                DataTable categories = View.ToTable(true, "category");

                category_cb.DisplayMember = "category";
                category_cb.ValueMember = "category";
                category_cb.DataSource = categories;
            }


            if (CBs == ComboBoxes.All || CBs == ComboBoxes.Dep || CBs == ComboBoxes.Cat)
            {
                View.RowFilter = "category = '" + category_cb.SelectedValue.ToString() + "' ";
                DataTable types = View.ToTable(true, "type");

                type_cb.DisplayMember = "type";
                type_cb.ValueMember = "type";
                type_cb.DataSource = types;
            }
        }

        private void department_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFilterCBs(ComboBoxes.Dep);
            PopulateProductList(filter_CB.Checked);
        }

        private void category_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateFilterCBs(ComboBoxes.Cat);
            PopulateProductList(filter_CB.Checked);
        }

        private void type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProductList(filter_CB.Checked);
        }

        private void filter_CB_CheckedChanged(object sender, EventArgs e)
        {
            department_lbl.Enabled = filter_CB.Checked;
            department_cb.Enabled = filter_CB.Checked;
            category_lbl.Enabled = filter_CB.Checked;
            category_cb.Enabled= filter_CB.Checked;
            //type_lbl.Enabled = filter_CB.Checked;
            //type_cb.Enabled= filter_CB.Checked;
            type_lbl.Enabled = false;
            type_cb.Enabled= false;

            PopulateProductList(filter_CB.Checked);
        }

        private void products_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            order_btn.Enabled = false;
            update_btn.Enabled = false;

            DataView View = new DataView(produtcTable);
            View.RowFilter = "description = '" + products_lb.SelectedValue.ToString() + "' ";
            DataTable productInfo = View.ToTable(false,"UPC_code", "size", "color", "price","quantity");

            debug_dg.DataSource = productInfo;
        }

        private void debug_dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            order_btn.Enabled = true;
            update_btn.Enabled = true;
            //label1.Text = debug_dg.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            int products_lb_SelectedIndex;
            products_lb_SelectedIndex=products_lb.SelectedIndex;

            this.Hide();
            using (orderForm oF1 = new orderForm())
            {
                oF1.connectionString = this.connectionString;
                oF1.store_id = this.store_id;
                oF1.UPC_code= debug_dg.SelectedRows[0].Cells[0].Value.ToString();
                oF1.currentQuantity= Int32.Parse(debug_dg.SelectedRows[0].Cells[4].Value.ToString());
                oF1.ShowDialog();
            }
            updateProducts(products_lb_SelectedIndex);
            this.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int products_lb_SelectedIndex;
            products_lb_SelectedIndex = products_lb.SelectedIndex;

            this.Hide();
            using (updateForm uF1 = new updateForm())
            {
                uF1.connectionString = this.connectionString;
                uF1.store_id = this.store_id;
                uF1.UPC_code = debug_dg.SelectedRows[0].Cells[0].Value.ToString();
                uF1.currentPrice = System.Decimal.Parse(debug_dg.SelectedRows[0].Cells[3].Value.ToString());
                uF1.currentQuantity = Int32.Parse(debug_dg.SelectedRows[0].Cells[4].Value.ToString());
                uF1.ShowDialog();
            }
            updateProducts(products_lb_SelectedIndex);
            this.Show();
        }

        private void updateProducts(int products_lb_SelectedIndex)
        {
            getProductTable();
            PopulateProductList();
            products_lb.SelectedIndex = products_lb_SelectedIndex;
        }
    }
}
