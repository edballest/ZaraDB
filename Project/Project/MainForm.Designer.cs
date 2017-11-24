namespace Project
{
    partial class FormMain
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
            this.employee_btn = new System.Windows.Forms.Button();
            this.logIn_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.checkOut_btn = new System.Windows.Forms.Button();
            this.catalog_btn = new System.Windows.Forms.Button();
            this.store_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employee_btn
            // 
            this.employee_btn.Location = new System.Drawing.Point(18, 10);
            this.employee_btn.Name = "employee_btn";
            this.employee_btn.Size = new System.Drawing.Size(250, 52);
            this.employee_btn.TabIndex = 0;
            this.employee_btn.Text = "EMPLOYEE";
            this.employee_btn.UseVisualStyleBackColor = true;
            this.employee_btn.Click += new System.EventHandler(this.employee_btn_Click);
            // 
            // logIn_btn
            // 
            this.logIn_btn.Location = new System.Drawing.Point(865, 10);
            this.logIn_btn.Name = "logIn_btn";
            this.logIn_btn.Size = new System.Drawing.Size(127, 52);
            this.logIn_btn.TabIndex = 1;
            this.logIn_btn.Text = "LOG IN";
            this.logIn_btn.UseVisualStyleBackColor = true;
            this.logIn_btn.Click += new System.EventHandler(this.logIn_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(1014, 10);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(123, 51);
            this.register_btn.TabIndex = 2;
            this.register_btn.Text = "REGISTER";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // checkOut_btn
            // 
            this.checkOut_btn.Location = new System.Drawing.Point(18, 71);
            this.checkOut_btn.Name = "checkOut_btn";
            this.checkOut_btn.Size = new System.Drawing.Size(517, 590);
            this.checkOut_btn.TabIndex = 3;
            this.checkOut_btn.Text = "CHECK OUT";
            this.checkOut_btn.UseVisualStyleBackColor = true;
            this.checkOut_btn.Click += new System.EventHandler(this.checkOut_btn_Click);
            // 
            // catalog_btn
            // 
            this.catalog_btn.Location = new System.Drawing.Point(609, 71);
            this.catalog_btn.Name = "catalog_btn";
            this.catalog_btn.Size = new System.Drawing.Size(528, 590);
            this.catalog_btn.TabIndex = 4;
            this.catalog_btn.Text = "CATALOG";
            this.catalog_btn.UseVisualStyleBackColor = true;
            this.catalog_btn.Click += new System.EventHandler(this.catalog_btn_Click);
            // 
            // store_lbl
            // 
            this.store_lbl.AutoSize = true;
            this.store_lbl.Location = new System.Drawing.Point(558, 29);
            this.store_lbl.Name = "store_lbl";
            this.store_lbl.Size = new System.Drawing.Size(0, 13);
            this.store_lbl.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 700);
            this.Controls.Add(this.store_lbl);
            this.Controls.Add(this.catalog_btn);
            this.Controls.Add(this.checkOut_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.logIn_btn);
            this.Controls.Add(this.employee_btn);
            this.Name = "FormMain";
            this.Text = "ZARA";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employee_btn;
        private System.Windows.Forms.Button logIn_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button checkOut_btn;
        private System.Windows.Forms.Button catalog_btn;
        private System.Windows.Forms.Label store_lbl;
    }
}

