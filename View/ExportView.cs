using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Data.Export;

namespace db_projektarbeit.View
{
    public partial class ExportView : Form
    {
        public ExportView()
        {
            InitializeComponent();
        }

        private void CmdOfd_Click(object sender, EventArgs e)
        {

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "xml files (*.xml)|*.xml|Json files (*.json)|*.json";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var _customerExport = new CustomerExport(saveFileDialog.FileName, new XmlExportStrategy());
                }

            }

        }
    }
}
