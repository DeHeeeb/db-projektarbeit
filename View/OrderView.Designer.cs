
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
            this.DgvPosition = new System.Windows.Forms.DataGridView();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.CmdEditPositions = new System.Windows.Forms.Button();
            this.CbxCustomer = new System.Windows.Forms.ComboBox();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.LblComment = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.CmdNew = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.NumTotal = new System.Windows.Forms.NumericUpDown();
            this.CmdEditCustomer = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(859, 11);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(94, 29);
            this.CmdSearch.TabIndex = 10;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(841, 27);
            this.TxtSearch.TabIndex = 9;
            this.TxtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
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
            this.DgvOrder.Size = new System.Drawing.Size(396, 459);
            this.DgvOrder.TabIndex = 11;
            this.DgvOrder.TabStop = false;
            this.DgvOrder.SelectionChanged += new System.EventHandler(this.DgvOrder_SelectionChanged);
            // 
            // DgvPosition
            // 
            this.DgvPosition.AllowUserToAddRows = false;
            this.DgvPosition.AllowUserToDeleteRows = false;
            this.DgvPosition.AllowUserToResizeRows = false;
            this.DgvPosition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPosition.Location = new System.Drawing.Point(414, 47);
            this.DgvPosition.MultiSelect = false;
            this.DgvPosition.Name = "DgvPosition";
            this.DgvPosition.ReadOnly = true;
            this.DgvPosition.RowHeadersWidth = 51;
            this.DgvPosition.RowTemplate.Height = 29;
            this.DgvPosition.Size = new System.Drawing.Size(539, 179);
            this.DgvPosition.TabIndex = 12;
            this.DgvPosition.TabStop = false;
            // 
            // DtpDate
            // 
            this.DtpDate.Enabled = false;
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(510, 298);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(250, 27);
            this.DtpDate.TabIndex = 13;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(414, 303);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(54, 20);
            this.LblDate.TabIndex = 15;
            this.LblDate.Text = "Datum";
            // 
            // CmdEditPositions
            // 
            this.CmdEditPositions.Location = new System.Drawing.Point(414, 232);
            this.CmdEditPositions.Name = "CmdEditPositions";
            this.CmdEditPositions.Size = new System.Drawing.Size(539, 29);
            this.CmdEditPositions.TabIndex = 16;
            this.CmdEditPositions.Text = "Positionen bearbeiten";
            this.CmdEditPositions.UseVisualStyleBackColor = true;
            this.CmdEditPositions.Click += new System.EventHandler(this.CmdEditPositions_Click);
            // 
            // CbxCustomer
            // 
            this.CbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCustomer.Enabled = false;
            this.CbxCustomer.FormattingEnabled = true;
            this.CbxCustomer.Location = new System.Drawing.Point(510, 331);
            this.CbxCustomer.Name = "CbxCustomer";
            this.CbxCustomer.Size = new System.Drawing.Size(250, 28);
            this.CbxCustomer.TabIndex = 18;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Location = new System.Drawing.Point(414, 335);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(51, 20);
            this.LblCustomer.TabIndex = 17;
            this.LblCustomer.Text = "Kunde";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(414, 367);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(87, 20);
            this.LblComment.TabIndex = 19;
            this.LblComment.Text = "Kommentar";
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(510, 364);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(443, 138);
            this.TxtComment.TabIndex = 20;
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(112, 518);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(94, 29);
            this.CmdNew.TabIndex = 22;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(12, 518);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 29);
            this.CmdSave.TabIndex = 21;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(775, 516);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(59, 28);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "Total";
            // 
            // NumTotal
            // 
            this.NumTotal.DecimalPlaces = 2;
            this.NumTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTotal.Location = new System.Drawing.Point(840, 514);
            this.NumTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumTotal.Name = "NumTotal";
            this.NumTotal.ReadOnly = true;
            this.NumTotal.Size = new System.Drawing.Size(113, 34);
            this.NumTotal.TabIndex = 24;
            // 
            // CmdEditCustomer
            // 
            this.CmdEditCustomer.Location = new System.Drawing.Point(766, 331);
            this.CmdEditCustomer.Name = "CmdEditCustomer";
            this.CmdEditCustomer.Size = new System.Drawing.Size(187, 28);
            this.CmdEditCustomer.TabIndex = 25;
            this.CmdEditCustomer.Text = "Kunden bearbeiten";
            this.CmdEditCustomer.UseVisualStyleBackColor = true;
            this.CmdEditCustomer.Click += new System.EventHandler(this.CmdEditCustomer_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(213, 519);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(195, 28);
            this.CmdDelete.TabIndex = 27;
            this.CmdDelete.Text = "Auftrag löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdBill
            // 
            this.CmdBill.Enabled = false;
            this.CmdBill.ForeColor = System.Drawing.Color.ForestGreen;
            this.CmdBill.Location = new System.Drawing.Point(510, 518);
            this.CmdBill.Name = "CmdBill";
            this.CmdBill.Size = new System.Drawing.Size(250, 29);
            this.CmdBill.TabIndex = 28;
            this.CmdBill.Text = "Abrechnen";
            this.CmdBill.UseVisualStyleBackColor = true;
            this.CmdBill.Click += new System.EventHandler(this.CmdBill_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 561);
            this.Controls.Add(this.CmdBill);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdEditCustomer);
            this.Controls.Add(this.NumTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.CmdNew);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.LblComment);
            this.Controls.Add(this.CbxCustomer);
            this.Controls.Add(this.LblCustomer);
            this.Controls.Add(this.CmdEditPositions);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.DgvPosition);
            this.Controls.Add(this.DgvOrder);
            this.Controls.Add(this.CmdSearch);
            this.Controls.Add(this.TxtSearch);
            this.Name = "OrderView";
            this.Text = "Auftrags-Verwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.DataGridView DgvPosition;
        private System.Windows.Forms.DateTimePicker DtpDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Button CmdEditPositions;
        private System.Windows.Forms.Label LblCustomer;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.Button CmdNew;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ComboBox CbxCustomer;
        private System.Windows.Forms.NumericUpDown NumTotal;
        private System.Windows.Forms.Button CmdEditCustomer;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdBill;
    }
}