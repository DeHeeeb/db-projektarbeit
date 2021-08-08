
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
            this.CmdDelete = new System.Windows.Forms.Button();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblWebsite = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
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
            this.DgvCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DgvCustomers.MultiSelect = false;
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.RowHeadersWidth = 51;
            this.DgvCustomers.RowTemplate.Height = 29;
            this.DgvCustomers.Size = new System.Drawing.Size(970, 311);
            this.DgvCustomers.TabIndex = 42;
            this.DgvCustomers.TabStop = false;
            this.DgvCustomers.SelectionChanged += new System.EventHandler(this.DgvCustomers_SelectionChanged);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(15, 15);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(845, 31);
            this.TxtSearch.TabIndex = 40;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // TxtCustomerNr
            // 
            this.TxtCustomerNr.Location = new System.Drawing.Point(124, 388);
            this.TxtCustomerNr.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustomerNr.Name = "TxtCustomerNr";
            this.TxtCustomerNr.ReadOnly = true;
            this.TxtCustomerNr.Size = new System.Drawing.Size(250, 31);
            this.TxtCustomerNr.TabIndex = 47;
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
            this.LblCompanyName.Location = new System.Drawing.Point(11, 431);
            this.LblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(56, 25);
            this.LblCompanyName.TabIndex = 5;
            this.LblCompanyName.Text = "Firma";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(124, 429);
            this.TxtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.ReadOnly = true;
            this.TxtCompanyName.Size = new System.Drawing.Size(250, 31);
            this.TxtCompanyName.TabIndex = 48;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(430, 392);
            this.LblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(67, 25);
            this.LblStreet.TabIndex = 7;
            this.LblStreet.Text = "Strasse";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(543, 388);
            this.TxtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.ReadOnly = true;
            this.TxtStreet.Size = new System.Drawing.Size(250, 31);
            this.TxtStreet.TabIndex = 51;
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(869, 12);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(119, 36);
            this.CmdSearch.TabIndex = 41;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(13, 556);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(115, 36);
            this.CmdSave.TabIndex = 43;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(136, 556);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(4);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(115, 36);
            this.CmdNew.TabIndex = 44;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // LblCity
            // 
            this.LblCity.AutoSize = true;
            this.LblCity.Location = new System.Drawing.Point(430, 433);
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
            this.CbxCity.Location = new System.Drawing.Point(543, 428);
            this.CbxCity.Margin = new System.Windows.Forms.Padding(4);
            this.CbxCity.Name = "CbxCity";
            this.CbxCity.Size = new System.Drawing.Size(250, 33);
            this.CbxCity.TabIndex = 53;
            // 
            // CmdEditCity
            // 
            this.CmdEditCity.Location = new System.Drawing.Point(801, 429);
            this.CmdEditCity.Margin = new System.Windows.Forms.Padding(4);
            this.CmdEditCity.Name = "CmdEditCity";
            this.CmdEditCity.Size = new System.Drawing.Size(180, 35);
            this.CmdEditCity.TabIndex = 46;
            this.CmdEditCity.Text = "Städte bearbeiten";
            this.CmdEditCity.UseVisualStyleBackColor = true;
            this.CmdEditCity.Click += new System.EventHandler(this.CmdEditCity_Click);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(11, 473);
            this.LblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(83, 25);
            this.LblFirstName.TabIndex = 18;
            this.LblFirstName.Text = "Vorname";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(124, 470);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.ReadOnly = true;
            this.TxtFirstName.Size = new System.Drawing.Size(250, 31);
            this.TxtFirstName.TabIndex = 49;
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(11, 513);
            this.LblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(96, 25);
            this.LblLastName.TabIndex = 20;
            this.LblLastName.Text = "Nachname";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(124, 511);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.ReadOnly = true;
            this.TxtLastName.Size = new System.Drawing.Size(250, 31);
            this.TxtLastName.TabIndex = 50;
            // 
            // TxtHouseNumber
            // 
            this.TxtHouseNumber.Location = new System.Drawing.Point(849, 388);
            this.TxtHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.TxtHouseNumber.Name = "TxtHouseNumber";
            this.TxtHouseNumber.ReadOnly = true;
            this.TxtHouseNumber.Size = new System.Drawing.Size(133, 31);
            this.TxtHouseNumber.TabIndex = 52;
            // 
            // LblHouseNumber
            // 
            this.LblHouseNumber.AutoSize = true;
            this.LblHouseNumber.Location = new System.Drawing.Point(801, 392);
            this.LblHouseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblHouseNumber.Name = "LblHouseNumber";
            this.LblHouseNumber.Size = new System.Drawing.Size(31, 25);
            this.LblHouseNumber.TabIndex = 22;
            this.LblHouseNumber.Text = "Nr";
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(259, 556);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(115, 36);
            this.CmdDelete.TabIndex = 45;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(430, 473);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(54, 25);
            this.LblEmail.TabIndex = 54;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(543, 470);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.ReadOnly = true;
            this.TxtEmail.Size = new System.Drawing.Size(250, 31);
            this.TxtEmail.TabIndex = 55;
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Location = new System.Drawing.Point(543, 511);
            this.TxtWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.ReadOnly = true;
            this.TxtWebsite.Size = new System.Drawing.Size(250, 31);
            this.TxtWebsite.TabIndex = 56;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(543, 556);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.ReadOnly = true;
            this.TxtPassword.Size = new System.Drawing.Size(250, 31);
            this.TxtPassword.TabIndex = 57;
            // 
            // LblWebsite
            // 
            this.LblWebsite.AutoSize = true;
            this.LblWebsite.Location = new System.Drawing.Point(430, 513);
            this.LblWebsite.Name = "LblWebsite";
            this.LblWebsite.Size = new System.Drawing.Size(84, 25);
            this.LblWebsite.TabIndex = 58;
            this.LblWebsite.Text = "Webseite";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(430, 559);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(82, 25);
            this.LblPassword.TabIndex = 59;
            this.LblPassword.Text = "Passwort";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 608);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblWebsite);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtWebsite);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.CmdDelete);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtWebsite;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblWebsite;
        private System.Windows.Forms.Label LblPassword;
    }
}