using System;

namespace ClassWorkNestedLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("***Hello***");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("    Hey    ");
                }
                Console.WriteLine();

            }
        }
    }
}
