namespace Project
{
    partial class selectStore
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.streetList = new System.Windows.Forms.ListBox();
            this.cityList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.BackColor = System.Drawing.Color.Transparent;
            this.OK_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK_btn.FlatAppearance.BorderSize = 4;
            this.OK_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OK_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_btn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OK_btn.Location = new System.Drawing.Point(610, 411);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(212, 63);
            this.OK_btn.TabIndex = 1;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = false;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // streetList
            // 
            this.streetList.BackColor = System.Drawing.Color.White;
            this.streetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.streetList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetList.FormattingEnabled = true;
            this.streetList.ItemHeight = 19;
            this.streetList.Location = new System.Drawing.Point(24, 379);
            this.streetList.Name = "streetList";
            this.streetList.Size = new System.Drawing.Size(198, 95);
            this.streetList.TabIndex = 3;
            this.streetList.SelectedIndexChanged += new System.EventHandler(this.streetList_SelectedIndexChanged);
            // 
            // cityList
            // 
            this.cityList.BackColor = System.Drawing.Color.White;
            this.cityList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityList.FormattingEnabled = true;
            this.cityList.ItemHeight = 19;
            this.cityList.Location = new System.Drawing.Point(24, 38);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(198, 304);
            this.cityList.TabIndex = 2;
            this.cityList.SelectedIndexChanged += new System.EventHandler(this.cityList_SelectedIndexChanged);
            // 
            // selectStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.zara_michiganavenue_chicago2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 510);
            this.Controls.Add(this.streetList);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.OK_btn);
            this.MaximizeBox = false;
            this.Name = "selectStore";
            this.ShowIcon = false;
            this.Text = "WELCOME TO ZARA";
            this.Load += new System.EventHandler(this.selectStore_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.ListBox streetList;
        private System.Windows.Forms.ListBox cityList;
    }
}