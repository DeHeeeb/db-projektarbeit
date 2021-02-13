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
            this.components = new System.ComponentModel.Container();
            this.CmdCustomer = new System.Windows.Forms.Button();
            this.CmdProduct = new System.Windows.Forms.Button();
            this.CmdProductGroup = new System.Windows.Forms.Button();
            this.CmdOrder = new System.Windows.Forms.Button();
            this.CmdCity = new System.Windows.Forms.Button();
            this.TimerSQLCheck = new System.Windows.Forms.Timer(this.components);
            this.LblSQLCheck = new System.Windows.Forms.Label();
            this.CmdBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdCustomer
            // 
            this.CmdCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCustomer.Location = new System.Drawing.Point(342, 115);
            this.CmdCustomer.Name = "CmdCustomer";
            this.CmdCustomer.Size = new System.Drawing.Size(311, 97);
            this.CmdCustomer.TabIndex = 0;
            this.CmdCustomer.Text = "Kunden-Verwaltung";
            this.CmdCustomer.UseVisualStyleBackColor = true;
            this.CmdCustomer.Click += new System.EventHandler(this.CmdCustomer_Click);
            // 
            // CmdProduct
            // 
            this.CmdProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdProduct.Location = new System.Drawing.Point(11, 115);
            this.CmdProduct.Name = "CmdProduct";
            this.CmdProduct.Size = new System.Drawing.Size(325, 97);
            this.CmdProduct.TabIndex = 1;
            this.CmdProduct.Text = "Artikel-Verwaltung";
            this.CmdProduct.UseVisualStyleBackColor = true;
            this.CmdProduct.Click += new System.EventHandler(this.CmdProduct_Click);
            // 
            // CmdProductGroup
            // 
            this.CmdProductGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdProductGroup.Location = new System.Drawing.Point(11, 218);
            this.CmdProductGroup.Name = "CmdProductGroup";
            this.CmdProductGroup.Size = new System.Drawing.Size(325, 97);
            this.CmdProductGroup.TabIndex = 2;
            this.CmdProductGroup.Text = "Artikelgruppen-Verwaltung";
            this.CmdProductGroup.UseVisualStyleBackColor = true;
            this.CmdProductGroup.Click += new System.EventHandler(this.CmdProductGroup_Click);
            // 
            // CmdOrder
            // 
            this.CmdOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdOrder.Location = new System.Drawing.Point(11, 12);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(325, 97);
            this.CmdOrder.TabIndex = 3;
            this.CmdOrder.Text = "Auftrags-Verwaltung";
            this.CmdOrder.UseVisualStyleBackColor = true;
            this.CmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // CmdCity
            // 
            this.CmdCity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCity.Location = new System.Drawing.Point(342, 218);
            this.CmdCity.Name = "CmdCity";
            this.CmdCity.Size = new System.Drawing.Size(311, 97);
            this.CmdCity.TabIndex = 4;
            this.CmdCity.Text = "Städte-Verwaltung";
            this.CmdCity.UseVisualStyleBackColor = true;
            this.CmdCity.Click += new System.EventHandler(this.CmdCity_Click);
            // 
            // TimerSQLCheck
            // 
            this.TimerSQLCheck.Enabled = true;
            this.TimerSQLCheck.Interval = 1000;
            this.TimerSQLCheck.Tick += new System.EventHandler(this.TimerSQLCheck_Tick);
            // 
            // LblSQLCheck
            // 
            this.LblSQLCheck.AutoSize = true;
            this.LblSQLCheck.Location = new System.Drawing.Point(12, 368);
            this.LblSQLCheck.Name = "LblSQLCheck";
            this.LblSQLCheck.Size = new System.Drawing.Size(208, 20);
            this.LblSQLCheck.TabIndex = 5;
            this.LblSQLCheck.Text = "SQL Verbindung Initialisieren...";
            // 
            // CmdBill
            // 
            this.CmdBill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdBill.Location = new System.Drawing.Point(342, 12);
            this.CmdBill.Name = "CmdBill";
            this.CmdBill.Size = new System.Drawing.Size(311, 97);
            this.CmdBill.TabIndex = 6;
            this.CmdBill.Text = "Rechnungs-Übersicht";
            this.CmdBill.UseVisualStyleBackColor = true;
            this.CmdBill.Click += new System.EventHandler(this.CmdBill_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 402);
            this.Controls.Add(this.CmdBill);
            this.Controls.Add(this.LblSQLCheck);
            this.Controls.Add(this.CmdCity);
            this.Controls.Add(this.CmdOrder);
            this.Controls.Add(this.CmdProductGroup);
            this.Controls.Add(this.CmdProduct);
            this.Controls.Add(this.CmdCustomer);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdCustomer;
        private System.Windows.Forms.Button CmdProduct;
        private System.Windows.Forms.Button CmdProductGroup;
        private System.Windows.Forms.Button CmdOrder;
        private System.Windows.Forms.Button CmdCity;
        private System.Windows.Forms.Timer TimerSQLCheck;
        private System.Windows.Forms.Label LblSQLCheck;
        private System.Windows.Forms.Button CmdBill;
    }
}