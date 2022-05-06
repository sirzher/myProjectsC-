using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reg
{
    public static class AccountsList
    {
        public static List<User> users = new List<User>()
            {
                new User("johnSmith@ml.ru", "Qwerty", true),
                new User("Vanya123@ml.ru", "F345Hj23K", false),
                new User("Liza6788@dml.com", "Liza6788", false)
            };
        public static List<Administrator> admins = new List<Administrator>()
            {
                new Administrator("Admin", "admin", "81234567890"),
                new Administrator("Master", "Jnk2J2", "80987654321")
            };
        
    }
}
