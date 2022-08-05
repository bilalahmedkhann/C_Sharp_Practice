// Check employee daily wage if present, half time or absent using Switch:


using System;

namespace UC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random rand = new Random();
            int num = rand.Next(0, 3);
            Console.WriteLine(num);

            switch (num)
            {
                case 0: Console.WriteLine("Employee is absent and his daily wage is 0.");
                    break;
                case 1:
                    Console.WriteLine("Employee is present and his daily wage is " + (20 * 8) + ".");
                    break;
                case 2:
                    Console.WriteLine("Employee is present part time and his daily wage is " + (20 * 4) + ".");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}
