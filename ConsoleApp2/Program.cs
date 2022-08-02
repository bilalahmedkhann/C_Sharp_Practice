using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 56;
            int b = 8;
            int c = a + b;
            int d = a - b;
            Console.WriteLine(a + b + c + d);
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello "+name+", How are you? and your age is "+ age);

         }
    }
}
