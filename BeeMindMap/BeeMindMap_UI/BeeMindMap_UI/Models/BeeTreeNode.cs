using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeMindMap_UI.Models
{
    [Serializable]
    [Table("Nodes")]
    public class BeeTreeNode
    {
        string name = String.Empty;
        string text = String.Empty;
        List<BeeTreeNode> listNode = new List<BeeTreeNode>();

        //properties
        [Key]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public List<BeeTreeNode> ListNode
        {
            get { return listNode; }
            set { listNode = value; }
        }
        public BeeTreeNode Parent { get; set; }
        public List<Map> maps { get; set; }
        public BeeTreeNode()
        {

        }
    }
}
