namespace Project
{
    partial class catalog
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
            this.departmentList = new System.Windows.Forms.ListBox();
            this.categoryList = new System.Windows.Forms.ListBox();
            this.typeList = new System.Windows.Forms.ListBox();
            this.descriptionList = new System.Windows.Forms.ListBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.decorativo_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(31, 57);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(120, 56);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(31, 148);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(120, 95);
            this.categoryList.TabIndex = 1;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.categoryList_SelectedIndexChanged);
            // 
            // typeList
            // 
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(181, 57);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(120, 186);
            this.typeList.TabIndex = 2;
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.typeList_SelectedIndexChanged);
            // 
            // descriptionList
            // 
            this.descriptionList.FormattingEnabled = true;
            this.descriptionList.Location = new System.Drawing.Point(339, 57);
            this.descriptionList.Name = "descriptionList";
            this.descriptionList.Size = new System.Drawing.Size(120, 186);
            this.descriptionList.TabIndex = 3;
            this.descriptionList.SelectedIndexChanged += new System.EventHandler(this.descriptionList_SelectedIndexChanged);
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(476, 57);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(31, 13);
            this.price_lbl.TabIndex = 4;
            this.price_lbl.Text = "Price";
            // 
            // decorativo_lbl
            // 
            this.decorativo_lbl.AutoSize = true;
            this.decorativo_lbl.Location = new System.Drawing.Point(514, 57);
            this.decorativo_lbl.Name = "decorativo_lbl";
            this.decorativo_lbl.Size = new System.Drawing.Size(13, 13);
            this.decorativo_lbl.TabIndex = 5;
            this.decorativo_lbl.Text = "$";
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 379);
            this.Controls.Add(this.decorativo_lbl);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.descriptionList);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.departmentList);
            this.Name = "catalog";
            this.Text = "catalog";
            this.Load += new System.EventHandler(this.catalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox departmentList;
        private System.Windows.Forms.ListBox categoryList;
        private System.Windows.Forms.ListBox typeList;
        private System.Windows.Forms.ListBox descriptionList;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label decorativo_lbl;
    }
}