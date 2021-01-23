
namespace db_projektarbeit.View
{
    partial class CityView
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
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblZip = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvCities = new System.Windows.Forms.DataGridView();
            this.NumZip = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(109, 336);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(94, 29);
            this.CmdNew.TabIndex = 27;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(9, 336);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 29);
            this.CmdSave.TabIndex = 26;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(209, 11);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 29);
            this.CmdSearch.TabIndex = 25;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(12, 292);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(49, 20);
            this.LblName.TabIndex = 22;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(80, 289);
            this.TxtName.Name = "TxtName";
            this.TxtName.ReadOnly = true;
            this.TxtName.Size = new System.Drawing.Size(223, 27);
            this.TxtName.TabIndex = 21;
            // 
            // LblZip
            // 
            this.LblZip.AutoSize = true;
            this.LblZip.Location = new System.Drawing.Point(12, 259);
            this.LblZip.Name = "LblZip";
            this.LblZip.Size = new System.Drawing.Size(33, 20);
            this.LblZip.TabIndex = 20;
            this.LblZip.Text = "PLZ";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(191, 27);
            this.TxtSearch.TabIndex = 18;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // DgvCities
            // 
            this.DgvCities.AllowUserToAddRows = false;
            this.DgvCities.AllowUserToDeleteRows = false;
            this.DgvCities.AllowUserToResizeRows = false;
            this.DgvCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCities.Location = new System.Drawing.Point(12, 46);
            this.DgvCities.MultiSelect = false;
            this.DgvCities.Name = "DgvCities";
            this.DgvCities.ReadOnly = true;
            this.DgvCities.RowHeadersWidth = 51;
            this.DgvCities.RowTemplate.Height = 29;
            this.DgvCities.Size = new System.Drawing.Size(291, 195);
            this.DgvCities.TabIndex = 17;
            this.DgvCities.TabStop = false;
            this.DgvCities.SelectionChanged += new System.EventHandler(this.DgvCities_SelectionChanged);
            // 
            // NumZip
            // 
            this.NumZip.Location = new System.Drawing.Point(80, 257);
            this.NumZip.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumZip.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumZip.Name = "NumZip";
            this.NumZip.ReadOnly = true;
            this.NumZip.Size = new System.Drawing.Size(223, 27);
            this.NumZip.TabIndex = 28;
            this.NumZip.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // CityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 390);
            this.Controls.Add(this.NumZip);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblZip);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvCities);
            this.Name = "CityView";
            this.Text = "Städte-Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumZip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblZip;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvCities;
        private System.Windows.Forms.NumericUpDown NumZip;
    }
}