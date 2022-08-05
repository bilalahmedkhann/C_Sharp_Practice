using System;

namespace cdssdc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rand = new Random();
            double x = rand.NextDouble();
            Console.WriteLine(x);
        }
    }
}
