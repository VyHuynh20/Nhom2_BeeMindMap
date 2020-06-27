using BeeMindMap_UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI.Models
{
    public class BeeTreeNodeOperations
    {
        public static BeeTreeNode prepareToWrite(TreeView tree)
        {
            TreeNode treeNode = new TreeNode();
            foreach (TreeNode tn in tree.Nodes)
            {
                treeNode.Nodes.Add((TreeNode)tn.Clone());
            }
            BeeTreeNode final = prepareTreeNode(treeNode, null);
            return final;
        }

        //Functions for writing
        private static BeeTreeNode prepareTreeNode(TreeNode treeNode, BeeTreeNode parentnode)
        {
            BeeTreeNode btn = new BeeTreeNode();
            btn.Name = treeNode.Text.ToString();
            btn.Text = treeNode.Text.ToString();
            btn.Parent = parentnode;
            btn.ListNode = prepareChildNode(treeNode, btn);
            return btn;
        }

        private static List<BeeTreeNode> prepareChildNode(TreeNode treeNode, BeeTreeNode parentnode)
        {
            List<BeeTreeNode> reTreeNode = new List<BeeTreeNode>();
            BeeTreeNode btn;
            foreach(TreeNode tn in treeNode.Nodes)
            {
                btn = prepareTreeNode(tn, parentnode);
                reTreeNode.Add(btn);
            }
            return reTreeNode;
        }

        public static TreeNode prepareToRead(BeeTreeNode beeTreeNode)
        {
            try
            {
                TreeNode final = prepareTreeNodeRead(beeTreeNode);
                return final;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //functions for reading
        private static TreeNode prepareTreeNodeRead(BeeTreeNode beeTreeNode)
        {
            TreeNode treeNode = new TreeNode();
            treeNode.Name = beeTreeNode.Name;
            treeNode.Text = beeTreeNode.Text;
            //build node collection
            List<TreeNode> tempList = prepareChildNodeRead(beeTreeNode);
            foreach(TreeNode temp in tempList)
            {                
                treeNode.Nodes.Add(temp);
            }

            return treeNode;
        }
        private static List<TreeNode> prepareChildNodeRead(BeeTreeNode beeTreeNode)
        {
            List<TreeNode> reTreeNode = new List<TreeNode>();
            TreeNode tn;
            foreach(BeeTreeNode btn in beeTreeNode.ListNode)
            {
                tn = prepareTreeNodeRead(btn);
                reTreeNode.Add(tn);
            }
            return reTreeNode;
        }
    }
}
