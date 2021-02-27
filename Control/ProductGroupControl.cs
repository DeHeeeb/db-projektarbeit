using db_projektarbeit.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace db_projektarbeit.Control
{
    class ProductGroupControl
    {
        private readonly ProductGroupModel ProductGroupModel = new ProductGroupModel();
        private readonly ProductControl ProductControl = new ProductControl();

        public List<ProductGroup> GetAll()
        {
            return ProductGroupModel.GetAll();
        }

        public int AddNode(ProductGroup productGroup)
        {
            return ProductGroupModel.Add(productGroup);
        }

        public int UpdateNode(ProductGroup productGroup)
        {
            return ProductGroupModel.Update(productGroup);
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return ProductControl.SearchUsedProductGroup(productGroup);
        }

        public int DeleteNode(ProductGroup productGroup)
        {
            return ProductGroupModel.Delete(productGroup);
        }

        public TreeNode[] ConvertToTreeNodes(List<ProductGroup> productGroups)
        {
            List<TreeNode> listTreeNodes = new List<TreeNode>(); 

            var root = productGroups.Where(p => p.ParentId == null);

            foreach (var parent in root)
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
