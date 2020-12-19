
namespace db_projektarbeit.View
{
    partial class CustomerView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TxtCustomerNr = new System.Windows.Forms.TextBox();
            this.LblCustomerNr = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 27);
            this.textBox1.TabIndex = 1;
            // 
            // TxtCustomerNr
            // 
            this.TxtCustomerNr.Location = new System.Drawing.Point(102, 255);
            this.TxtCustomerNr.Name = "TxtCustomerNr";
            this.TxtCustomerNr.ReadOnly = true;
            this.TxtCustomerNr.Size = new System.Drawing.Size(125, 27);
            this.TxtCustomerNr.TabIndex = 2;
            // 
            // LblCustomerNr
            // 
            this.LblCustomerNr.AutoSize = true;
            this.LblCustomerNr.Location = new System.Drawing.Point(12, 258);
            this.LblCustomerNr.Name = "LblCustomerNr";
            this.LblCustomerNr.Size = new System.Drawing.Size(84, 20);
            this.LblCustomerNr.TabIndex = 3;
            this.LblCustomerNr.Text = "Kunden-Nr.";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 302);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 20);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(102, 299);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(125, 27);
            this.TxtName.TabIndex = 4;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(12, 346);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(85, 20);
            this.LblStreet.TabIndex = 7;
            this.LblStreet.Text = "Strasse / Nr";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(102, 343);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.ReadOnly = true;
            this.TxtStreet.Size = new System.Drawing.Size(125, 27);
            this.TxtStreet.TabIndex = 6;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(694, 10);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 29);
            this.CmdSearch.TabIndex = 8;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblCustomerNr);
            this.Controls.Add(this.TxtCustomerNr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerView";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TxtCustomerNr;
        private System.Windows.Forms.Label LblCustomerNr;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtStreet;
    }
}