
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
            this.DgvStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStatistics
            // 
            this.DgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatistics.Location = new System.Drawing.Point(1, 13);
            this.DgvStatistics.Name = "DgvStatistics";
            this.DgvStatistics.RowHeadersWidth = 51;
            this.DgvStatistics.RowTemplate.Height = 29;
            this.DgvStatistics.Size = new System.Drawing.Size(1110, 434);
            this.DgvStatistics.TabIndex = 0;
            // 
            // StatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.DgvStatistics);
            this.Name = "StatisticsView";
            this.Text = "StatisticsView";
            this.Load += new System.EventHandler(this.StatisticsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStatistics;
    }
}