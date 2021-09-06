using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;
using db_projektarbeit.Data.Export;
using db_projektarbeit.View.Common;
using Microsoft.Extensions.DependencyInjection;

namespace db_projektarbeit.View
{
    public partial class ExportView : Form
    {
        private IServiceProvider _provider;
        private string path;
        public ExportView()
        {
            InitializeComponent();
        }

        public void SetProvider(IServiceProvider provider)
        {
            _provider = provider;
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
            if (!string.IsNullOrEmpty(path))
            {
                if (RadXml.Checked == true)
                {
                    var _customerExport = new CustomerExport(path, new XmlExportStrategy(), _provider.GetRequiredService<CustomerControl>());
                }
                else if (RadJson.Checked == true)
                {
                    var _customerExport = new CustomerExport(path, new JsonExportStrategy(), _provider.GetRequiredService<CustomerControl>());
                }

                MessageBox.Show(MessageBoxConstants.TextExportSuccessful,
                    MessageBoxConstants.CaptionInformation,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
