
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
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.TxtCustomerNr = new System.Windows.Forms.TextBox();
            this.LblCustomerNr = new System.Windows.Forms.Label();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdNew = new System.Windows.Forms.Button();
            this.LblCity = new System.Windows.Forms.Label();
            this.CbxCity = new System.Windows.Forms.ComboBox();
            this.CmdEditCity = new System.Windows.Forms.Button();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.LblLastName = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtHouseNumber = new System.Windows.Forms.TextBox();
            this.LblHouseNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AllowUserToDeleteRows = false;
            this.DgvCustomers.AllowUserToResizeRows = false;
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Location = new System.Drawing.Point(15, 56);
            this.DgvCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvCustomers.MultiSelect = false;
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.RowHeadersWidth = 51;
            this.DgvCustomers.RowTemplate.Height = 29;
            this.DgvCustomers.Size = new System.Drawing.Size(970, 311);
            this.DgvCustomers.TabIndex = 0;
            this.DgvCustomers.TabStop = false;
            this.DgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(15, 15);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(845, 31);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // TxtCustomerNr
            // 
            this.TxtCustomerNr.Location = new System.Drawing.Point(124, 388);
            this.TxtCustomerNr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCustomerNr.Name = "TxtCustomerNr";
            this.TxtCustomerNr.ReadOnly = true;
            this.TxtCustomerNr.Size = new System.Drawing.Size(250, 31);
            this.TxtCustomerNr.TabIndex = 2;
            // 
            // LblCustomerNr
            // 
            this.LblCustomerNr.AutoSize = true;
            this.LblCustomerNr.Location = new System.Drawing.Point(11, 391);
            this.LblCustomerNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerNr.Name = "LblCustomerNr";
            this.LblCustomerNr.Size = new System.Drawing.Size(102, 25);
            this.LblCustomerNr.TabIndex = 3;
            this.LblCustomerNr.Text = "Kunden-Nr.";
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.Location = new System.Drawing.Point(11, 432);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(56, 25);
            this.LblCompanyName.TabIndex = 5;
            this.LblCompanyName.Text = "Firma";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(124, 429);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.ReadOnly = true;
            this.TxtCompanyName.Size = new System.Drawing.Size(250, 31);
            this.TxtCompanyName.TabIndex = 4;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(430, 473);
            this.LblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(67, 25);
            this.LblStreet.TabIndex = 7;
            this.LblStreet.Text = "Strasse";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(542, 470);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.ReadOnly = true;
            this.TxtStreet.Size = new System.Drawing.Size(250, 31);
            this.TxtStreet.TabIndex = 6;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(868, 12);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(118, 36);
            this.CmdSearch.TabIndex = 8;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(15, 511);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(118, 36);
            this.CmdSave.TabIndex = 9;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(140, 511);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(118, 36);
            this.CmdNew.TabIndex = 10;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(430, 515);
            this.LblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCity.Name = "LblCity";
            this.LblCity.Size = new System.Drawing.Size(99, 25);
            this.LblCity.TabIndex = 12;
            this.LblCity.Text = "PLZ / Stadt";
            // 
            // CbxCity
            // 
            this.CbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCity.Enabled = false;
            this.CbxCity.FormattingEnabled = true;
            this.CbxCity.Location = new System.Drawing.Point(542, 511);
            this.CbxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxCity.Name = "CbxCity";
            this.CbxCity.Size = new System.Drawing.Size(250, 33);
            this.CbxCity.TabIndex = 15;
            // 
            // CmdEditCity
            // 
            this.CmdEditCity.Location = new System.Drawing.Point(801, 511);
            this.CmdEditCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdEditCity.Name = "CmdEditCity";
            this.CmdEditCity.Size = new System.Drawing.Size(180, 35);
            this.CmdEditCity.TabIndex = 16;
            this.CmdEditCity.Text = "Städte bearbeiten";
            this.CmdEditCity.UseVisualStyleBackColor = true;
            this.CmdEditCity.Click += new System.EventHandler(this.CmdEditCity_Click);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(430, 391);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(83, 25);
            this.LblFirstName.TabIndex = 18;
            this.LblFirstName.Text = "Vorname";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(542, 388);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.ReadOnly = true;
            this.TxtFirstName.Size = new System.Drawing.Size(250, 31);
            this.TxtFirstName.TabIndex = 17;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(430, 432);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(96, 25);
            this.LblLastName.TabIndex = 20;
            this.LblLastName.Text = "Nachname";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(542, 429);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.ReadOnly = true;
            this.TxtLastName.Size = new System.Drawing.Size(250, 31);
            this.TxtLastName.TabIndex = 19;
            // 
            // TxtHouseNumber
            // 
            this.TxtHouseNumber.Location = new System.Drawing.Point(849, 470);
            this.TxtHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHouseNumber.Name = "TxtHouseNumber";
            this.TxtHouseNumber.ReadOnly = true;
            this.TxtHouseNumber.Size = new System.Drawing.Size(132, 31);
            this.TxtHouseNumber.TabIndex = 21;
            // 
            // LblHouseNumber
            // 
            this.LblHouseNumber.AutoSize = true;
            this.LblHouseNumber.Location = new System.Drawing.Point(801, 473);
            this.LblHouseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHouseNumber.Name = "LblHouseNumber";
            this.LblHouseNumber.Size = new System.Drawing.Size(31, 25);
            this.LblHouseNumber.TabIndex = 22;
            this.LblHouseNumber.Text = "Nr";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.LblHouseNumber);
            this.Controls.Add(this.TxtHouseNumber);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.LblFirstName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.CmdEditCity);
            this.Controls.Add(this.CbxCity);
            this.Controls.Add(this.LblCity);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.LblStreet);
            this.Controls.Add(this.TxtStreet);
            this.Controls.Add(this.LblCompanyName);
            this.Controls.Add(this.TxtCompanyName);
            this.Controls.Add(this.LblCustomerNr);
            this.Controls.Add(this.TxtCustomerNr);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvCustomers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerView";
            this.Text = "Kunden-Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.TextBox TxtCustomerNr;
        private System.Windows.Forms.Label LblCustomerNr;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Label LblCity;
        private System.Windows.Forms.ComboBox CbxCity;
        private System.Windows.Forms.Button CmdEditCity;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtHouseNumber;
        private System.Windows.Forms.Label LblHouseNumber;
    }
}