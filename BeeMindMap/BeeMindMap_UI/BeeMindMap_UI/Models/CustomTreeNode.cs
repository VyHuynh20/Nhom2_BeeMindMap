using BeeMindMap_UI.Views;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace BeeMindMap_UI.Models
{
    public class CustomTreeNode : TreeNode
    {
        public CustomMapNode customMapNode { get; set; }
        public CustomTreeNode() : base()
        {

        }
        public static void SaveTree(System.Windows.Forms.TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, tree.Nodes.Cast<TreeNode>().ToList());
            }
        }

        public static void LoadTree(System.Windows.Forms.TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }
    
    }
}
