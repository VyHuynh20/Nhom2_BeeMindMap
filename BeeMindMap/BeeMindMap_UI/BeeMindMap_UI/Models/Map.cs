using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeeMindMap_UI.Models
{
    [Table("Maps")]
    public class Map
    {
        public string id;
        [Key]
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Name { get; set; }
        public List<BeeTreeNode> beeTreeNodes { get; set; }
        public ICollection<User> users { get; set; }
    }
}
