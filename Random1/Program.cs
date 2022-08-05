using System;

namespace Random1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            Console.WriteLine(empCheck);
            if(empCheck == 1)
            {
                Console.WriteLine("Employee is present");

            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

        }
    }
}
