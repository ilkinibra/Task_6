using System;
using System.Collections.Generic;
using System.Text;

namespace Task_6.Models
{
    class Admin : User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }
        public Admin(bool isSuperAdmin, string username, string password, string section):base(username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }

        public Admin()
        {

        }

        public void ShowInfo()
        {
            Console.WriteLine($"Username:{Username}\nPassword:{Password}\nIsSuperAdmin:{IsSuperAdmin}\nSection:{Section}");
        }
    }
}