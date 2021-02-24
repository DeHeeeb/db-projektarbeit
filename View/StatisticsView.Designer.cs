
namespace db_projektarbeit.View
{
    partial class StatisticsView
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
            this.DgvStatisticsSelfe = new System.Windows.Forms.DataGridView();
            this.DgvStatisticsCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsSelfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStatisticsSelfe
            // 
            this.DgvStatisticsSelfe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatisticsSelfe.Location = new System.Drawing.Point(9, 8);
            this.DgvStatisticsSelfe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvStatisticsSelfe.Name = "DgvStatisticsSelfe";
            this.DgvStatisticsSelfe.RowHeadersWidth = 51;
            this.DgvStatisticsSelfe.RowTemplate.Height = 29;
            this.DgvStatisticsSelfe.Size = new System.Drawing.Size(1763, 160);
            this.DgvStatisticsSelfe.TabIndex = 0;
            // 
            // DgvStatisticsCustomer
            // 
            this.DgvStatisticsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatisticsCustomer.Location = new System.Drawing.Point(9, 183);
            this.DgvStatisticsCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvStatisticsCustomer.Name = "DgvStatisticsCustomer";
            this.DgvStatisticsCustomer.RowHeadersWidth = 51;
            this.DgvStatisticsCustomer.RowTemplate.Height = 29;
            this.DgvStatisticsCustomer.Size = new System.Drawing.Size(1763, 567);
            this.DgvStatisticsCustomer.TabIndex = 1;
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 761);
            this.Controls.Add(this.DgvStatisticsCustomer);
            this.Controls.Add(this.DgvStatisticsSelfe);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StatisticsView";
            this.Text = "StatisticsView";
            this.Load += new System.EventHandler(this.StatisticsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsSelfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStatisticsSelfe;
        private System.Windows.Forms.DataGridView DgvStatisticsCustomer;
    }
}