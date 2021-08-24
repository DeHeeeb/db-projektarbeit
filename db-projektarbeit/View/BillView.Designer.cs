
namespace db_projektarbeit.View
{
    partial class BillView
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
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DgvBills = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1354, 11);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 29);
            this.CmdSearch.TabIndex = 25;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1336, 27);
            this.TxtSearch.TabIndex = 18;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // DgvBills
            // 
            this.DgvBills.AllowUserToAddRows = false;
            this.DgvBills.AllowUserToDeleteRows = false;
            this.DgvBills.AllowUserToResizeRows = false;
            this.DgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBills.Location = new System.Drawing.Point(12, 46);
            this.DgvBills.MultiSelect = false;
            this.DgvBills.Name = "DgvBills";
            this.DgvBills.ReadOnly = true;
            this.DgvBills.RowHeadersWidth = 51;
            this.DgvBills.RowTemplate.Height = 29;
            this.DgvBills.Size = new System.Drawing.Size(1436, 332);
            this.DgvBills.TabIndex = 17;
            this.DgvBills.TabStop = false;
            // 
            // BillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 390);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DgvBills);
            this.Name = "BillView";
            this.Text = "Rechnungs-Übersicht";
            ((System.ComponentModel.ISupportInitialize)(this.DgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvBills;
    }
}