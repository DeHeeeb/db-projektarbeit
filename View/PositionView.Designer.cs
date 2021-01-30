
namespace db_projektarbeit.View
{
    partial class PositionView
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
            this.CmdEditProduct = new System.Windows.Forms.Button();
            this.CbxProduct = new System.Windows.Forms.ComboBox();
            this.LblProduct = new System.Windows.Forms.Label();
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.DgvPositions = new System.Windows.Forms.DataGridView();
            this.NumCount = new System.Windows.Forms.NumericUpDown();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdEditProduct
            // 
            this.CmdEditProduct.Location = new System.Drawing.Point(525, 278);
            this.CmdEditProduct.Name = "CmdEditProduct";
            this.CmdEditProduct.Size = new System.Drawing.Size(167, 28);
            this.CmdEditProduct.TabIndex = 36;
            this.CmdEditProduct.Text = "Produkte bearbeiten";
            this.CmdEditProduct.UseVisualStyleBackColor = true;
            this.CmdEditProduct.Click += new System.EventHandler(this.CmdEditProduct_Click);
            // 
            // CbxProduct
            // 
            this.CbxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CbxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CbxProduct.Enabled = false;
            this.CbxProduct.FormattingEnabled = true;
            this.CbxProduct.Location = new System.Drawing.Point(320, 280);
            this.CbxProduct.Name = "CbxProduct";
            this.CbxProduct.Size = new System.Drawing.Size(201, 28);
            this.CbxProduct.TabIndex = 35;
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Location = new System.Drawing.Point(255, 282);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(60, 20);
            this.LblProduct.TabIndex = 34;
            this.LblProduct.Text = "Produkt";
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(112, 336);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(95, 29);
            this.CmdNew.TabIndex = 33;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(13, 336);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(95, 29);
            this.CmdSave.TabIndex = 32;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(9, 282);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(54, 20);
            this.LblCount.TabIndex = 26;
            this.LblCount.Text = "Anzahl";
            // 
            // DgvPositions
            // 
            this.DgvPositions.AllowUserToAddRows = false;
            this.DgvPositions.AllowUserToDeleteRows = false;
            this.DgvPositions.AllowUserToResizeRows = false;
            this.DgvPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPositions.Location = new System.Drawing.Point(9, 46);
            this.DgvPositions.MultiSelect = false;
            this.DgvPositions.Name = "DgvPositions";
            this.DgvPositions.ReadOnly = true;
            this.DgvPositions.RowHeadersWidth = 51;
            this.DgvPositions.RowTemplate.Height = 29;
            this.DgvPositions.Size = new System.Drawing.Size(681, 218);
            this.DgvPositions.TabIndex = 23;
            this.DgvPositions.TabStop = false;
            this.DgvPositions.SelectionChanged += new System.EventHandler(this.DgvPositions_SelectionChanged);
            // 
            // NumCount
            // 
            this.NumCount.Location = new System.Drawing.Point(77, 281);
            this.NumCount.Margin = new System.Windows.Forms.Padding(1);
            this.NumCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCount.Name = "NumCount";
            this.NumCount.ReadOnly = true;
            this.NumCount.Size = new System.Drawing.Size(130, 27);
            this.NumCount.TabIndex = 37;
            this.NumCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(213, 336);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(92, 29);
            this.CmdDelete.TabIndex = 38;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(583, 11);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(107, 29);
            this.CmdSearch.TabIndex = 40;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(9, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(568, 27);
            this.TxtSearch.TabIndex = 39;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 374);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.NumCount);
            this.Controls.Add(this.CmdEditProduct);
            this.Controls.Add(this.CbxProduct);
            this.Controls.Add(this.LblProduct);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.DgvPositions);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "PositionView";
            this.Text = "Positionen-Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdEditProduct;
        private System.Windows.Forms.ComboBox CbxProduct;
        private System.Windows.Forms.Label LblProduct;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.DataGridView DgvPositions;
        private System.Windows.Forms.NumericUpDown NumCount;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
    }
}