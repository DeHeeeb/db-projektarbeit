
namespace db_projektarbeit.View
{
    partial class ProductGroupView
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
            this.TvProductGroup = new System.Windows.Forms.TreeView();
            this.CmdUpdate = new System.Windows.Forms.Button();
            this.CmdNewNode = new System.Windows.Forms.Button();
            this.LblDescription = new System.Windows.Forms.Label();
            this.TxtProductGrupName = new System.Windows.Forms.TextBox();
            this.LblProductNr = new System.Windows.Forms.Label();
            this.TxtProductGrupNr = new System.Windows.Forms.TextBox();
            this.NewChildNode = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TvProductGroup
            // 
            this.TvProductGroup.Location = new System.Drawing.Point(13, 13);
            this.TvProductGroup.Name = "TvProductGroup";
            this.TvProductGroup.Size = new System.Drawing.Size(775, 319);
            this.TvProductGroup.TabIndex = 0;
            this.TvProductGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvProductGroup_AfterSelect);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(638, 343);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(150, 29);
            this.CmdUpdate.TabIndex = 10;
            this.CmdUpdate.Text = "Speichern";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdNewNode
            // 
            this.CmdNewNode.Location = new System.Drawing.Point(398, 343);
            this.CmdNewNode.Name = "CmdNewNode";
            this.CmdNewNode.Size = new System.Drawing.Size(150, 29);
            this.CmdNewNode.TabIndex = 15;
            this.CmdNewNode.Text = "Neue Gruppe";
            this.CmdNewNode.UseVisualStyleBackColor = true;
            this.CmdNewNode.Click += new System.EventHandler(this.CmdNewNode_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(13, 388);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(49, 20);
            this.LblDescription.TabIndex = 14;
            this.LblDescription.Text = "Name";
            // 
            // TxtProductGrupName
            // 
            this.TxtProductGrupName.Location = new System.Drawing.Point(145, 385);
            this.TxtProductGrupName.Name = "TxtProductGrupName";
            this.TxtProductGrupName.ReadOnly = true;
            this.TxtProductGrupName.Size = new System.Drawing.Size(200, 27);
            this.TxtProductGrupName.TabIndex = 13;
            // 
            // LblProductNr
            // 
            this.LblProductNr.AutoSize = true;
            this.LblProductNr.Location = new System.Drawing.Point(13, 348);
            this.LblProductNr.Name = "LblProductNr";
            this.LblProductNr.Size = new System.Drawing.Size(125, 20);
            this.LblProductNr.TabIndex = 12;
            this.LblProductNr.Text = "Artikelgruppe-Nr.";
            // 
            // TxtProductGrupNr
            // 
            this.TxtProductGrupNr.Location = new System.Drawing.Point(145, 345);
            this.TxtProductGrupNr.Name = "TxtProductGrupNr";
            this.TxtProductGrupNr.ReadOnly = true;
            this.TxtProductGrupNr.Size = new System.Drawing.Size(200, 27);
            this.TxtProductGrupNr.TabIndex = 11;
            // 
            // NewChildNode
            // 
            this.NewChildNode.Location = new System.Drawing.Point(398, 385);
            this.NewChildNode.Name = "NewChildNode";
            this.NewChildNode.Size = new System.Drawing.Size(150, 29);
            this.NewChildNode.TabIndex = 16;
            this.NewChildNode.Text = "Neue Untergruppe";
            this.NewChildNode.UseVisualStyleBackColor = true;
            this.NewChildNode.Click += new System.EventHandler(this.CmdNewChildNode_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(638, 383);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(150, 29);
            this.CmdDelete.TabIndex = 17;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // ProductGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.NewChildNode);
            this.Controls.Add(this.CmdNewNode);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtProductGrupName);
            this.Controls.Add(this.LblProductNr);
            this.Controls.Add(this.TxtProductGrupNr);
            this.Controls.Add(this.CmdUpdate);
            this.Controls.Add(this.TvProductGroup);
            this.Name = "ProductGroupView";
            this.Text = "Artikelgruppen-Verwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView TvProductGroup;
        private System.Windows.Forms.Button CmdUpdate;
        private System.Windows.Forms.Button CmdNewNode;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.TextBox TxtProductGrupName;
        private System.Windows.Forms.Label LblProductNr;
        private System.Windows.Forms.TextBox TxtProductGrupNr;
        private System.Windows.Forms.Button NewChildNode;
        private System.Windows.Forms.Button CmdDelete;
    }
}