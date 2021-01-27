﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSearch
            // 
            this.CmdSearch.Location = new System.Drawing.Point(1825, 23);
            this.CmdSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdSearch.Name = "CmdSearch";
            this.CmdSearch.Size = new System.Drawing.Size(200, 59);
            this.CmdSearch.TabIndex = 10;
            this.CmdSearch.Text = "Suche";
            this.CmdSearch.UseVisualStyleBackColor = true;
            this.CmdSearch.Click += new System.EventHandler(this.CmdSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(26, 25);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(1783, 47);
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
            this.DgvOrder.Location = new System.Drawing.Point(26, 96);
            this.DgvOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DgvOrder.MultiSelect = false;
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.RowHeadersWidth = 51;
            this.DgvOrder.RowTemplate.Height = 29;
            this.DgvOrder.Size = new System.Drawing.Size(842, 942);
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
            this.DgvPosition.Location = new System.Drawing.Point(880, 96);
            this.DgvPosition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DgvPosition.MultiSelect = false;
            this.DgvPosition.Name = "DgvPosition";
            this.DgvPosition.ReadOnly = true;
            this.DgvPosition.RowHeadersWidth = 51;
            this.DgvPosition.RowTemplate.Height = 29;
            this.DgvPosition.Size = new System.Drawing.Size(1145, 367);
            this.DgvPosition.TabIndex = 12;
            this.DgvPosition.TabStop = false;
            // 
            // DtpDate
            // 
            this.DtpDate.Enabled = false;
            this.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDate.Location = new System.Drawing.Point(1084, 484);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(527, 47);
            this.DtpDate.TabIndex = 13;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(880, 494);
            this.LblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(107, 41);
            this.LblDate.TabIndex = 15;
            this.LblDate.Text = "Datum";
            // 
            // CmdEditPositions
            // 
            this.CmdEditPositions.Location = new System.Drawing.Point(450, 1062);
            this.CmdEditPositions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdEditPositions.Name = "CmdEditPositions";
            this.CmdEditPositions.Size = new System.Drawing.Size(416, 59);
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
            this.CbxCustomer.Location = new System.Drawing.Point(1084, 551);
            this.CbxCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CbxCustomer.Name = "CbxCustomer";
            this.CbxCustomer.Size = new System.Drawing.Size(527, 49);
            this.CbxCustomer.TabIndex = 18;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Location = new System.Drawing.Point(880, 566);
            this.LblCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(103, 41);
            this.LblCustomer.TabIndex = 17;
            this.LblCustomer.Text = "Kunde";
            // 
            // LblComment
            // 
            this.LblComment.AutoSize = true;
            this.LblComment.Location = new System.Drawing.Point(880, 627);
            this.LblComment.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(172, 41);
            this.LblComment.TabIndex = 19;
            this.LblComment.Text = "Kommentar";
            // 
            // TxtComment
            // 
            this.TxtComment.Location = new System.Drawing.Point(1084, 621);
            this.TxtComment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(937, 332);
            this.TxtComment.TabIndex = 20;
            // 
            // CmdNew
            // 
            this.CmdNew.Location = new System.Drawing.Point(238, 1062);
            this.CmdNew.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdNew.Name = "CmdNew";
            this.CmdNew.Size = new System.Drawing.Size(200, 59);
            this.CmdNew.TabIndex = 22;
            this.CmdNew.Text = "Neu";
            this.CmdNew.UseVisualStyleBackColor = true;
            this.CmdNew.Click += new System.EventHandler(this.CmdNew_Click);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(26, 1062);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(200, 59);
            this.CmdSave.TabIndex = 21;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(1647, 1058);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(115, 54);
            this.LblTotal.TabIndex = 23;
            this.LblTotal.Text = "Total";
            // 
            // NumTotal
            // 
            this.NumTotal.DecimalPlaces = 2;
            this.NumTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumTotal.Location = new System.Drawing.Point(1785, 1054);
            this.NumTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NumTotal.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NumTotal.Name = "NumTotal";
            this.NumTotal.ReadOnly = true;
            this.NumTotal.Size = new System.Drawing.Size(240, 61);
            this.NumTotal.TabIndex = 24;
            // 
            // CmdEditCustomer
            // 
            this.CmdEditCustomer.Location = new System.Drawing.Point(1628, 551);
            this.CmdEditCustomer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CmdEditCustomer.Name = "CmdEditCustomer";
            this.CmdEditCustomer.Size = new System.Drawing.Size(397, 57);
            this.CmdEditCustomer.TabIndex = 25;
            this.CmdEditCustomer.Text = "Kunden bearbeiten";
            this.CmdEditCustomer.UseVisualStyleBackColor = true;
            this.CmdEditCustomer.Click += new System.EventHandler(this.CmdEditCustomer_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2051, 1144);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
    }
}