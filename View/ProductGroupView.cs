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
            LoadTable(ProductGroupControl.GetAll());
        }

        private void LoadTable(List<ProductGroup> productGroups)
        {
            var root = productGroups.Where(p => p.ParentId == null);

            foreach (var parent in root)
            {
                var parentNode = TvProductGroup.Nodes.Add(parent.Id.ToString(), parent.Name);
                if (parent.Children != null)
                {
                    PopulateChildren(parentNode, parent.Children);
                }
            }
        }
        private static void PopulateChildren(TreeNode parentNode, IEnumerable<ProductGroup> children)
        {
            foreach (var child in children)
            {
                var newNode = parentNode.Nodes.Add(child.Id.ToString(), child.Name);
                if (child.Children != null)
                {
                    PopulateChildren(newNode, child.Children);
                }
            }
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
