
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
            this.CmdEditProduct.Location = new System.Drawing.Point(656, 348);
            this.CmdEditProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdEditProduct.Name = "CmdEditProduct";
            this.CmdEditProduct.Size = new System.Drawing.Size(209, 35);
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
            this.CbxProduct.Location = new System.Drawing.Point(400, 350);
            this.CbxProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbxProduct.Name = "CbxProduct";
            this.CbxProduct.Size = new System.Drawing.Size(250, 33);
            this.CbxProduct.TabIndex = 38;
            // 
            // LblProduct
            // 
            this.LblProduct.AutoSize = true;
            this.LblProduct.Location = new System.Drawing.Point(319, 352);
            this.LblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProduct.Name = "LblProduct";
            this.LblProduct.Size = new System.Drawing.Size(75, 25);
            this.LblProduct.TabIndex = 34;
            this.LblProduct.Text = "Produkt";
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(141, 420);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(119, 36);
            this.CmdNew.TabIndex = 34;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(16, 420);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(119, 36);
            this.CmdSave.TabIndex = 33;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(11, 352);
            this.LblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(65, 25);
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
            this.DgvPositions.Location = new System.Drawing.Point(11, 58);
            this.DgvPositions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvPositions.MultiSelect = false;
            this.DgvPositions.Name = "DgvPositions";
            this.DgvPositions.ReadOnly = true;
            this.DgvPositions.RowHeadersWidth = 51;
            this.DgvPositions.RowTemplate.Height = 29;
            this.DgvPositions.Size = new System.Drawing.Size(851, 272);
            this.DgvPositions.TabIndex = 32;
            this.DgvPositions.TabStop = false;
            this.DgvPositions.SelectionChanged += new System.EventHandler(this.DgvPositions_SelectionChanged);
            // 
            // NumCount
            // 
            this.NumCount.Location = new System.Drawing.Point(96, 351);
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
            this.NumCount.Size = new System.Drawing.Size(162, 31);
            this.NumCount.TabIndex = 37;
            this.NumCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(266, 420);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(115, 36);
            this.CmdDelete.TabIndex = 35;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(729, 14);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(134, 36);
            this.CmdSearch.TabIndex = 31;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(11, 15);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(709, 31);
            this.TxtSearch.TabIndex = 30;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // PositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 468);
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