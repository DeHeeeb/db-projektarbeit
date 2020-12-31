
namespace db_projektarbeit.View
{
    partial class OrderView
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
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(694, 12);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 29);
            this.CmdSearch.TabIndex = 10;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(677, 27);
            this.TxtSearch.TabIndex = 9;
            // 
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.AllowUserToResizeRows = false;
            this.DgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.Location = new System.Drawing.Point(12, 47);
            this.DgvOrder.MultiSelect = false;
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.RowHeadersWidth = 51;
            this.DgvOrder.RowTemplate.Height = 29;
            this.DgvOrder.Size = new System.Drawing.Size(776, 320);
            this.DgvOrder.TabIndex = 11;
            this.DgvOrder.TabStop = false;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvOrder);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Name = "OrderView";
            this.Text = "OrderView";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvOrder;
    }
}