
namespace db_projektarbeit.View
{
    partial class ProductView
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
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtProductNr = new System.Windows.Forms.TextBox();
            this.LblProductNr = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.LblPrice = new System.Windows.Forms.Label();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdNew = new System.Windows.Forms.Button();
            this.LblGroup = new System.Windows.Forms.Label();
            this.TvProductGroup = new System.Windows.Forms.TreeView();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            this.DgvProducts.AllowUserToResizeRows = false;
            this.DgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(26, 92);
            this.DgvProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DgvProducts.MultiSelect = false;
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.ReadOnly = true;
            this.DgvProducts.RowHeadersWidth = 51;
            this.DgvProducts.RowTemplate.Height = 29;
            this.DgvProducts.Size = new System.Drawing.Size(1649, 400);
            this.DgvProducts.TabIndex = 0;
            this.DgvProducts.TabStop = false;
            this.DgvProducts.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(26, 25);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1434, 47);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // TxtProductNr
            // 
            this.TxtProductNr.Location = new System.Drawing.Point(246, 523);
            this.TxtProductNr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtProductNr.Name = "TxtProductNr";
            this.TxtProductNr.ReadOnly = true;
            this.TxtProductNr.Size = new System.Drawing.Size(423, 47);
            this.TxtProductNr.TabIndex = 2;
            // 
            // LblProductNr
            // 
            this.LblProductNr.AutoSize = true;
            this.LblProductNr.Location = new System.Drawing.Point(26, 529);
            this.LblProductNr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblProductNr.Name = "LblProductNr";
            this.LblProductNr.Size = new System.Drawing.Size(153, 41);
            this.LblProductNr.TabIndex = 3;
            this.LblProductNr.Text = "Artikel-Nr.";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(26, 597);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(198, 41);
            this.LblDescription.TabIndex = 5;
            this.LblDescription.Text = "Beschreibung";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(246, 590);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ReadOnly = true;
            this.TxtDescription.Size = new System.Drawing.Size(423, 47);
            this.TxtDescription.TabIndex = 4;
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Location = new System.Drawing.Point(26, 664);
            this.LblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(81, 41);
            this.LblPrice.TabIndex = 7;
            this.LblPrice.Text = "Preis";
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1475, 20);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(200, 59);
            this.CmdSearch.TabIndex = 8;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(26, 992);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(200, 59);
            this.CmdSave.TabIndex = 9;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(238, 992);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(200, 59);
            this.CmdNew.TabIndex = 10;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // LblGroup
            // 
            this.LblGroup.AutoSize = true;
            this.LblGroup.Location = new System.Drawing.Point(740, 529);
            this.LblGroup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblGroup.Name = "LblGroup";
            this.LblGroup.Size = new System.Drawing.Size(199, 41);
            this.LblGroup.TabIndex = 12;
            this.LblGroup.Text = "Artikelgruppe";
            // 
            // TvProductGroup
            // 
            this.TvProductGroup.Enabled = false;
            this.TvProductGroup.Location = new System.Drawing.Point(994, 523);
            this.TvProductGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TvProductGroup.Name = "TvProductGroup";
            this.TvProductGroup.Size = new System.Drawing.Size(676, 461);
            this.TvProductGroup.TabIndex = 13;
            // 
            // NumPrice
            // 
            this.NumPrice.DecimalPlaces = 2;
            this.NumPrice.Location = new System.Drawing.Point(246, 660);
            this.NumPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.ReadOnly = true;
            this.NumPrice.Size = new System.Drawing.Size(427, 47);
            this.NumPrice.TabIndex = 14;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1076);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.TvProductGroup);
            this.Controls.Add(this.LblGroup);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblProductNr);
            this.Controls.Add(this.TxtProductNr);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvProducts);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProductView";
            this.Text = "Artikel-Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtProductNr;
        private System.Windows.Forms.Label LblProductNr;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Label LblGroup;
        private System.Windows.Forms.TreeView TvProductGroup;
        private System.Windows.Forms.NumericUpDown NumPrice;
    }
}