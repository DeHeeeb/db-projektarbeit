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
using db_projektarbeit.View.Common;
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

            TvProductGroup.ExpandAll();
        }

        public void LoadTreeView(TreeNode[] treeNodes)
        {
            TvProductGroup.Nodes.Clear();                                   // Nodes in Treeview löschen
            TvProductGroup.Nodes.AddRange(treeNodes);                       // Daten in Treeview aktualisieren
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;                 // Selektierter Node 
            LockFields();                                                   // Eingabefeler Sperrren
            if (selectedNode.Parent == null)                                // hat der Node ein Elternelement
            {
                var updateProductGroup = new ProductGroup()                 // Neues ProducteGruppe Element erzeugen
                {
                    Id = int.Parse(selectedNode.Name),                      // Id des aktuellen Node         
                    Name = TxtProductGroupName.Text                        // Anzeigetext
                };
                ProductGroupControl.UpdateNode(updateProductGroup);         // zu löschendes Element übergeben
            }
            else
            {
                var updateProductGroup = new ProductGroup()                 // hat der Node kein Elternelement
                {
                    Id = int.Parse(selectedNode.Name),                      // Id des aktuellen Node
                    Name = TxtProductGroupName.Text,                       // Anzeigetext
                    ParentId = int.Parse(selectedNode.Parent.Name)          // Id des Eltern Node
                };
                ProductGroupControl.UpdateNode(updateProductGroup);         // zu löschendes Element übergeben
            }

            LoadTreeViewDefault();                                          // TreeView aktuallisieren
            UnlockFields();                                                 // Eingabefelder Freigeben
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            var selectedNode = TvProductGroup.SelectedNode;                         // Selektierter Node 
            LockFields();                                                           // Eingabefeler Sperrren

            List<Product> onUsedProductGroup;
            ProductGroup deletedProductGroup;
            if (selectedNode.Parent == null)                                        // hat der Node ein Elternelement
            {
                deletedProductGroup = new ProductGroup()                            // Neues ProducteGruppen Element erzeugen
                {
                    Id = int.Parse(selectedNode.Name),                              // Id des aktuellen Node         
                    Name = TxtProductGroupName.Text                                  // Anzeigetext
                };
            }
            else
            {
                deletedProductGroup = new ProductGroup()                            // hat der Node kein Elternelement
                {
                    Id = int.Parse(selectedNode.Name),                              // Id des aktuellen Node
                    Name = TxtProductGroupName.Text,                                 // Anzeigetext
                    ParentId = int.Parse(selectedNode.Parent.Name)                  // Id des Eltern Node
                };
            }

            onUsedProductGroup = ProductGroupControl
                                    .SearchUsedProductGroup(deletedProductGroup);   // Product suchen die eine Verbindung
                                                                                    // zu dieser ProductGruppe haben
            if (onUsedProductGroup.Count == 0)
            {
                if (selectedNode.Nodes.Count == 0)
                {
                    ProductGroupControl.DeleteNode(deletedProductGroup);
                }
                else
                {
                    MessageBox.Show(MessageBoxConstants.TextErrorDeletedArticleGroup,
                        MessageBoxConstants.CaptionError,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                string products = "\r\n";
                foreach (var item in onUsedProductGroup)
                {
                    products += "- "+ item.ToString() + "\r\n";
                }
                MessageBox.Show(String.Format(MessageBoxConstants.TextErrorDeleteLinkedArticles, selectedNode.Name, selectedNode.Text, products),
                    MessageBoxConstants.CaptionError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            LoadTreeViewDefault();                                                  // TreeView aktuallisieren
            UnlockFields();                                                         // Eingabefelder Freigeben
        }

        private void TvProductGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UnlockFields();
            var selected = (TreeView)sender;
            int selectId = int.Parse(selected.SelectedNode.Name);
            string name = selected.SelectedNode.Text;

            TxtProductGrupNr.Text = selectId.ToString();
            TxtProductGroupName.Text = name;

            DeVisibleNewNode();
            VisibleUpdateDelete();
        }

        private void CmdNewNode_Click(object sender, EventArgs e)
        {
            if (TvProductGroup.SelectedNode != null)
            {
                var selectedNode = TvProductGroup.SelectedNode;
                ProductGroup newArtikelGroup;
                if (selectedNode.Parent == null)
                {

                    newArtikelGroup = new ProductGroup()
                    {
                        Name = TxtProductGroupName.Text
                    };
                    ProductGroupControl.AddNode(newArtikelGroup);

                }
                else
                {
                    newArtikelGroup = new ProductGroup()
                    {
                        Name = TxtProductGroupName.Text,
                        ParentId = int.Parse(selectedNode.Parent.Name)

                    };
                    ProductGroupControl.AddNode(newArtikelGroup);

                }

                LoadTreeViewDefault();
            }
            DeVisibleNewNode();
        }

        private void CmdNewChildNode_Click(object sender, EventArgs e)
        {
            if (TvProductGroup.SelectedNode != null)
            {
                var selectedNode = TvProductGroup.SelectedNode;
                int selectId = int.Parse(selectedNode.Name);

                var newArtikelGroup = new ProductGroup()
                {
                    Name = TxtProductGroupName.Text,
                    ParentId = selectId
                };

                ProductGroupControl.AddNode(newArtikelGroup);

                LoadTreeViewDefault();
            }

            DeVisibleNewNode();
        }

        private void CmdNewGroup_Click(object sender, EventArgs e)
        {
            ClearFields();
            UnlockFields();
            VisibleNewNode();
            DeVisibleUpdateDelete();
            TxtProductGrupNr.Text = "...";
        }

        private void UnlockFields()
        {
            TxtProductGroupName.ReadOnly = false;
        }

        private void LockFields()
        {
            TxtProductGroupName.ReadOnly = true;
        }

        private void ClearFields()
        {
            TxtProductGroupName.Clear();
        }

        private void VisibleNewNode()
        {
            CmdNewNode.Visible = true;
            CmdNewChildNode.Visible = true;
        }

        private void DeVisibleNewNode()
        {
            CmdNewNode.Visible = false;
            CmdNewChildNode.Visible = false;
        }

        private void VisibleUpdateDelete()
        {
            CmdDelete.Visible = true;
            CmdUpdate.Visible = true;
        }

        private void DeVisibleUpdateDelete()
        {
            CmdDelete.Visible = false;
            CmdUpdate.Visible = false;
        }


    }
}
