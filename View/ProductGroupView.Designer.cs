
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
            this.TxtProductGroupName = new System.Windows.Forms.TextBox();
            this.LblProductNr = new System.Windows.Forms.Label();
            this.TxtProductGrupNr = new System.Windows.Forms.TextBox();
            this.CmdNewChildNode = new System.Windows.Forms.Button();
            this.CmdDelete = new System.Windows.Forms.Button();
            this.CmdNewGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TvProductGroup
            // 
            this.TvProductGroup.Location = new System.Drawing.Point(16, 16);
            this.TvProductGroup.Margin = new System.Windows.Forms.Padding(4);
            this.TvProductGroup.Name = "TvProductGroup";
            this.TvProductGroup.Size = new System.Drawing.Size(968, 398);
            this.TvProductGroup.TabIndex = 0;
            this.TvProductGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvProductGroup_AfterSelect);
            // 
            // CmdUpdate
            // 
            this.CmdUpdate.Location = new System.Drawing.Point(822, 429);
            this.CmdUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.CmdUpdate.Name = "CmdUpdate";
            this.CmdUpdate.Size = new System.Drawing.Size(162, 36);
            this.CmdUpdate.TabIndex = 10;
            this.CmdUpdate.Text = "Speichern";
            this.CmdUpdate.UseVisualStyleBackColor = true;
            this.CmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
            // 
            // CmdNewNode
            // 
            this.CmdNewNode.Location = new System.Drawing.Point(641, 429);
            this.CmdNewNode.Margin = new System.Windows.Forms.Padding(4);
            this.CmdNewNode.Name = "CmdNewNode";
            this.CmdNewNode.Size = new System.Drawing.Size(162, 36);
            this.CmdNewNode.TabIndex = 15;
            this.CmdNewNode.Text = "Gruppe";
            this.CmdNewNode.UseVisualStyleBackColor = true;
            this.CmdNewNode.Visible = false;
            this.CmdNewNode.Click += new System.EventHandler(this.CmdNewNode_Click);
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Location = new System.Drawing.Point(16, 485);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(59, 25);
            this.LblDescription.TabIndex = 14;
            this.LblDescription.Text = "Name";
            // 
            // TxtProductGroupName
            // 
            this.TxtProductGroupName.Location = new System.Drawing.Point(181, 481);
            this.TxtProductGroupName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductGroupName.Name = "TxtProductGroupName";
            this.TxtProductGroupName.ReadOnly = true;
            this.TxtProductGroupName.Size = new System.Drawing.Size(249, 31);
            this.TxtProductGroupName.TabIndex = 13;
            // 
            // LblProductNr
            // 
            this.LblProductNr.AutoSize = true;
            this.LblProductNr.Location = new System.Drawing.Point(16, 435);
            this.LblProductNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductNr.Name = "LblProductNr";
            this.LblProductNr.Size = new System.Drawing.Size(150, 25);
            this.LblProductNr.TabIndex = 12;
            this.LblProductNr.Text = "Artikelgruppe-Nr.";
            // 
            // TxtProductGrupNr
            // 
            this.TxtProductGrupNr.Location = new System.Drawing.Point(181, 431);
            this.TxtProductGrupNr.Margin = new System.Windows.Forms.Padding(4);
            this.TxtProductGrupNr.Name = "TxtProductGrupNr";
            this.TxtProductGrupNr.ReadOnly = true;
            this.TxtProductGrupNr.Size = new System.Drawing.Size(249, 31);
            this.TxtProductGrupNr.TabIndex = 11;
            // 
            // CmdNewChildNode
            // 
            this.CmdNewChildNode.Location = new System.Drawing.Point(641, 479);
            this.CmdNewChildNode.Margin = new System.Windows.Forms.Padding(4);
            this.CmdNewChildNode.Name = "CmdNewChildNode";
            this.CmdNewChildNode.Size = new System.Drawing.Size(162, 36);
            this.CmdNewChildNode.TabIndex = 16;
            this.CmdNewChildNode.Text = "Untergruppe";
            this.CmdNewChildNode.UseVisualStyleBackColor = true;
            this.CmdNewChildNode.Visible = false;
            this.CmdNewChildNode.Click += new System.EventHandler(this.CmdNewChildNode_Click);
            // 
            // CmdDelete
            // 
            this.CmdDelete.Location = new System.Drawing.Point(822, 479);
            this.CmdDelete.Margin = new System.Windows.Forms.Padding(4);
            this.CmdDelete.Name = "CmdDelete";
            this.CmdDelete.Size = new System.Drawing.Size(162, 36);
            this.CmdDelete.TabIndex = 17;
            this.CmdDelete.Text = "Löschen";
            this.CmdDelete.UseVisualStyleBackColor = true;
            this.CmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdNewGroup
            // 
            this.CmdNewGroup.Location = new System.Drawing.Point(460, 429);
            this.CmdNewGroup.Margin = new System.Windows.Forms.Padding(4);
            this.CmdNewGroup.Name = "CmdNewGroup";
            this.CmdNewGroup.Size = new System.Drawing.Size(162, 36);
            this.CmdNewGroup.TabIndex = 18;
            this.CmdNewGroup.Text = "Neue Gruppe";
            this.CmdNewGroup.UseVisualStyleBackColor = true;
            this.CmdNewGroup.Click += new System.EventHandler(this.CmdNewGroup_Click);
            // 
            // ProductGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.CmdNewGroup);
            this.Controls.Add(this.CmdDelete);
            this.Controls.Add(this.CmdNewChildNode);
            this.Controls.Add(this.CmdNewNode);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtProductGroupName);
            this.Controls.Add(this.LblProductNr);
            this.Controls.Add(this.TxtProductGrupNr);
            this.Controls.Add(this.CmdUpdate);
            this.Controls.Add(this.TvProductGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox TxtProductGroupName;
        private System.Windows.Forms.Label LblProductNr;
        private System.Windows.Forms.TextBox TxtProductGrupNr;
        private System.Windows.Forms.Button CmdNewChildNode;
        private System.Windows.Forms.Button CmdDelete;
        private System.Windows.Forms.Button CmdNewGroup;
    }
}