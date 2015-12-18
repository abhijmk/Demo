using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Password { get; set; }

        public bool CheckLogin()
        {
            if (UserId == "Abh" && Password == "Abhi")
            {
                return true;
            }

          return false;
        }
    }
}