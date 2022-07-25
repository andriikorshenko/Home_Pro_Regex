using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_006
{
    internal class Reger
    {
        private string _loginPattern = @"[a-zA-Z]{8,31}";
        private string _passwordPattern = @"[a-zA-Z0-9]{8,31}";
        private Regex? _regex;

        public string EnterLogin()
        {
            do
            {
                Console.Write("Enter your login " +
                    "(letters only, any case) : ");
                string? login = Console.ReadLine();

                _regex = new Regex(_loginPattern);

                if (Regex.IsMatch(login, _loginPattern, RegexOptions.IgnoreCase))
                {
                    return login;
                }
                else Console.WriteLine("Wrong characters or size. Try againe!");
            } while (true);            
        }

        public string EnterPassword()
        {
            do
            {
                Console.Write("Enter your password " +
                    "(letters and numbers only, any case) : ");
                string? password = Console.ReadLine();

                _regex = new Regex(_passwordPattern);

                if (Regex.IsMatch(password, _passwordPattern, RegexOptions.IgnoreCase))
                {
                    return password;
                }
                else Console.WriteLine("Wrong characters or size. Try againe!");
            } while (true);
        }

        public void Registration(string login, string password)
        {
            Console.WriteLine("\nYou have been registered successfully!\n");
            Console.WriteLine($"Your login : {login}");
            Console.WriteLine($"Your password : {password}");
        }
    }
}
