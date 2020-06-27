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
using BeeMindMap_UI.Models;
using BeeMindMap_UI.Raws;

namespace BeeMindMap_UI.Views
{
    public partial class MainWorkUI_Form : Form
    {
        public Timer timerclock;
        public bool CanMove = false;
        public int X = 0;
        public int Y = 0;
        public bool IsEdit = false;
        public bool IsExpand = false;
        public bool IsMap = true;
        public bool IsTree;
        public string select = "";
        public Timer timer;
        public bool isMouse_Down;
        public int lastX;
        public int lastY;
        public MapUI_Form mapUI_Form;
        public TreeUI_Form treeUI_Form;
        public int beeTreeMap_font = 18;
        public MainWorkUI_Form()
        {
            InitializeComponent();
            CreateMap_Tree();
            CreateTimeNow();
        }
        private void CreateMap_Tree()
        {
            mapUI_Form = new MapUI_Form();
            mapUI_Form.TopLevel = false;
            pnWork.Controls.Add(mapUI_Form);
            mapUI_Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mapUI_Form.Dock = DockStyle.Fill;
            treeUI_Form = new TreeUI_Form();
            treeUI_Form.TopLevel = false;
            pnWork.Controls.Add(treeUI_Form);
            treeUI_Form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            treeUI_Form.Dock = DockStyle.Fill;
            if (IsMap)
            {
                mapUI_Form.Show();
                treeUI_Form.Hide();
                IsMap = true;
                IsTree = false;
            }
            else
            {
                treeUI_Form.Show();
                mapUI_Form.Hide();
                IsMap = false;
                IsTree = true;
            }
        }
        private void CreateTimeNow()
        {
            timerclock = new Timer();
            timerclock.Interval = 1000;
            timerclock.Start();
            timerclock.Tick += Timerclock_Tick;
        }

        private void Timerclock_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HEllo");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Panel pn = (Panel)sender;
            pn.BackColor = Color.FromArgb(254, 193, 7);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel pn = (Panel)sender;
            pn.BackColor = Color.White;
        }
        private void Button_Mouse_Leave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.White;
            bt.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        private void btExit_MouseHover(object sender, MouseEventArgs e)
        {
            btExit.ForeColor = Color.FromArgb(255, 193, 7);
        }
        private void btExit_MouseLeave(object sender, EventArgs e)
        {
            btExit.ForeColor = Color.White;
        }
        private void btMinsize_MouseHover(object sender, MouseEventArgs e)
        {
            btMinsize.ForeColor = Color.FromArgb(255, 193, 7);
        }
        private void btMinsize_MouseLeave(object sender, EventArgs e)
        {
            btMinsize.ForeColor = Color.White;
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btMinsize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BeeMap_Click(object sender, EventArgs e)
        {
            ResetClick_btBottom();
            viewUI.checkBox1.Checked = true;
            viewUI.checkBox2.Checked = false;
            Button bt = (Button)sender;
            btBeeMap.BackColor = btTreeView.BackColor = Color.White;
            btBeeMap.Font = btTreeView.Font = bt.Font = new Font("Arial", 9, FontStyle.Regular);
            bt.BackColor = Color.FromArgb(255, 195, 130);
            bt.Font = new Font("Arial", 10, FontStyle.Regular);

            btTool6.Visible = false;
            bttool3.Enabled = true;
            bttool4.Enabled = true;
            btShowFunction.Visible = true;
            bttool5.Visible = true;
            this.treeUI_Form.Hide();
            this.mapUI_Form.Show();
            IsMap = true;
            IsTree = false;
        }
        private void TreeView_Click(object sender, EventArgs e)
        {
            ResetClick_btBottom();
            viewUI.checkBox1.Checked = false;
            viewUI.checkBox2.Checked = true;
            Button bt = (Button)sender;
            btBeeMap.BackColor = btTreeView.BackColor = Color.White;
            btBeeMap.Font = btTreeView.Font = bt.Font = new Font("Arial", 9, FontStyle.Regular);
            bt.BackColor = Color.FromArgb(255, 195, 130);
            bt.Font = new Font("Arial", 10, FontStyle.Regular);

            btTool6.Visible = true;
            bttool3.Enabled = false;
            bttool4.Enabled = false;
            btShowFunction.Visible = false;
            bttool5.Visible = false;
            treeUI_Form.Show();
            mapUI_Form.Hide();
            IsMap = false;
            IsTree = true;
        }
        private void ButtonMapTree_Mouse_Move(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.Font = new Font("Arial", 11, FontStyle.Regular);
        }
        private void ButtonMapTree_Mouse_Leave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.BackColor == Color.FromArgb(255, 195, 130))
            {
                bt.Font = new Font("Arial", 10, FontStyle.Regular);
            }
            else
            {
                bt.Font = new Font("Arial", 9, FontStyle.Regular);
            }
        }
        private void Button_Mouse_Move(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.ForeColor = Color.FromArgb(254, 193, 7);
            bt.Font = new Font("Arial", 13, FontStyle.Bold);
            bt.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        
        private void btShowFunction_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1;
            timer.Start();
            if (mapUI_Form.pnTool.Width == 300)
            {
                timer.Tick += Timer_Tick;
            }
            if (mapUI_Form.pnTool.Width == 0)
            {
                timer.Tick += Timer_Tick1;
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mapUI_Form.pnTool.Width > 0)
            {
                mapUI_Form.pnTool.Width -= 10;
            }
            else
            {
                btShowFunction.BackgroundImage = Properties.Resources.back_50px;
                timer.Stop();
            }
        }
        private void Timer_Tick1(object sender, EventArgs e)
        {
            if (mapUI_Form.pnTool.Width < 300)
            {
                mapUI_Form.pnTool.Width += 10;
            }
            else
            {
                btShowFunction.BackgroundImage = Properties.Resources.right_50px;
                timer.Stop();
            }
        }

        private void btShowFunction_MouseMove(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btShowFunction_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btMaxsize_MouseMove(object sender, MouseEventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackgroundImage = Properties.Resources.maximize_button_c_36px;
        }

        private void btMaxsize_MouseLeave(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackgroundImage = Properties.Resources.maximize_button_36px;
        }

        private void btMaxsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                treeUI_Form.beeTreeView.Width = 867;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                treeUI_Form.beeTreeView.Width = 1100;
            }
            mapUI_Form.pnTool_List.Height = pnWork.Height - 33;
        }

        private void MainWorkUI_Form_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse_Down = true;
            lastX = e.X;
            lastY = e.Y;
        }

        private void MainWorkUI_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouse_Down)
            {
                this.Location = new Point(this.Top + (e.Y - lastY), this.Left + (e.X - lastX));
            }
        }

        private void MainWorkUI_Form_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse_Down = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.BackColor != Color.FromArgb(0,0,0,0))
                e.ClickedItem.BackColor = Color.FromArgb(0, 0, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (editUI1.Visible)
            {
                resetTopTool();
            }
            else
            {
                resetTopTool();
                editUI1.Visible = !editUI1.Visible;
            }
        }

        private void editUI1_SetButton1Clicked(object sender, EventArgs e)
        {
           
        }

        private void editUI1_SetButton2Clicked(object sender, EventArgs e)
        {
            
            btEdit.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            if (fileUI.Visible)
            {
                resetTopTool();
            }
            else
            {
                resetTopTool();
                fileUI.Visible = !fileUI.Visible;
            }
        }

        private void fileUI1_SetButton5Clicked(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void fileUI_SetButton1Clicked(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                messageBox.lbTitle.Text = "Bee Mind Map";
                messageBox.richTextBox1.Text = "Bạn Có Muốn Save?";
                messageBox.bt1.Visible = false;
                messageBox.ShowDialog();
                if (messageBox.DialogResult == DialogResult.Yes)
                {
                    fileUI_SetButton3Clicked(sender, e);
                }
            }
            this.NameWork.Text = "Name of Work...";
            mapUI_Form.Dispose();
            treeUI_Form.Dispose();
            CreateMap_Tree();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (insertUI.Visible)
            {
                resetTopTool();
            }
            else
            {
                resetTopTool();
                insertUI.Visible = !insertUI.Visible;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(viewUI.Visible)
            {
                resetTopTool();
            }
            else
            {
                resetTopTool();
                viewUI.Visible = !viewUI.Visible;
            }                
        }

        private void viewUI1_SetCheckMap_Tree(object sender, EventArgs e)
        {
            if (viewUI.checkBox1.Checked)
            {
                this.BeeMap_Click(btBeeMap, e);
            }
            else
            {
                this.TreeView_Click(btTreeView, e);
            }
        }

        private void viewUI_SetButton1Clicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.btMaxsize_Click(sender, e);
            }
            pnTop.Height = pnBottom.Height = 0;
            if (mapUI_Form.pnTool.Width > 0)
            {
                this.btShowFunction_Click(sender, e);
            }
            button1.Visible = true;
            time.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (userUI.Visible)
            {
                resetTopTool();
            }
            else
            {
                resetTopTool();
                userUI.Visible = !userUI.Visible;
            }
        }
        private void resetTopTool()
        {
            fileUI.Visible = editUI1.Visible = insertUI.Visible = viewUI.Visible = userUI.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetTopTool();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            time.Visible = false;
            pnTop.Height = 30;
            pnBottom.Height = 35;
            this.btShowFunction_Click(sender, e);
        }
        private void ResetClick_btBottom()
        {
            btTool6.BackColor = btTool7.BackColor = bttool1.BackColor = bttool2.BackColor = bttool3.BackColor = bttool4.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        private void btBottom_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            ResetClick_btBottom();
            Button bt = (Button)sender;
            select = bt.Name;
            CustomMapNode customMapNode;
            if (IsMap)
            {
                bt.BackColor = Color.FromArgb(255, 224, 192);
                switch (bt.Name)
                {
                    case "bttool1":
                        treeUI_Form.AddRoot();           
                        customMapNode = new CustomMapNode(TreeUI_Form.mySelectedNode.Text, 0, 0);
                        customMapNode.ID = TreeUI_Form.mySelectedNode.Name;
                        if (TreeUI_Form.treeNodes.Count == 1)
                        {
                            customMapNode.Location = new Point(0, mapUI_Form.panelMap.Height / 2);
                        }
                        MapUI_Form.customMapNodes.Add(customMapNode);
                        MapUI_Form.mySelectedMapNode = customMapNode;
                        mapUI_Form.panelMap.Controls.Add(customMapNode);
                        foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                        {
                            customMapNode1.NodeSelected = false;
                            customMapNode1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        }
                        MapUI_Form.mySelectedMapNode.NodeSelected = true;

                        if (TreeUI_Form.mySelectedNode.Parent != null)
                        {
                            foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                if (customMapNode1.ID == TreeUI_Form.mySelectedNode.Parent.Name)
                                {
                                    customMapNode.Location = new Point(customMapNode1.Location.X +customMapNode1.Width + 50, customMapNode1.Location.Y);
                                    MapUI_Form.mySelectedMapNode.line(customMapNode1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line2);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line3);
                                }
                            }
                        }
                        break;
                    case "bttool2":
                        FindSeclectedMapNode_TreeNode();
                        if (MapUI_Form.mySelectedMapNode is null) break;
                        else
                        {
                            treeUI_Form.AddNode();
                            customMapNode = new CustomMapNode(TreeUI_Form.mySelectedNode.Text, 0, 0);
                            customMapNode.ID = TreeUI_Form.mySelectedNode.Name;
                            if (TreeUI_Form.treeNodes.Count == 1)
                            {
                                customMapNode.Location = new Point(0, mapUI_Form.panelMap.Height / 2);
                            }
                            MapUI_Form.customMapNodes.Add(customMapNode);
                            MapUI_Form.mySelectedMapNode = customMapNode;
                            mapUI_Form.panelMap.Controls.Add(customMapNode);
                            foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                customMapNode1.NodeSelected = false;
                                customMapNode1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            }
                            MapUI_Form.mySelectedMapNode.NodeSelected = true;

                            if (TreeUI_Form.mySelectedNode.Parent != null)
                            {
                                foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                                {
                                    if (customMapNode1.ID == TreeUI_Form.mySelectedNode.Parent.Name)
                                    {
                                        customMapNode.Location = new Point(customMapNode1.Location.X + customMapNode1.Width + 50, customMapNode1.Location.Y);
                                        MapUI_Form.mySelectedMapNode.line(customMapNode1);
                                        mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line1);
                                        mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line2);
                                        mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line3);
                                    }
                                }
                            }
                        }                        
                        break;
                    case "btTool7":
                        if (MapUI_Form.mySelectedMapNode is null)
                            return;
                        else
                        {
                            foreach(TreeNode treeNode in TreeUI_Form.treeNodes)
                            {
                                if (treeNode.Name == MapUI_Form.mySelectedMapNode.ID)
                                {
                                    TreeUI_Form.mySelectedNode = treeNode;
                                    treeUI_Form.beeTreeView.SelectedNode = treeNode;
                                    break;
                                }
                            }
                            MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                            messageBox.richTextBox1.Text = "Bạn muôn xóa " + treeUI_Form.beeTreeView.SelectedNode.Text + " ?";
                            messageBox.bt1.Visible = false;
                            messageBox.ShowDialog();
                            if (messageBox.DialogResult == DialogResult.Yes)
                                treeUI_Form.beeTreeView.SelectedNode.Remove();
                            treeUI_Form.DeleteRecursive();
                            MapUI_Form.mySelectedMapNode.NodeSelected = false;
                            foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                if (customMapNode1.NodeSelected == true)
                                {
                                    customMapNode1.NodeSelected = false;
                                }
                                else
                                {
                                    customMapNode1.Dispose();
                                }
                            }
                        }
                        break;
                }                
            }
            else
            {
                switch (bt.Name)
                {
                    case "bttool1":
                        treeUI_Form.AddRoot();
                        customMapNode = new CustomMapNode(TreeUI_Form.mySelectedNode.Text, 0, 0);
                        customMapNode.ID = TreeUI_Form.mySelectedNode.Name;
                        if (TreeUI_Form.treeNodes.Count == 1)
                        {
                            customMapNode.Location = new Point(0, mapUI_Form.panelMap.Height / 2);
                        }
                        MapUI_Form.customMapNodes.Add(customMapNode);
                        MapUI_Form.mySelectedMapNode = customMapNode;
                        mapUI_Form.panelMap.Controls.Add(customMapNode);
                        foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                        {
                            customMapNode1.NodeSelected = false;
                            customMapNode1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        }
                        MapUI_Form.mySelectedMapNode.NodeSelected = true;

                        if (TreeUI_Form.mySelectedNode.Parent != null)
                        {
                            foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                if (customMapNode1.ID == TreeUI_Form.mySelectedNode.Parent.Name)
                                {
                                    customMapNode.Location = new Point(customMapNode1.Location.X + customMapNode1.Width + 50, customMapNode1.Location.Y);
                                    MapUI_Form.mySelectedMapNode.line(customMapNode1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line2);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line3);
                                }
                            }
                        }
                        treeUI_Form.beeTreeView_Click(sender, e);
                        break;
                    case "bttool2":
                        treeUI_Form.AddNode();
                        customMapNode = new CustomMapNode(TreeUI_Form.mySelectedNode.Text, 0, 0);
                        customMapNode.ID = TreeUI_Form.mySelectedNode.Name;
                        if (TreeUI_Form.treeNodes.Count == 1)
                        {
                            customMapNode.Location = new Point(0, mapUI_Form.panelMap.Height / 2);
                        }
                        MapUI_Form.customMapNodes.Add(customMapNode);
                        MapUI_Form.mySelectedMapNode = customMapNode;
                        mapUI_Form.panelMap.Controls.Add(customMapNode);
                        foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                        {
                            customMapNode1.NodeSelected = false;
                            customMapNode1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                        }
                        MapUI_Form.mySelectedMapNode.NodeSelected = true;

                        if (TreeUI_Form.mySelectedNode.Parent != null)
                        {
                            foreach (CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                if (customMapNode1.ID == TreeUI_Form.mySelectedNode.Parent.Name)
                                {
                                    customMapNode.Location = new Point(customMapNode1.Location.X + customMapNode1.Width + 50, customMapNode1.Location.Y);
                                    MapUI_Form.mySelectedMapNode.line(customMapNode1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line1);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line2);
                                    mapUI_Form.panelMap.Controls.Add(MapUI_Form.mySelectedMapNode.line3);
                                }
                            }
                        }
                        treeUI_Form.beeTreeView_Click(sender, e);
                        break;
                    case "btTool6":
                        if (IsExpand)
                        {
                            treeUI_Form.beeTreeView.CollapseAll();
                            IsExpand = false;
                        }
                        else
                        {
                            treeUI_Form.beeTreeView.ExpandAll();
                            IsExpand = true;
                        }
                        break;
                    case "btTool7":
                        if (treeUI_Form.beeTreeView.SelectedNode is null)
                            return;
                        else
                        {
                            MessageBoxUI_Form messageBox = new MessageBoxUI_Form();
                            messageBox.richTextBox1.Text = "Bạn muôn xóa " + treeUI_Form.beeTreeView.SelectedNode.Text + " ?";
                            messageBox.bt1.Visible = false;
                            messageBox.ShowDialog();
                            if (messageBox.DialogResult == DialogResult.Yes)
                                treeUI_Form.beeTreeView.SelectedNode.Remove();
                            treeUI_Form.DeleteRecursive();
                            MapUI_Form.mySelectedMapNode.NodeSelected = false;
                            foreach(CustomMapNode customMapNode1 in MapUI_Form.customMapNodes)
                            {
                                if (customMapNode1.NodeSelected == true)
                                {
                                    customMapNode1.NodeSelected = false;
                                }
                                else
                                {
                                    customMapNode1.Dispose();
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void userUI_SetButton1Clicked(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void pnTop_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void fileUI_SetButton3Clicked(object sender, EventArgs e)
        {
            IsEdit = false;
            if (treeUI_Form.fileName == "Untitled")
            {
                fileUI_SetButton4Clicked(sender, e);
            }
            else
            {
                treeUI_Form.SaveFile(treeUI_Form.fileName);
                SetFormTitle();
            }
        }

        private void fileUI_SetButton4Clicked(object sender, EventArgs e)
        {
            IsEdit = false;
            if (treeUI_Form.saveFile.ShowDialog() == DialogResult.OK)
            {
                treeUI_Form.fileName = treeUI_Form.saveFile.FileName;
                treeUI_Form.SaveFile(treeUI_Form.fileName);
                SetFormTitle();
            }
        }

        private void fileUI_SetButton2Clicked(object sender, EventArgs e)
        {
            IsEdit = true;
            if (treeUI_Form.beeTreeView.Visible == false)
            {
                treeUI_Form.beeTreeView.Visible = true;
            }

            if (treeUI_Form.openFile.ShowDialog() == DialogResult.OK)
            {
                treeUI_Form.fileName = treeUI_Form.openFile.FileName;
                try
                {
                    treeUI_Form.beeTreeView.Nodes.Clear();
                    treeUI_Form.OpenFile(treeUI_Form.fileName);
                    mapUI_Form.panelMap.Controls.Clear();
                    foreach(CustomMapNode customMapNode in MapUI_Form.customMapNodes)
                    {
                        mapUI_Form.panelMap.Controls.Add(customMapNode);
                        mapUI_Form.panelMap.Controls.Add(customMapNode.line1);
                        mapUI_Form.panelMap.Controls.Add(customMapNode.line2);
                        mapUI_Form.panelMap.Controls.Add(customMapNode.line3);
                    }
                    SetFormTitle();
                    treeUI_Form.beeTreeView.CollapseAll();
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message, "Bee Tree", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SetFormTitle();
            }
            
        }
        public void SetFormTitle()
        {
            FileInfo fileInfo = new FileInfo(treeUI_Form.fileName);
            this.NameWork.Text = fileInfo.Name + "...";
        }

        private void viewUI_SetButton2Clicked(object sender, EventArgs e)
        {
            if (mapUI_Form.pnTool.Width == 0)
            {
                this.btShowFunction_Click(sender, e);
            }
        }

        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            CanMove = true;
            X = e.X;
            Y = e.Y;
        }

        private void pnTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanMove)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void pnTop_MouseUp(object sender, MouseEventArgs e)
        {
            CanMove = false;
        }
        private void FindSeclectedMapNode_TreeNode()
        {
            foreach (CustomMapNode customMapNode in MapUI_Form.customMapNodes)
            {
                if (customMapNode.NodeSelected)
                {
                    MapUI_Form.mySelectedMapNode = customMapNode;
                    break;
                }
            }
            treeUI_Form.beeTreeView.SelectedNode = TreeUI_Form.mySelectedNode;
        }
    }
}
