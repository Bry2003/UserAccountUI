using UserAccountBusinessServices;
using System;

namespace UserAccountUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username: ");
           string Username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
              string Password = Console.ReadLine(); 

            UserAccountService userAccountService =new UserAccountService();
            bool result = userAccountService.VerifyUser(Username);

            if(result)
            {
                Console.WriteLine("Welcome to user Account UI");
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
