namespace Project
{
    partial class updateForm
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
            this.UPC_code_lbl = new System.Windows.Forms.Label();
            this.price_UD = new System.Windows.Forms.NumericUpDown();
            this.price_lbl = new System.Windows.Forms.Label();
            this.quantity_UD = new System.Windows.Forms.NumericUpDown();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.price_UD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_UD)).BeginInit();
            this.SuspendLayout();
            // 
            // UPC_code_lbl
            // 
            this.UPC_code_lbl.AutoSize = true;
            this.UPC_code_lbl.Location = new System.Drawing.Point(30, 10);
            this.UPC_code_lbl.Name = "UPC_code_lbl";
            this.UPC_code_lbl.Size = new System.Drawing.Size(59, 13);
            this.UPC_code_lbl.TabIndex = 0;
            this.UPC_code_lbl.Text = "UPC_code";
            // 
            // price_UD
            // 
            this.price_UD.DecimalPlaces = 2;
            this.price_UD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.price_UD.Location = new System.Drawing.Point(33, 58);
            this.price_UD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.price_UD.Name = "price_UD";
            this.price_UD.Size = new System.Drawing.Size(81, 20);
            this.price_UD.TabIndex = 1;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(30, 41);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(39, 13);
            this.price_lbl.TabIndex = 3;
            this.price_lbl.Text = "PRICE";
            // 
            // quantity_UD
            // 
            this.quantity_UD.Location = new System.Drawing.Point(131, 58);
            this.quantity_UD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.quantity_UD.Name = "quantity_UD";
            this.quantity_UD.Size = new System.Drawing.Size(81, 20);
            this.quantity_UD.TabIndex = 4;
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Location = new System.Drawing.Point(131, 41);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(62, 13);
            this.quantity_lbl.TabIndex = 5;
            this.quantity_lbl.Text = "QUANTITY";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(33, 100);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(81, 27);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(128, 100);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(84, 27);
            this.update_btn.TabIndex = 7;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 143);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.quantity_UD);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.price_UD);
            this.Controls.Add(this.UPC_code_lbl);
            this.Name = "updateForm";
            this.Text = "updateForm";
            this.Load += new System.EventHandler(this.updateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.price_UD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_UD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UPC_code_lbl;
        private System.Windows.Forms.NumericUpDown price_UD;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.NumericUpDown quantity_UD;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button update_btn;
    }
}