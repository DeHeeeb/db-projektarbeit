using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;

namespace db_projektarbeit.View
{
    public partial class ProductGroupView : Form
    {

        ProductGroupControl ProductGroupControl = new ProductGroupControl();

        public ProductGroupView()
        {
            InitializeComponent();
            LoadTable(ProductGroupControl.GetAll());
        }

        private void LoadTable(List<ProductGroup> productGroups)
        {
            TvProductGroup.BeginUpdate();
            TvProductGroup.Nodes.Add("Parent");
            TvProductGroup.Nodes[0].Nodes.Add("Child 1");
            TvProductGroup.Nodes[0].Nodes.Add("Child 2");
            TvProductGroup.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            TvProductGroup.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            TvProductGroup.EndUpdate();
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            //var productGroups = ProductGroupControl.GetAllProductGroup();
        }
    }
}
