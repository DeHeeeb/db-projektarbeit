namespace db_projektarbeit.View
{
    partial class Home
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
            this.CmdCustomer = new System.Windows.Forms.Button();
            this.CmdProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCustomer
            // 
            this.CmdCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCustomer.Location = new System.Drawing.Point(12, 12);
            this.CmdCustomer.Name = "CmdCustomer";
            this.CmdCustomer.Size = new System.Drawing.Size(275, 97);
            this.CmdCustomer.TabIndex = 0;
            this.CmdCustomer.Text = "Kunden-Verwaltung";
            this.CmdCustomer.UseVisualStyleBackColor = true;
            this.CmdCustomer.Click += new System.EventHandler(this.CmdCustomer_Click);
            // 
            // CmdProduct
            // 
            this.CmdProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdProduct.Location = new System.Drawing.Point(330, 12);
            this.CmdProduct.Name = "CmdProduct";
            this.CmdProduct.Size = new System.Drawing.Size(275, 97);
            this.CmdProduct.TabIndex = 1;
            this.CmdProduct.Text = "Produkt-Verwaltung";
            this.CmdProduct.UseVisualStyleBackColor = true;
            this.CmdProduct.Click += new System.EventHandler(this.CmdProduct_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 644);
            this.Controls.Add(this.CmdProduct);
            this.Controls.Add(this.CmdCustomer);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomer;
        private System.Windows.Forms.Button CmdProduct;
    }
}