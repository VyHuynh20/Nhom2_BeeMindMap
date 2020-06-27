using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using BeeMindMap_UI.Models;
using Guna.UI2.WinForms.Suite;

namespace BeeMindMap_UI.Views
{
    public partial class TreeUI_Form : Form
    {
        public static List<TreeNode> treeNodes;
        public int X = 0;
        public int Y = 0;
        public bool CanMove = false;
        public int beeTreeMap_font = 18;
        public string fileName = "Untitled";
        public static TreeNode mySelectedNode;
        //public event NodeLabelEditEventHandler AfterLabelEdit;
        public TreeUI_Form()
        {
            InitializeComponent();
            treeNodes = new List<TreeNode>();
            //if (fileName != String.Empty)
            //{
            //    this.fileName = fileName;
            //    OpenFile(fileName);
            //}

            openFile.Filter = "Data Files (*.bee)|*.bee";
            openFile.DefaultExt = "bee";
            openFile.AddExtension = true;

            saveFile.Filter = "Data Files (*.bee)|*.bee";
            saveFile.DefaultExt = "bee";
            saveFile.AddExtension = true;
        }
        public void beeTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            mySelectedNode = beeTreeView.GetNodeAt(e.X, e.Y);
            if (mySelectedNode != null)
            {
                lbfont.Text = mySelectedNode.NodeFont.FontFamily.Name.ToString();
                lbStyle.Text = mySelectedNode.NodeFont.Style.ToString();
                lbSize.Text = Convert.ToInt32(mySelectedNode.NodeFont.Size).ToString();
                button1.BackColor = mySelectedNode.ForeColor;
                textBox1.Text = mySelectedNode.ForeColor.R + ", " + mySelectedNode.ForeColor.G + ", " + mySelectedNode.ForeColor.B;
                foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
                {
                    if (customMapNode.ID == mySelectedNode.Name)
                    {
                        foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                        {
                            customMapNode1.NodeSelected = false;
                            customMapNode1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        }
                        customMapNode.NodeSelected = true;
                        MapUI_Form.mySelectedMapNode = customMapNode;
                        customMapNode.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        break;
                    }
                }
            }
            else
            {
                beeTreeView.SelectedNode = null;
            }
        }

        public void beeTreeView_Click(object sender, EventArgs e)
        {
            if (mySelectedNode != null)
            {
                beeTreeView.SelectedNode = mySelectedNode;
                beeTreeView.LabelEdit = true;
                if (!mySelectedNode.IsEditing)
                {
                    mySelectedNode.BeginEdit();
                }
            }
        }

        public void beeTreeView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            mySelectedNode = e.Node;
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                   // MapUI_Form.mySelectedMapNode.MainTextBox.c = false;
                    MapUI_Form.mySelectedMapNode.MainTextBox.Text = e.Label;
                    e.Node.EndEdit(false);                    
                }
                else
                {
                    e.CancelEdit = true;
                    e.Node.BeginEdit();
                }
            }
        }


        #region Function to SAVE and OPEN file
        //save file
        public void SaveFile(string fileName)
        {
            try
            {
                using (Stream file = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    foreach(TreeNode treeNode in TreeUI_Form.treeNodes)
                    {
                        foreach(CustomMapNode customMapNode in MapUI_Form.customMapNodes)
                        {
                            if (customMapNode.ID == treeNode.Name)
                                treeNode.Name = customMapNode.ToString();
                        }
                    }
                    bf.Serialize(file, beeTreeView.Nodes.Cast<TreeNode>().ToList());
                }
                /*
                BinaryFormatter bin = new BinaryFormatter();
                BeeTreeNode btn = BeeTreeNodeOperations.prepareToWrite(this.beeTreeView);

                //update in the file
                FileStream fileTree = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                bin.Serialize(fileTree, btn);
                fileTree.Close();
                */
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Bee Tree", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //open file
        public void OpenFile(string fileName)
        {
            try
            {
                using (Stream file = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    object obj = bf.Deserialize(file);

                    TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                    beeTreeView.Nodes.AddRange(nodeList);
                    TreeUI_Form.treeNodes.Clear();
                    CallRecursive(beeTreeView);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Bee Tree", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// 
        private void PrintRecursive(TreeNode treeNode)
        {
            // in ra các node. 
            TreeUI_Form.treeNodes.Add(treeNode);
            CustomMapNode customMapNode = new CustomMapNode(treeNode.Name);
            treeNode.Name = customMapNode.ID = DateTime.Now.ToString();
            customMapNode.MainTextBox.Text = treeNode.Text;
            MapUI_Form.customMapNodes.Add(customMapNode);
            if (TreeUI_Form.treeNodes.Count == 1)
            {
                customMapNode.Location = new Point(0, 325);
            }
            if (treeNode.Parent != null)
            {
                //foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                //{
                //    if (customMapNode1.ID == treeNode.Parent.Name)
                //    {
                //        customMapNode.line(customMapNode1);
                //        break;
                //    }
                //}
                for (int i = 0; i < MapUI_Form.customMapNodes.Count; i++)
                {
                    if (MapUI_Form.customMapNodes[i].ID == treeNode.Parent.Name)
                    {
                        customMapNode.line(MapUI_Form.customMapNodes[i]);
                        break;
                    }
                }
            }
            // Sử dụng đệ quy để in ra từng node. 
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        // Gọi thủ tục sử dụng TreeView 
        private void CallRecursive(TreeView treeView)
        {
            // IN ra từng node sử dụng đệ quy. 
            foreach (TreeNode n in treeView.Nodes)
            {
                PrintRecursive(n);
            }
        }

        private void DeleteRecursive(TreeNode treeNode)
        {
            // in ra các node. 
            foreach(CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
            {
                if (customMapNode1.ID == treeNode.Name)
                {
                    customMapNode1.NodeSelected = true;
                    break;
                }    
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                DeleteRecursive(tn);
            }
        }

        // Gọi thủ tục sử dụng TreeView 
        public void DeleteRecursive()
        {
            // IN ra từng node sử dụng đệ quy. 
            TreeNodeCollection nodes = beeTreeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                DeleteRecursive(n);
            }
        }
        public void SetFormTitle()
        {
            FileInfo fileInfo = new FileInfo(fileName);
            this.Text = fileInfo.Name + " - Bee Tree";
        }

        #endregion

        public void AddRoot()
        {
            TreeNode treeNode = new TreeNode("New Root...");
            treeNode.Name = DateTime.Now.ToString();
            treeNode.NodeFont = new Font("arial", 18, FontStyle.Regular);
            treeNode.ForeColor = System.Drawing.Color.Black;
            if (beeTreeView.Nodes.Count==0)
            {
                beeTreeView.Nodes.Add(treeNode);
            }
            else
            {
                beeTreeView.Nodes[0].Nodes.Add(treeNode);
            }
            treeNodes.Add(treeNode);
            mySelectedNode = treeNode;
            beeTreeView.SelectedNode = mySelectedNode;
            treeNode.ExpandAll();
            
        }

        public void AddNode()
        {
            if (beeTreeView.SelectedNode is null)
                AddRoot();
            else
            {
                TreeNode treeNode = new TreeNode("New Node...");
                treeNode.Name = DateTime.Now.ToString();
                treeNode.NodeFont = new Font("arial", 18, FontStyle.Regular);
                treeNode.ForeColor = System.Drawing.Color.Black;
                beeTreeView.SelectedNode.Nodes.Add(treeNode);
                mySelectedNode = treeNode;
                beeTreeView.SelectedNode = mySelectedNode;
                treeNodes.Add(treeNode);
                treeNode.ExpandAll();
            }
        }

        private void beeTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Oemplus && beeTreeMap_font < 100)
            {
                beeTreeMap_font++;
                beeTreeView.Font = new Font("Arial", beeTreeMap_font);
            }
            if (e.Control && e.KeyCode == Keys.OemMinus && beeTreeMap_font > 8)
            {
                beeTreeMap_font--;
                beeTreeView.Font = new Font("Arial", beeTreeMap_font);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnTopTool_MouseDown(object sender, MouseEventArgs e)
        {
            CanMove = true;
            X = e.X;
            Y = e.Y;
        }

        private void pnTopTool_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanMove)
            {
                this.pnTool.Left += e.X - X;
                this.pnTool.Top += e.Y - Y;
            }
        }

        private void pnTool_MouseUp(object sender, MouseEventArgs e)
        {
            CanMove = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.pnTool.Size.Height == 192)
                this.pnTool.Size = new Size(251, 38);
            else
                this.pnTool.Size = new Size(251, 192);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                textBox1.Text = colorDialog1.Color.R + ", " + colorDialog1.Color.G + ", " + colorDialog1.Color.B;
                if (mySelectedNode != null)
                {
                    mySelectedNode.ForeColor = button1.BackColor;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lbfont.Text = fontDialog1.Font.FontFamily.Name;
                lbStyle.Text = fontDialog1.Font.Style.ToString();
                lbSize.Text = Convert.ToInt32(fontDialog1.Font.Size).ToString();
            }
            if (mySelectedNode != null)
            {
                mySelectedNode.NodeFont = fontDialog1.Font;
            }
        }

        private void pnTool_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
