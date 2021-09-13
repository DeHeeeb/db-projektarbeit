
namespace db_projektarbeit.View
{
    partial class ExportView
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
            this.RadKunden = new System.Windows.Forms.RadioButton();
            this.CmdOfd = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.CmdExport = new System.Windows.Forms.Button();
            this.GrpDaten = new System.Windows.Forms.GroupBox();
            this.GrpFromat = new System.Windows.Forms.GroupBox();
            this.RadJson = new System.Windows.Forms.RadioButton();
            this.RadXml = new System.Windows.Forms.RadioButton();
            this.GrpDaten.SuspendLayout();
            this.GrpFromat.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadKunden
            // 
            this.RadKunden.AutoSize = true;
            this.RadKunden.Checked = true;
            this.RadKunden.Location = new System.Drawing.Point(16, 36);
            this.RadKunden.Name = "RadKunden";
            this.RadKunden.Size = new System.Drawing.Size(80, 24);
            this.RadKunden.TabIndex = 0;
            this.RadKunden.TabStop = true;
            this.RadKunden.Text = "Kunden";
            this.RadKunden.UseVisualStyleBackColor = true;
            // 
            // CmdOfd
            // 
            this.CmdOfd.Location = new System.Drawing.Point(435, 12);
            this.CmdOfd.Name = "CmdOfd";
            this.CmdOfd.Size = new System.Drawing.Size(94, 29);
            this.CmdOfd.TabIndex = 1;
            this.CmdOfd.Text = "Öffnen";
            this.CmdOfd.UseVisualStyleBackColor = true;
            this.CmdOfd.Click += new System.EventHandler(this.CmdOfd_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(11, 14);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(418, 27);
            this.TxtPath.TabIndex = 2;
            // 
            // CmdExport
            // 
            this.CmdExport.Location = new System.Drawing.Point(535, 12);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(94, 29);
            this.CmdExport.TabIndex = 44;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.CmdExport_Click);
            // 
            // GrpDaten
            // 
            this.GrpDaten.Controls.Add(this.RadKunden);
            this.GrpDaten.Location = new System.Drawing.Point(12, 57);
            this.GrpDaten.Name = "GrpDaten";
            this.GrpDaten.Size = new System.Drawing.Size(193, 165);
            this.GrpDaten.TabIndex = 45;
            this.GrpDaten.TabStop = false;
            this.GrpDaten.Text = "Daten";
            // 
            // GrpFromat
            // 
            this.GrpFromat.Controls.Add(this.RadJson);
            this.GrpFromat.Controls.Add(this.RadXml);
            this.GrpFromat.Location = new System.Drawing.Point(249, 57);
            this.GrpFromat.Name = "GrpFromat";
            this.GrpFromat.Size = new System.Drawing.Size(181, 165);
            this.GrpFromat.TabIndex = 46;
            this.GrpFromat.TabStop = false;
            this.GrpFromat.Text = "Format";
            // 
            // RadJson
            // 
            this.RadJson.AutoSize = true;
            this.RadJson.Location = new System.Drawing.Point(15, 66);
            this.RadJson.Name = "RadJson";
            this.RadJson.Size = new System.Drawing.Size(65, 24);
            this.RadJson.TabIndex = 1;
            this.RadJson.Text = "JSON";
            this.RadJson.UseVisualStyleBackColor = true;
            // 
            // RadXml
            // 
            this.RadXml.AutoSize = true;
            this.RadXml.Checked = true;
            this.RadXml.Location = new System.Drawing.Point(15, 36);
            this.RadXml.Name = "RadXml";
            this.RadXml.Size = new System.Drawing.Size(59, 24);
            this.RadXml.TabIndex = 0;
            this.RadXml.TabStop = true;
            this.RadXml.Text = "XML";
            this.RadXml.UseVisualStyleBackColor = true;
            // 
            // ExportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.GrpFromat);
            this.Controls.Add(this.GrpDaten);
            this.Controls.Add(this.CmdExport);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.CmdOfd);
            this.Name = "ExportView";
            this.Text = "Export";
            this.GrpDaten.ResumeLayout(false);
            this.GrpDaten.PerformLayout();
            this.GrpFromat.ResumeLayout(false);
            this.GrpFromat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadKunden;
        private System.Windows.Forms.Button CmdOfd;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.GroupBox GrpDaten;
        private System.Windows.Forms.GroupBox GrpFromat;
        private System.Windows.Forms.RadioButton RadJson;
        private System.Windows.Forms.RadioButton RadXml;
    }
}