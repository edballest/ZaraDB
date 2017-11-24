namespace Project
{
    partial class ChooseCreditCard
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
            this.finish_btn = new System.Windows.Forms.Button();
            this.creditCardList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // finish_btn
            // 
            this.finish_btn.Location = new System.Drawing.Point(166, 206);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(75, 23);
            this.finish_btn.TabIndex = 0;
            this.finish_btn.Text = "FINISH";
            this.finish_btn.UseVisualStyleBackColor = true;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // creditCardList
            // 
            this.creditCardList.FormattingEnabled = true;
            this.creditCardList.Location = new System.Drawing.Point(55, 55);
            this.creditCardList.Name = "creditCardList";
            this.creditCardList.Size = new System.Drawing.Size(120, 95);
            this.creditCardList.TabIndex = 1;
            // 
            // ChooseCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.creditCardList);
            this.Controls.Add(this.finish_btn);
            this.Name = "ChooseCreditCard";
            this.Text = "ChooseCreditCard";
            this.Load += new System.EventHandler(this.ChooseCreditCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.ListBox creditCardList;
    }
}