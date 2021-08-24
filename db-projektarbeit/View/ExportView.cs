using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Data.Export;
using db_projektarbeit.View.Common;

namespace db_projektarbeit.View
{
    public partial class ExportView : Form
    {

        private string path;
        public ExportView()
        {
            InitializeComponent();
        }

        private void CmdOfd_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "Export files (*.xml;*.json)|*.xml;*.json";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                    TxtPath.Text = path;
                }
            }
        }

        private void CmdExport_Click(object sender, EventArgs e)
        {
            if (path != string.Empty)
            {
                if (RadXml.Checked == true)
                {
                    var _customerExport = new CustomerExport(path, new XmlExportStrategy());
                }
                else if (RadJson.Checked == true)
                {
                    var _customerExport = new CustomerExport(path, new JsonExportStrategy());
                }

                MessageBox.Show(MessageBoxConstants.TextExportSuccessful,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
