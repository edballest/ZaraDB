namespace Project
{
    partial class insertCreditCardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.creditCard_tb = new System.Windows.Forms.TextBox();
            this.done_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLEASE INSERT VAILD CREDIT CARD NUMBER";
            // 
            // creditCard_tb
            // 
            this.creditCard_tb.Location = new System.Drawing.Point(26, 67);
            this.creditCard_tb.Name = "creditCard_tb";
            this.creditCard_tb.Size = new System.Drawing.Size(344, 20);
            this.creditCard_tb.TabIndex = 1;
            // 
            // done_btn
            // 
            this.done_btn.Location = new System.Drawing.Point(277, 112);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(93, 27);
            this.done_btn.TabIndex = 2;
            this.done_btn.Text = "DONE";
            this.done_btn.UseVisualStyleBackColor = true;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // insertCreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 151);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.creditCard_tb);
            this.Controls.Add(this.label1);
            this.Name = "insertCreditCardForm";
            this.Text = "insertCreditCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox creditCard_tb;
        private System.Windows.Forms.Button done_btn;
    }
}