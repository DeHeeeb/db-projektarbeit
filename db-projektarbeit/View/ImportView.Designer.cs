
namespace db_projektarbeit.View
{
    partial class ImportView
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
            this.CmdImport = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.CmdOfd = new System.Windows.Forms.Button();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdImport
            // 
            this.CmdImport.Location = new System.Drawing.Point(536, 12);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(94, 29);
            this.CmdImport.TabIndex = 47;
            this.CmdImport.Text = "Import";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(12, 14);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(418, 27);
            this.TxtPath.TabIndex = 46;
            // 
            // CmdOfd
            // 
            this.CmdOfd.Location = new System.Drawing.Point(436, 12);
            this.CmdOfd.Name = "CmdOfd";
            this.CmdOfd.Size = new System.Drawing.Size(94, 29);
            this.CmdOfd.TabIndex = 45;
            this.CmdOfd.Text = "Öffnen";
            this.CmdOfd.UseVisualStyleBackColor = true;
            this.CmdOfd.Click += new System.EventHandler(this.CmdOfd_Click);
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AllowUserToDeleteRows = false;
            this.DgvCustomers.AllowUserToResizeRows = false;
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Location = new System.Drawing.Point(12, 57);
            this.DgvCustomers.MultiSelect = false;
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.ReadOnly = true;
            this.DgvCustomers.RowHeadersWidth = 51;
            this.DgvCustomers.RowTemplate.Height = 29;
            this.DgvCustomers.Size = new System.Drawing.Size(619, 249);
            this.DgvCustomers.TabIndex = 48;
            this.DgvCustomers.TabStop = false;
            // 
            // ImportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 320);
            this.Controls.Add(this.DgvCustomers);
            this.Controls.Add(this.CmdImport);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.CmdOfd);
            this.Name = "ImportView";
            this.Text = "ImportView";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdImport;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button CmdOfd;
        private System.Windows.Forms.DataGridView DgvCustomers;
    }
}