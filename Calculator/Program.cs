using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Write a calculator by takin 2 input from user

            Console.WriteLine("Enter any two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int add = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            int div = num1 / num2;
            int mod = num1 % num2;




            Console.WriteLine("Enter  a for addition, b for subtraction, c for multiplication, d for division, e for modulus");
            char calc = Convert.ToChar(Console.ReadLine());
            if (calc == 'a')
            {
                Console.WriteLine(add);
            }
            else if (calc == 'b')
            {
                Console.WriteLine(sub);
            }
            else if (calc == 'c')
            {
                Console.WriteLine(mult);
            }
            else if (calc == 'd')
            {
                Console.WriteLine(div);
            }
            else if (calc == 'e')
            {
                Console.WriteLine(mod);
            }
            else { Console.WriteLine("Invalid Input"); }


        }
    }
}
