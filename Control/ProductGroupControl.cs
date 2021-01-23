using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using db_projektarbeit.Model;
using System.Windows.Forms;

namespace db_projektarbeit.Control
{
    class ProductGroupControl
    {
        private ProductGroupModel ProductGroupModel = new ProductGroupModel();

        private ProductControl ProductControl = new ProductControl();

        public List<ProductGroup> GetAll()
        {
            return ProductGroupModel.GetAll();
        }

        public int AddNode(ProductGroup productGroup)
        {
            return ProductGroupModel.AddNode(productGroup);
        }

        public int UpdateNode(ProductGroup productGroup)
        {
            return ProductGroupModel.UpdateNode(productGroup);
        }

        public TreeNode[] ConvertToTreeNodes(List<ProductGroup> productGroups)
        {
            List<TreeNode> listTreeNodes = new List<TreeNode>();                                    // Liste von TreeNode

            var root = productGroups.Where(p => p.ParentId == null);// Root Node suchen

            foreach (var parent in root)                                                 // 
            {
                var parentNode = new TreeNode(parent.Name)
                {
                    Name = parent.Id.ToString()
                };

                if (parent.Children != null)
                {
                    PopulateChildren(parentNode, parent.Children);
                }

                listTreeNodes.Add(parentNode);
            }

            return listTreeNodes.ToArray();
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
    }
}
