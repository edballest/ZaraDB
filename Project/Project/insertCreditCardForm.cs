using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class insertCreditCardForm : Form
    {
        public string credit_card_number;
        public insertCreditCardForm()
        {
            InitializeComponent();
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            if (creditCard_tb.Text != "")
            {
                bool a = true;
                foreach (char c in creditCard_tb.Text)
                {
                    if ((c < '0') || (c > '9'))
                    {
                        a = false;
                    }
                }
                if (a)
                {
                    this.credit_card_number = creditCard_tb.Text;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("INVALID CREDIT CARD NUMBER\nPLEASE INTRODUCE ONLY NUMBERS",
                                    "INVALID CREDIT CARD NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
