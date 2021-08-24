
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
            this.DgvStatisticsSelf = new System.Windows.Forms.DataGridView();
            this.DgvStatisticsCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsSelf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStatisticsSelf
            // 
            this.DgvStatisticsSelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatisticsSelf.Location = new System.Drawing.Point(10, 11);
            this.DgvStatisticsSelf.Name = "DgvStatisticsSelf";
            this.DgvStatisticsSelf.RowHeadersWidth = 51;
            this.DgvStatisticsSelf.RowTemplate.Height = 29;
            this.DgvStatisticsSelf.Size = new System.Drawing.Size(2015, 213);
            this.DgvStatisticsSelf.TabIndex = 0;
            // 
            // DgvStatisticsCustomer
            // 
            this.DgvStatisticsCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatisticsCustomer.Location = new System.Drawing.Point(10, 244);
            this.DgvStatisticsCustomer.Name = "DgvStatisticsCustomer";
            this.DgvStatisticsCustomer.RowHeadersWidth = 51;
            this.DgvStatisticsCustomer.RowTemplate.Height = 29;
            this.DgvStatisticsCustomer.Size = new System.Drawing.Size(2015, 756);
            this.DgvStatisticsCustomer.TabIndex = 1;
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1015);
            this.Controls.Add(this.DgvStatisticsCustomer);
            this.Controls.Add(this.DgvStatisticsSelf);
            this.Name = "StatisticsView";
            this.Text = "StatisticsView";
            this.Load += new System.EventHandler(this.StatisticsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsSelf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatisticsCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStatisticsSelf;
        private System.Windows.Forms.DataGridView DgvStatisticsCustomer;
    }
}