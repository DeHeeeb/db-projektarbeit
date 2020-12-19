namespace db_projektarbeit
{
    partial class Form1
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.CmdHome = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdKunde = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdArtikel = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdAuftreage = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdArtikelGruppe = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdHome,
            this.CmdKunde,
            this.CmdArtikel,
            this.CmdAuftreage,
            this.CmdArtikelGruppe});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1127, 28);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // CmdHome
            // 
            this.CmdHome.Name = "CmdHome";
            this.CmdHome.Size = new System.Drawing.Size(64, 24);
            this.CmdHome.Text = "Home";
            // 
            // CmdKunde
            // 
            this.CmdKunde.Name = "CmdKunde";
            this.CmdKunde.Size = new System.Drawing.Size(65, 24);
            this.CmdKunde.Text = "Kunde";
            // 
            // CmdArtikel
            // 
            this.CmdArtikel.Name = "CmdArtikel";
            this.CmdArtikel.Size = new System.Drawing.Size(66, 24);
            this.CmdArtikel.Text = "Artikel";
            // 
            // CmdAuftreage
            // 
            this.CmdAuftreage.Name = "CmdAuftreage";
            this.CmdAuftreage.Size = new System.Drawing.Size(81, 24);
            this.CmdAuftreage.Text = "Aufträge";
            // 
            // CmdArtikelGruppe
            // 
            this.CmdArtikelGruppe.Name = "CmdArtikelGruppe";
            this.CmdArtikelGruppe.Size = new System.Drawing.Size(119, 24);
            this.CmdArtikelGruppe.Text = "Artikel Gruppe";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 607);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem CmdHome;
        private System.Windows.Forms.ToolStripMenuItem CmdKunde;
        private System.Windows.Forms.ToolStripMenuItem CmdArtikel;
        private System.Windows.Forms.ToolStripMenuItem CmdAuftreage;
        private System.Windows.Forms.ToolStripMenuItem CmdArtikelGruppe;
        private System.Windows.Forms.Panel panel1;
    }
}