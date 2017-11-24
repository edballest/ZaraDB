namespace Project
{
    partial class CustomerCheckOut
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
            this.continue_btn = new System.Windows.Forms.Button();
            this.pswd_txt = new System.Windows.Forms.TextBox();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pswd_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.logIn_lbl = new System.Windows.Forms.Label();
            this.guest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(74, 178);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(75, 23);
            this.continue_btn.TabIndex = 9;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // pswd_txt
            // 
            this.pswd_txt.Location = new System.Drawing.Point(64, 138);
            this.pswd_txt.Name = "pswd_txt";
            this.pswd_txt.Size = new System.Drawing.Size(100, 20);
            this.pswd_txt.TabIndex = 8;
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(64, 107);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 7;
            // 
            // pswd_lbl
            // 
            this.pswd_lbl.AutoSize = true;
            this.pswd_lbl.Location = new System.Drawing.Point(9, 142);
            this.pswd_lbl.Name = "pswd_lbl";
            this.pswd_lbl.Size = new System.Drawing.Size(52, 13);
            this.pswd_lbl.TabIndex = 6;
            this.pswd_lbl.Text = "password";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(12, 110);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(31, 13);
            this.email_lbl.TabIndex = 5;
            this.email_lbl.Text = "email";
            // 
            // logIn_lbl
            // 
            this.logIn_lbl.AutoSize = true;
            this.logIn_lbl.Location = new System.Drawing.Point(88, 54);
            this.logIn_lbl.Name = "logIn_lbl";
            this.logIn_lbl.Size = new System.Drawing.Size(43, 13);
            this.logIn_lbl.TabIndex = 10;
            this.logIn_lbl.Text = "LOG IN";
            // 
            // guest_btn
            // 
            this.guest_btn.Location = new System.Drawing.Point(274, 178);
            this.guest_btn.Name = "guest_btn";
            this.guest_btn.Size = new System.Drawing.Size(75, 23);
            this.guest_btn.TabIndex = 12;
            this.guest_btn.Text = "GUEST?";
            this.guest_btn.UseVisualStyleBackColor = true;
            this.guest_btn.Click += new System.EventHandler(this.guest_btn_Click);
            // 
            // CustomerCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.guest_btn);
            this.Controls.Add(this.logIn_lbl);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.pswd_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.pswd_lbl);
            this.Controls.Add(this.email_lbl);
            this.Name = "CustomerCheckOut";
            this.Text = "CustomerCheckOut";
            this.Load += new System.EventHandler(this.CustomerCheckOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continue_btn;
        private System.Windows.Forms.TextBox pswd_txt;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label pswd_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label logIn_lbl;
        private System.Windows.Forms.Button guest_btn;
    }
}