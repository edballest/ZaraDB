namespace Project
{
    partial class employeeForm
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
            this.department_cb = new System.Windows.Forms.ComboBox();
            this.department_lbl = new System.Windows.Forms.Label();
            this.category_lbl = new System.Windows.Forms.Label();
            this.category_cb = new System.Windows.Forms.ComboBox();
            this.type_lbl = new System.Windows.Forms.Label();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.products_lb = new System.Windows.Forms.ListBox();
            this.filter_CB = new System.Windows.Forms.CheckBox();
            this.products_lbl = new System.Windows.Forms.Label();
            this.debug_dg = new System.Windows.Forms.DataGridView();
            this.order_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.debug_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // department_cb
            // 
            this.department_cb.FormattingEnabled = true;
            this.department_cb.Location = new System.Drawing.Point(12, 61);
            this.department_cb.Name = "department_cb";
            this.department_cb.Size = new System.Drawing.Size(121, 21);
            this.department_cb.TabIndex = 0;
            this.department_cb.SelectedIndexChanged += new System.EventHandler(this.department_cb_SelectedIndexChanged);
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.Location = new System.Drawing.Point(12, 40);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(82, 13);
            this.department_lbl.TabIndex = 1;
            this.department_lbl.Text = "DEPARTMENT";
            // 
            // category_lbl
            // 
            this.category_lbl.AutoSize = true;
            this.category_lbl.Location = new System.Drawing.Point(12, 90);
            this.category_lbl.Name = "category_lbl";
            this.category_lbl.Size = new System.Drawing.Size(66, 13);
            this.category_lbl.TabIndex = 3;
            this.category_lbl.Text = "CATEGORY";
            // 
            // category_cb
            // 
            this.category_cb.FormattingEnabled = true;
            this.category_cb.Location = new System.Drawing.Point(12, 111);
            this.category_cb.Name = "category_cb";
            this.category_cb.Size = new System.Drawing.Size(121, 21);
            this.category_cb.TabIndex = 2;
            this.category_cb.SelectedIndexChanged += new System.EventHandler(this.category_cb_SelectedIndexChanged);
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.Location = new System.Drawing.Point(12, 140);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(35, 13);
            this.type_lbl.TabIndex = 5;
            this.type_lbl.Text = "TYPE";
            // 
            // type_cb
            // 
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Location = new System.Drawing.Point(12, 161);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(121, 21);
            this.type_cb.TabIndex = 4;
            this.type_cb.SelectedIndexChanged += new System.EventHandler(this.type_cb_SelectedIndexChanged);
            // 
            // products_lb
            // 
            this.products_lb.FormattingEnabled = true;
            this.products_lb.Location = new System.Drawing.Point(179, 61);
            this.products_lb.Name = "products_lb";
            this.products_lb.Size = new System.Drawing.Size(304, 121);
            this.products_lb.TabIndex = 6;
            this.products_lb.SelectedIndexChanged += new System.EventHandler(this.products_lb_SelectedIndexChanged);
            // 
            // filter_CB
            // 
            this.filter_CB.AutoSize = true;
            this.filter_CB.Location = new System.Drawing.Point(12, 206);
            this.filter_CB.Name = "filter_CB";
            this.filter_CB.Size = new System.Drawing.Size(48, 17);
            this.filter_CB.TabIndex = 7;
            this.filter_CB.Text = "Filter";
            this.filter_CB.UseVisualStyleBackColor = true;
            this.filter_CB.CheckedChanged += new System.EventHandler(this.filter_CB_CheckedChanged);
            // 
            // products_lbl
            // 
            this.products_lbl.AutoSize = true;
            this.products_lbl.Location = new System.Drawing.Point(176, 40);
            this.products_lbl.Name = "products_lbl";
            this.products_lbl.Size = new System.Drawing.Size(67, 13);
            this.products_lbl.TabIndex = 8;
            this.products_lbl.Text = "PRODUCTS";
            // 
            // debug_dg
            // 
            this.debug_dg.AllowUserToAddRows = false;
            this.debug_dg.AllowUserToDeleteRows = false;
            this.debug_dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.debug_dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.debug_dg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.debug_dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug_dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.debug_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debug_dg.Location = new System.Drawing.Point(179, 216);
            this.debug_dg.Name = "debug_dg";
            this.debug_dg.ReadOnly = true;
            this.debug_dg.Size = new System.Drawing.Size(583, 231);
            this.debug_dg.TabIndex = 13;
            this.debug_dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.debug_dg_CellContentClick);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(536, 145);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(156, 36);
            this.order_btn.TabIndex = 14;
            this.order_btn.Text = "ORDER";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Location = new System.Drawing.Point(536, 96);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(156, 36);
            this.update_btn.TabIndex = 15;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 459);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.order_btn);
            this.Controls.Add(this.debug_dg);
            this.Controls.Add(this.products_lbl);
            this.Controls.Add(this.filter_CB);
            this.Controls.Add(this.products_lb);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.type_cb);
            this.Controls.Add(this.category_lbl);
            this.Controls.Add(this.category_cb);
            this.Controls.Add(this.department_lbl);
            this.Controls.Add(this.department_cb);
            this.MaximizeBox = false;
            this.Name = "employeeForm";
            this.ShowIcon = false;
            this.Text = "employeeForm";
            this.Load += new System.EventHandler(this.employeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debug_dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox department_cb;
        private System.Windows.Forms.Label department_lbl;
        private System.Windows.Forms.Label category_lbl;
        private System.Windows.Forms.ComboBox category_cb;
        private System.Windows.Forms.Label type_lbl;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.ListBox products_lb;
        private System.Windows.Forms.CheckBox filter_CB;
        private System.Windows.Forms.Label products_lbl;
        private System.Windows.Forms.DataGridView debug_dg;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button update_btn;
    }
}