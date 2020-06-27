using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeMindMap_UI.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Phone { get; set; }
        public User()
        {
        }
        public bool CheckPass(string password)
        {
            if (this.PassWord == password) return true;
            else return false;
        }
    }
}
