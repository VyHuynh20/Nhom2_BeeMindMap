using BeeMindMap_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeMindMap_UI.Controllers
{
    public class UserControllers
    {
        public UserControllers()
        {

        }
        static public User Find(string username)
        {
            using(var _context = new Context())
            {
                if (_context.users.Count() == 0) return null;
                var users = (from u in _context.users
                         where u.UserName == username
                         select u).ToList();
                if (users.Count == 0) return null;
                else return users[0];
            }
        }
        static public bool Add(User user)
        {
            if (Find(user.UserName) == null)
            {
                using (var _context = new Context())
                {
                    _context.users.Add(user);
                    _context.SaveChanges();
                }
                return true;
            }
            else return false;
        }

    }
}
