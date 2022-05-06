using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg
{
   public  class Account
    {
        public string Login { get;  }
        public string Password { get; }
        public Account(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
        public Account()
        {

        }
    }
}
