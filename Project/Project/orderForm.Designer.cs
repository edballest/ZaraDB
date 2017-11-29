namespace Project
{
    partial class orderForm
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
            this.info_lbl = new System.Windows.Forms.Label();
            this.quantity_NUD = new System.Windows.Forms.NumericUpDown();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.placeOrder_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(12, 100);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(0, 13);
            this.info_lbl.TabIndex = 0;
            // 
            // quantity_NUD
            // 
            this.quantity_NUD.Location = new System.Drawing.Point(165, 46);
            this.quantity_NUD.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.quantity_NUD.Name = "quantity_NUD";
            this.quantity_NUD.Size = new System.Drawing.Size(110, 20);
            this.quantity_NUD.TabIndex = 1;
            this.quantity_NUD.ValueChanged += new System.EventHandler(this.quantity_NUD_ValueChanged);
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.Location = new System.Drawing.Point(12, 50);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(118, 13);
            this.quantity_lbl.TabIndex = 2;
            this.quantity_lbl.Text = "PRODUCT QUANTITY";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(23, 203);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(131, 32);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "CANCEL";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // placeOrder_btn
            // 
            this.placeOrder_btn.Location = new System.Drawing.Point(165, 203);
            this.placeOrder_btn.Name = "placeOrder_btn";
            this.placeOrder_btn.Size = new System.Drawing.Size(131, 32);
            this.placeOrder_btn.TabIndex = 4;
            this.placeOrder_btn.Text = "PLACE ORDER";
            this.placeOrder_btn.UseVisualStyleBackColor = true;
            this.placeOrder_btn.Click += new System.EventHandler(this.placeOrder_btn_Click);
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.placeOrder_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.quantity_lbl);
            this.Controls.Add(this.quantity_NUD);
            this.Controls.Add(this.info_lbl);
            this.Name = "orderForm";
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantity_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label info_lbl;
        private System.Windows.Forms.NumericUpDown quantity_NUD;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button placeOrder_btn;
    }
}