using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg
{
   public class Administrator :  Account
    {
        public string Phone { get; }
        public Administrator(string Login, string Password, string Phone) : base(Login, Password)
        {
            this.Phone = Phone;
        }
    }
}
