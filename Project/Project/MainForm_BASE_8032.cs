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
    public partial class FormMain : Form
    {
        string connectionString;
        //string storeID;
        string storeLocation;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Project.Properties.Settings.ZaraDBConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            using(selectStore ss1 = new selectStore())
            {
                ss1.connectionString = connectionString;
                var result = ss1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    storeLocation = ss1.storeLocation;
                    
                }
            }
            store_lbl.Text = storeLocation;
            
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
