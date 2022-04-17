using System;
using Task_6.Models;

namespace Task_6
{

    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string section;
            string password;
            Admin admin = new Admin();

            Console.WriteLine("IsSuperAdmin");
            bool isSuperAdmin = Convert.ToBoolean(Console.ReadLine());
            if (isSuperAdmin == true)
            {


                do
                {
                    Console.WriteLine("Username daxil edin");
                    username = Console.ReadLine();

                } while (username.Length < 6);
                admin.Username = username;
                do
                {
                    Console.WriteLine("Password daxil edin");
                    password = Console.ReadLine();
                } while (!PasswordChecker(password));
                admin.Password=password;

                Console.WriteLine("Section daxil edin");
                section = Console.ReadLine();
                admin.Section = section;


            }
            else
            {
                Console.WriteLine("Admin deyilsen");
            }
            admin.ShowInfo();
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


                    if (char.IsUpper(item))
                        HasUpper = true;

                    if (HasDigit && HasUpper)
                        return true;

                }
            }
            return false;

        }

    }
}