using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using db_projektarbeit.Control;
using System.Linq;
using Newtonsoft.Json.Bson;

namespace db_projektarbeit.View
{
    public partial class ProductGroupView : Form
    {

        ProductGroupControl ProductGroupControl = new ProductGroupControl();

        public ProductGroupView()
        {
            InitializeComponent();
            LoadTreeViewDefault();
        }

        public void LoadTreeViewDefault()
        {
            var arrayNodes = ProductGroupControl.ConvertToTreeNodes(ProductGroupControl.GetAll());
            LoadTreeView(arrayNodes);
        }

        public void LoadTreeView(TreeNode[] treeNodes)
        {
            TvProductGroup.Nodes.Clear();
            TvProductGroup.Nodes.AddRange(treeNodes);
        }

        private void CmdUpdateNode_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;
            LockFields();
            if (selectedNode.Parent == null)
            {
                var updateProductGroup = new ProductGroup()
                {
                    Id = int.Parse(selectedNode.Name),
                    Name = TxtArtikelGruppeName.Text
                };
                ProductGroupControl.UpdateNode(updateProductGroup);
            }
            else
            {
                var updateProductGroup = new ProductGroup()
                {
                    Id = int.Parse(selectedNode.Name),
                    Name = TxtArtikelGruppeName.Text,
                    ParentId = int.Parse(selectedNode.Parent.Name)
                };
                ProductGroupControl.UpdateNode(updateProductGroup);
            }

            LoadTreeViewDefault();
            UnlockFields();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;
            LockFields();
            if (selectedNode.Parent == null)
            {
                var updateProductGroup = new ProductGroup()
                {
                    Id = int.Parse(selectedNode.Name),
                    Name = TxtArtikelGruppeName.Text
                };
                ProductGroupControl.UpdateNode(updateProductGroup);
            }
            else
            {
                var updateProductGroup = new ProductGroup()
                {
                    Id = int.Parse(selectedNode.Name),
                    Name = TxtArtikelGruppeName.Text,
                    ParentId = int.Parse(selectedNode.Parent.Name)
                };
                ProductGroupControl.UpdateNode(updateProductGroup);
            }

            LoadTreeViewDefault();
            UnlockFields();
        }

        private void TvProductGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UnlockFields();
            var selected = (TreeView)sender;
            int selectId = int.Parse(selected.SelectedNode.Name);
            string name = selected.SelectedNode.Text;

            TxtArtikelGruppeNr.Text = selectId.ToString();
            TxtArtikelGruppeName.Text = name;
        }

        private void CmdNewNode_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;
            if (selectedNode.Parent == null)
            {

                var newAritkelGroup = new ProductGroup()
                {
                    Name = TxtArtikelGruppeName.Text
                };
                ProductGroupControl.AddNode(newAritkelGroup);

            }
            else
            {
                var newAritkelGroup = new ProductGroup()
                {
                    Name = TxtArtikelGruppeName.Text,
                    ParentId = int.Parse(selectedNode.Name)

                };
                ProductGroupControl.AddNode(newAritkelGroup);

            }

            LoadTreeViewDefault();
        }

        private void CmdNewChildNode_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;
            int selectId = int.Parse(selectedNode.Name);

            var newAritkelGroup = new ProductGroup()
            {
                Name = TxtArtikelGruppeName.Text,
                ParentId = selectId
            };

            ProductGroupControl.AddNode(newAritkelGroup);

            LoadTreeViewDefault();
        }

        private void UnlockFields()
        {
            TxtArtikelGruppeName.ReadOnly = false;
        }

        private void LockFields()
        {
            TxtArtikelGruppeName.ReadOnly = true;
        }


    }
}
