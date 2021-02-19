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
            this.CmdStatistics = new System.Windows.Forms.Button();
            this.GrpReport = new System.Windows.Forms.GroupBox();
            this.GrpManipulation = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.GrpReport.SuspendLayout();
            this.GrpManipulation.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmdCustomer
            // 
            this.CmdCustomer.Enabled = false;
            this.CmdCustomer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCustomer.Location = new System.Drawing.Point(7, 45);
            this.CmdCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCustomer.Name = "CmdCustomer";
            this.CmdCustomer.Size = new System.Drawing.Size(406, 79);
            this.CmdCustomer.TabIndex = 0;
            this.CmdCustomer.Text = "Kunden";
            this.CmdCustomer.UseVisualStyleBackColor = true;
            this.CmdCustomer.Click += new System.EventHandler(this.CmdCustomer_Click);
            // 
            // CmdProduct
            // 
            this.CmdProduct.Enabled = false;
            this.CmdProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdProduct.Location = new System.Drawing.Point(7, 132);
            this.CmdProduct.Margin = new System.Windows.Forms.Padding(4);
            this.CmdProduct.Name = "CmdProduct";
            this.CmdProduct.Size = new System.Drawing.Size(406, 79);
            this.CmdProduct.TabIndex = 1;
            this.CmdProduct.Text = "Artikel";
            this.CmdProduct.UseVisualStyleBackColor = true;
            this.CmdProduct.Click += new System.EventHandler(this.CmdProduct_Click);
            // 
            // CmdProductGroup
            // 
            this.CmdProductGroup.Enabled = false;
            this.CmdProductGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdProductGroup.Location = new System.Drawing.Point(7, 219);
            this.CmdProductGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CmdProductGroup.Name = "CmdProductGroup";
            this.CmdProductGroup.Size = new System.Drawing.Size(406, 79);
            this.CmdProductGroup.TabIndex = 2;
            this.CmdProductGroup.Text = "Artikelgruppen";
            this.CmdProductGroup.UseVisualStyleBackColor = true;
            this.CmdProductGroup.Click += new System.EventHandler(this.CmdProductGroup_Click);
            // 
            // CmdOrder
            // 
            this.CmdOrder.Enabled = false;
            this.CmdOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdOrder.Location = new System.Drawing.Point(21, 13);
            this.CmdOrder.Margin = new System.Windows.Forms.Padding(4);
            this.CmdOrder.Name = "CmdOrder";
            this.CmdOrder.Size = new System.Drawing.Size(848, 121);
            this.CmdOrder.TabIndex = 3;
            this.CmdOrder.Text = "Auftrags-Verwaltung";
            this.CmdOrder.UseVisualStyleBackColor = true;
            this.CmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // CmdCity
            // 
            this.CmdCity.Enabled = false;
            this.CmdCity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdCity.Location = new System.Drawing.Point(7, 306);
            this.CmdCity.Margin = new System.Windows.Forms.Padding(4);
            this.CmdCity.Name = "CmdCity";
            this.CmdCity.Size = new System.Drawing.Size(406, 79);
            this.CmdCity.TabIndex = 4;
            this.CmdCity.Text = "Städte";
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
            this.LblSQLCheck.Location = new System.Drawing.Point(113, 562);
            this.LblSQLCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSQLCheck.Name = "LblSQLCheck";
            this.LblSQLCheck.Size = new System.Drawing.Size(249, 25);
            this.LblSQLCheck.TabIndex = 5;
            this.LblSQLCheck.Text = "SQL Verbindung initialisieren...";
            // 
            // CmdBill
            // 
            this.CmdBill.Enabled = false;
            this.CmdBill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdBill.Location = new System.Drawing.Point(7, 45);
            this.CmdBill.Margin = new System.Windows.Forms.Padding(4);
            this.CmdBill.Name = "CmdBill";
            this.CmdBill.Size = new System.Drawing.Size(406, 79);
            this.CmdBill.TabIndex = 6;
            this.CmdBill.Text = "Rechnungs-Übersicht";
            this.CmdBill.UseVisualStyleBackColor = true;
            this.CmdBill.Click += new System.EventHandler(this.CmdBill_Click);
            // 
            // CmdStatistics
            // 
            this.CmdStatistics.Enabled = false;
            this.CmdStatistics.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CmdStatistics.Location = new System.Drawing.Point(7, 132);
            this.CmdStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.CmdStatistics.Name = "CmdStatistics";
            this.CmdStatistics.Size = new System.Drawing.Size(406, 79);
            this.CmdStatistics.TabIndex = 7;
            this.CmdStatistics.Text = "Statistik";
            this.CmdStatistics.UseVisualStyleBackColor = true;
            this.CmdStatistics.Click += new System.EventHandler(this.CmdStatistics_Click);
            // 
            // GrpReport
            // 
            this.GrpReport.Controls.Add(this.CmdBill);
            this.GrpReport.Controls.Add(this.CmdStatistics);
            this.GrpReport.Location = new System.Drawing.Point(14, 182);
            this.GrpReport.Name = "GrpReport";
            this.GrpReport.Size = new System.Drawing.Size(427, 298);
            this.GrpReport.TabIndex = 8;
            this.GrpReport.TabStop = false;
            this.GrpReport.Text = "Reporting";
            // 
            // GrpManipulation
            // 
            this.GrpManipulation.Controls.Add(this.CmdCustomer);
            this.GrpManipulation.Controls.Add(this.CmdProduct);
            this.GrpManipulation.Controls.Add(this.CmdProductGroup);
            this.GrpManipulation.Controls.Add(this.CmdCity);
            this.GrpManipulation.Location = new System.Drawing.Point(456, 182);
            this.GrpManipulation.Name = "GrpManipulation";
            this.GrpManipulation.Size = new System.Drawing.Size(427, 405);
            this.GrpManipulation.TabIndex = 9;
            this.GrpManipulation.TabStop = false;
            this.GrpManipulation.Text = "Stammdaten";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(14, 562);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(92, 25);
            this.LblStatus.TabIndex = 10;
            this.LblStatus.Text = "Status DB:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 610);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.GrpManipulation);
            this.Controls.Add(this.GrpReport);
            this.Controls.Add(this.LblSQLCheck);
            this.Controls.Add(this.CmdOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.GrpReport.ResumeLayout(false);
            this.GrpManipulation.ResumeLayout(false);
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
        private System.Windows.Forms.Button CmdStatistics;
        private System.Windows.Forms.GroupBox GrpReport;
        private System.Windows.Forms.GroupBox GrpManipulation;
        private System.Windows.Forms.Label LblStatus;
    }
}