using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace db_projektarbeit.Model
{
    class ProductGroupModel
    {
        public List<ProductGroup> GetAll()
        {
            var productGroups = new List<ProductGroup>();

            using (var context = new ProjectContext())
            {
                productGroups = context.ProductGroups
                    .Include(p => p.Children)
                    .Include(p => p.Parent)
                    .ToList();
                /*var result = context.ProductGroups.FromSqlRaw(
                    ";WITH CTE_ProductGroup " +
                    "(Id, ProductId, Name, ParentProductId, ProductLevel) " +
                    "AS (SELECT " +
                                "Id," +
                                "ProductId,"+
                                "Name," +
                                "ParentProductId," +
                                "0 AS ProductLevel " +
                    "FROM dbo.ProductGroups " +
                    "WHERE ParentProductId IS NULL " +
                    "UNION ALL " +
                    "SELECT " +
                                "pn.Id," +
                                "pn.ProductId," +
                                "pn.Name," +
                                "pn.ParentProductId," +
                                "p1.ProductLevel + 1 " +
                    "FROM dbo.ProductGroups AS pn " +
                    "INNER JOIN CTE_ProductGroup AS p1 " +
                        "ON p1.Id = pn.ParentProductId " +
                    ") " +
                    "SELECT " +
                                "Id," +
                                "ProductId," +
                                "Name," +
                                "ParentProductId," +
                                "ProductLevel " +
                    "FROM CTE_ProductGroup " +
                    "ORDER BY ParentProductId;"
                    );

                foreach (var item in result)
                {
                    productGroups.Add(item);
                }
            }*/
            }

            return productGroups;
        }

        public TreeView GetTreeView()
        {
            TreeView newTreeView = new TreeView();
            List<TreeNode> new1TreeNode = new List<TreeNode>();
            TreeNode newTreeNode = new TreeNode("", new1TreeNode.ToArray());

            //List<ProductGroup> test = GetAll();
            //test.Where(x => x.ParentProductId.Equals(null))

            return newTreeView;
        }

        private TreeNode CreateTreeNode(ProductGroup productGroup)
        {
            TreeNode newTreeNode = new TreeNode();

            newTreeNode.Text = productGroup.Name;  // Absichtlich MTR
            newTreeNode.Name = productGroup.Name;
            newTreeNode.Tag = productGroup.ProductId;

            return newTreeNode;
        }

        private void rekCreateTreeNode(TreeNode parentNode, List<ProductGroup> productGroups)
        {
        }
    }
}
