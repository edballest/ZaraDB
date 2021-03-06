﻿namespace Project
{
    partial class CheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.upcCode_lbl = new System.Windows.Forms.Label();
            this.qty_lbl = new System.Windows.Forms.Label();
            this.upcCode_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.total_lbl = new System.Windows.Forms.Label();
            this.decor_lbl = new System.Windows.Forms.Label();
            this.tot_lbl = new System.Windows.Forms.Label();
            this.itemsList = new System.Windows.Forms.ListBox();
            this.creditCard_lbl = new System.Windows.Forms.Label();
            this.creditCardCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.Location = new System.Drawing.Point(163, 223);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(108, 23);
            this.checkOut_btn.TabIndex = 0;
            this.checkOut_btn.Text = "CHECK OUT";
            this.checkOut_btn.UseVisualStyleBackColor = true;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
            // 
            // upcCode_lbl
            // 
            this.upcCode_lbl.AutoSize = true;
            this.upcCode_lbl.Location = new System.Drawing.Point(12, 48);
            this.upcCode_lbl.Name = "upcCode_lbl";
            this.upcCode_lbl.Size = new System.Drawing.Size(65, 13);
            this.upcCode_lbl.TabIndex = 1;
            this.upcCode_lbl.Text = "UPC_CODE";
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.Location = new System.Drawing.Point(134, 48);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(29, 13);
            this.qty_lbl.TabIndex = 2;
            this.qty_lbl.Text = "QTY";
            // 
            // upcCode_txt
            // 
            this.upcCode_txt.Location = new System.Drawing.Point(12, 75);
            this.upcCode_txt.Name = "upcCode_txt";
            this.upcCode_txt.Size = new System.Drawing.Size(100, 20);
            this.upcCode_txt.TabIndex = 3;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(137, 75);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(38, 20);
            this.qty_txt.TabIndex = 4;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(111, 13);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 5;
            this.name_lbl.Text = "label1";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(197, 75);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add to BAG";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(64, 223);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(31, 13);
            this.total_lbl.TabIndex = 7;
            this.total_lbl.Text = "Price";
            // 
            // decor_lbl
            // 
            this.decor_lbl.AutoSize = true;
            this.decor_lbl.Location = new System.Drawing.Point(121, 223);
            this.decor_lbl.Name = "decor_lbl";
            this.decor_lbl.Size = new System.Drawing.Size(13, 13);
            this.decor_lbl.TabIndex = 8;
            this.decor_lbl.Text = "$";
            // 
            // tot_lbl
            // 
            this.tot_lbl.AutoSize = true;
            this.tot_lbl.Location = new System.Drawing.Point(18, 223);
            this.tot_lbl.Name = "tot_lbl";
            this.tot_lbl.Size = new System.Drawing.Size(31, 13);
            this.tot_lbl.TabIndex = 9;
            this.tot_lbl.Text = "Total";
            // 
            // itemsList
            // 
            this.itemsList.FormattingEnabled = true;
            this.itemsList.Location = new System.Drawing.Point(12, 108);
            this.itemsList.Name = "itemsList";
            this.itemsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.itemsList.Size = new System.Drawing.Size(100, 95);
            this.itemsList.TabIndex = 10;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // creditCard_lbl
            // 
            this.creditCard_lbl.AutoSize = true;
            this.creditCard_lbl.Location = new System.Drawing.Point(134, 157);
            this.creditCard_lbl.Name = "creditCard_lbl";
            this.creditCard_lbl.Size = new System.Drawing.Size(87, 13);
            this.creditCard_lbl.TabIndex = 12;
            this.creditCard_lbl.Text = "CREDIT CARDS";
            // 
            // creditCardCB
            // 
            this.creditCardCB.FormattingEnabled = true;
            this.creditCardCB.Location = new System.Drawing.Point(137, 182);
            this.creditCardCB.Name = "creditCardCB";
            this.creditCardCB.Size = new System.Drawing.Size(134, 21);
            this.creditCardCB.TabIndex = 13;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 257);
            this.Controls.Add(this.creditCardCB);
            this.Controls.Add(this.creditCard_lbl);
            this.Controls.Add(this.itemsList);
            this.Controls.Add(this.tot_lbl);
            this.Controls.Add(this.decor_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.upcCode_txt);
            this.Controls.Add(this.qty_lbl);
            this.Controls.Add(this.upcCode_lbl);
            this.Controls.Add(this.checkOut_btn);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkOut_btn;
        private System.Windows.Forms.Label upcCode_lbl;
        private System.Windows.Forms.Label qty_lbl;
        private System.Windows.Forms.TextBox upcCode_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label decor_lbl;
        private System.Windows.Forms.Label tot_lbl;
        private System.Windows.Forms.ListBox itemsList;
        private System.Windows.Forms.Label creditCard_lbl;
        private System.Windows.Forms.ComboBox creditCardCB;
    }
}