﻿
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
            this.CmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TvProductGroup
            // 
            this.TvProductGroup.Location = new System.Drawing.Point(13, 13);
            this.TvProductGroup.Name = "TvProductGroup";
            this.TvProductGroup.Size = new System.Drawing.Size(775, 367);
            this.TvProductGroup.TabIndex = 0;
            this.TvProductGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvProductGroup_AfterSelect);
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(13, 409);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(94, 29);
            this.CmdSave.TabIndex = 10;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // ProductGroupView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.TvProductGroup);
            this.Name = "ProductGroupView";
            this.Text = "ProductGroupView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView TvProductGroup;
        private System.Windows.Forms.Button CmdSave;
    }
}