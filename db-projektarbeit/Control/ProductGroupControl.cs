﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using db_projektarbeit.Repository;

namespace db_projektarbeit.Control
{
    class ProductGroupControl
    {
        private readonly ProductGroupRepository ProductGroupRepository = new ProductGroupRepository(new ProjectContext());
        private readonly ProductControl ProductControl = new ProductControl();

        public List<ProductGroup> GetAll()
        {
            using ProjectContext context = new ProjectContext();
            return ProductGroupRepository.GetAll(context);
        }

        public int AddNode(ProductGroup productGroup)
        {
            using ProjectContext context = new ProjectContext();
            var saved = ProductGroupRepository.Save(productGroup, context);
            return saved.Id;
        }

        public int UpdateNode(ProductGroup productGroup)
        {
            using ProjectContext context = new ProjectContext();
            var updated = ProductGroupRepository.Update(productGroup, context);
            return updated.Id;
        }

        public List<Product> SearchUsedProductGroup(ProductGroup productGroup)
        {
            return ProductControl.SearchUsedProductGroup(productGroup);
        }

        public int DeleteNode(ProductGroup productGroup)
        {
            using ProjectContext context = new ProjectContext();
            var deleted = ProductGroupRepository.Delete(productGroup.Id, context);

            return deleted?.Id ?? 0;
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