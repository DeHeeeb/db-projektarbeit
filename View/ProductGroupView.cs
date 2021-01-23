using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;
using System.Linq;

namespace db_projektarbeit.View
{
    public partial class ProductGroupView : Form
    {

        ProductGroupControl ProductGroupControl = new ProductGroupControl();

        public ProductGroupView()
        {
            InitializeComponent();
            var arrayNodes = ProductGroupControl.ConvertToTreeNodes(ProductGroupControl.GetAll());
            LoadTreeView(arrayNodes);
        }

        public void LoadTreeView(TreeNode[] treeNodes)
        {
            TvProductGroup.Nodes.AddRange(treeNodes);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //var productGroups = ProductGroupControl.GetAllProductGroup();
        }

        private void TvProductGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
