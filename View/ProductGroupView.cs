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
                    Name = TxtProductGrupName.Text                        // Anzeigetext
                };
                ProductGroupControl.UpdateNode(updateProductGroup);         // zu löschendes Element übergeben
            }
            else
            {
                var updateProductGroup = new ProductGroup()                 // hat der Node kein Elternelement
                {
                    Id = int.Parse(selectedNode.Name),                      // Id des aktuellen Node
                    Name = TxtProductGrupName.Text,                       // Anzeigetext
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
                    Name = TxtProductGrupName.Text                                  // Anzeigetext
                };
            }
            else
            {
                deletedProductGroup = new ProductGroup()                            // hat der Node kein Elternelement
                {
                    Id = int.Parse(selectedNode.Name),                              // Id des aktuellen Node
                    Name = TxtProductGrupName.Text,                                 // Anzeigetext
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
                    MessageBox.Show("Die Artkielgruppe hat noch untergruppen die "
                                    + " zuerst glöscht werden müssen");
                }
            }
            else
            {

                string products = "\r\n";
                foreach (var item in onUsedProductGroup)
                {
                    products += "- "+ item.ToString() + "\r\n";
                }
                MessageBox.Show("Die Folgenden Artiekl sind in der Artikelgruppe "
                                + selectedNode.Name + "(" + selectedNode.Text + ")"
                                + " und können somit nicht gelöscht werden"
                                + products);
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
            TxtProductGrupName.Text = name;
        }

        private void CmdNewNode_Click(object sender, EventArgs e)
        {
            if (TvProductGroup.SelectedNode != null)
            {
                var selectedNode = TvProductGroup.SelectedNode;
                ProductGroup newAritkelGroup;
                if (selectedNode.Parent == null)
                {

                    newAritkelGroup = new ProductGroup()
                    {
                        Name = TxtProductGrupName.Text
                    };
                    ProductGroupControl.AddNode(newAritkelGroup);

                }
                else
                {
                    newAritkelGroup = new ProductGroup()
                    {
                        Name = TxtProductGrupName.Text,
                        ParentId = int.Parse(selectedNode.Parent.Name)

                    };
                    ProductGroupControl.AddNode(newAritkelGroup);

                }

                LoadTreeViewDefault();
            }
        }

        private void CmdNewChildNode_Click(object sender, EventArgs e)
        {
            if (TvProductGroup.SelectedNode != null)
            {
                var selectedNode = TvProductGroup.SelectedNode;
                int selectId = int.Parse(selectedNode.Name);

                var newAritkelGroup = new ProductGroup()
                {
                    Name = TxtProductGrupName.Text,
                    ParentId = selectId
                };

                ProductGroupControl.AddNode(newAritkelGroup);

                LoadTreeViewDefault();
            }
        }

        private void UnlockFields()
        {
            TxtProductGrupName.ReadOnly = false;
        }

        private void LockFields()
        {
            TxtProductGrupName.ReadOnly = true;
        }


    }
}
