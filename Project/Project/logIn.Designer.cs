namespace Project
{
    partial class logIn
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
            this.email_lbl = new System.Windows.Forms.Label();
            this.pswd_lbl = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.pswd_txt = new System.Windows.Forms.TextBox();
            this.continue_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(11, 45);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(31, 13);
            this.email_lbl.TabIndex = 0;
            this.email_lbl.Text = "email";
            // 
            // pswd_lbl
            // 
            this.pswd_lbl.AutoSize = true;
            this.pswd_lbl.Location = new System.Drawing.Point(12, 113);
            this.pswd_lbl.Name = "pswd_lbl";
            this.pswd_lbl.Size = new System.Drawing.Size(52, 13);
            this.pswd_lbl.TabIndex = 1;
            this.pswd_lbl.Text = "password";
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(134, 45);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(100, 20);
            this.email_txt.TabIndex = 2;
            // 
            // pswd_txt
            // 
            this.pswd_txt.Location = new System.Drawing.Point(134, 106);
            this.pswd_txt.Name = "pswd_txt";
            this.pswd_txt.Size = new System.Drawing.Size(100, 20);
            this.pswd_txt.TabIndex = 3;
            // 
            // continue_btn
            // 
            this.continue_btn.Location = new System.Drawing.Point(146, 181);
            this.continue_btn.Name = "continue_btn";
            this.continue_btn.Size = new System.Drawing.Size(75, 23);
            this.continue_btn.TabIndex = 4;
            this.continue_btn.Text = "Continue";
            this.continue_btn.UseVisualStyleBackColor = true;
            this.continue_btn.Click += new System.EventHandler(this.continue_btn_Click);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.continue_btn);
            this.Controls.Add(this.pswd_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.pswd_lbl);
            this.Controls.Add(this.email_lbl);
            this.Name = "logIn";
            this.Text = "logIn";
            this.Load += new System.EventHandler(this.logIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label pswd_lbl;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.TextBox pswd_txt;
        private System.Windows.Forms.Button continue_btn;
    }
}