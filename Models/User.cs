using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_6.Models
{
    class User
    {
        private static string _username;
        private static string _password;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username
        {
            get { return _username; }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }
        public User()
        {

        }

        public static bool PasswordChecker(string word)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            if (!string.IsNullOrEmpty(word))
            {
                foreach (var item in word)
                {
                    if (char.IsDigit(item))
                        HasDigit = true;

                   else if (char.IsUpper(item))
                        HasUpper = true;

                    if (HasDigit && HasUpper)
                        return true;
                }
            }
            return false;            
        }
    }
}









      


      