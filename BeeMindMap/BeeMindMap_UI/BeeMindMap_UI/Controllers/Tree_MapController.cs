using BeeMindMap_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace BeeMindMap_UI.Controllers
{
    public static class Tree_MapController
    {
        public static TreeNode ConvertCustomTreeNode_TreeNode(CustomTreeNode customTreeNode)
        {
            TreeNode treeNode = new TreeNode();
            treeNode = (TreeNode)customTreeNode;
            treeNode.Name = Tree_MapController.ConvertCustomMapNode_string(customTreeNode.customMapNode);
            return treeNode;
        }
        public static string ConvertCustomMapNode_string(CustomMapNode customMapNode)
        {
            string a = "";
            //Code cộng chuỗi của Nguyễn Thành Long
            return a;
        }
        public static TreeNode ConvertCustomTreeView_TreeView(TreeView treeView)
        {
            //Đổi từ CustomTreeView thành TreeView để lưu;
            CustomTreeNode customTreeNode = new CustomTreeNode();
            TreeNode treeNode = new TreeNode();
            foreach (CustomTreeNode ctn in treeView.Nodes)
            {
                customTreeNode.Nodes.Add((CustomTreeNode)ctn.Clone());
                treeNode.Nodes.Add((TreeNode)ConvertCustomTreeNode_TreeNode(ctn).Clone());
            }
            treeNode = getTreeNode_TreeNode(customTreeNode);
            return treeNode;
        }
        public static TreeNode getTreeNode_TreeNode(CustomTreeNode customTreeNode)
        {
            TreeNode tn = ConvertCustomTreeNode_TreeNode(customTreeNode);
            foreach (CustomTreeNode customChildNode in customTreeNode.Nodes)
            {
                tn.Nodes.Add(getTreeNode_TreeNode(customChildNode));
            }
            return tn;
        }
    }
}
