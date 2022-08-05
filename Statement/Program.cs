using System;

namespace Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your user name");
            string userName=Console.ReadLine();

            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (userName == "Bilal" && password == "Bridgelabz")
            {
                Console.WriteLine("Your password is correct, Here are the details");
               
            }
            else
            {
                Console.WriteLine("Invalid Input, please try again");
            }
        }
    }
}
