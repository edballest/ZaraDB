namespace Project
{
    partial class profile
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
            this.creditCard_btn = new System.Windows.Forms.Button();
            this.editProf_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditCard_btn
            // 
            this.creditCard_btn.Location = new System.Drawing.Point(81, 71);
            this.creditCard_btn.Name = "creditCard_btn";
            this.creditCard_btn.Size = new System.Drawing.Size(128, 29);
            this.creditCard_btn.TabIndex = 0;
            this.creditCard_btn.Text = "Edit Credit Cards";
            this.creditCard_btn.UseVisualStyleBackColor = true;
            this.creditCard_btn.Click += new System.EventHandler(this.creditCard_btn_Click);
            // 
            // editProf_btn
            // 
            this.editProf_btn.Location = new System.Drawing.Point(81, 116);
            this.editProf_btn.Name = "editProf_btn";
            this.editProf_btn.Size = new System.Drawing.Size(128, 29);
            this.editProf_btn.TabIndex = 1;
            this.editProf_btn.Text = "Edit Profile";
            this.editProf_btn.UseVisualStyleBackColor = true;
            this.editProf_btn.Click += new System.EventHandler(this.editProf_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(116, 25);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Name";
            // 
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.editProf_btn);
            this.Controls.Add(this.creditCard_btn);
            this.Name = "profile";
            this.Text = "profile";
            this.Load += new System.EventHandler(this.profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button creditCard_btn;
        private System.Windows.Forms.Button editProf_btn;
        private System.Windows.Forms.Label name_lbl;
    }
}