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
            this.cityList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(534, 237);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(167, 63);
            this.OK_btn.TabIndex = 1;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // cityList
            // 
            this.cityList.FormattingEnabled = true;
            this.cityList.Location = new System.Drawing.Point(81, 30);
            this.cityList.Name = "cityList";
            this.cityList.Size = new System.Drawing.Size(212, 225);
            this.cityList.TabIndex = 2;
            // 
            // selectStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 312);
            this.Controls.Add(this.cityList);
            this.Controls.Add(this.OK_btn);
            this.Name = "selectStore";
            this.Text = "selectStore";
            this.Load += new System.EventHandler(this.selectStore_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.ListBox cityList;
    }
}