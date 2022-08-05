using System;

namespace ClassWork2
{
    internal class Program
    {
        int value = 5;
        Program.PassByValue(value);
            Console.WriteLine(value);
            Program.PassByRef(ref value);
            Console.WriteLine("After ref operatiom "+value);
        static void Main(string[] args)
        {
            args = args + 10;
            Console.WriteLine("Method output"+a);
        }
        static void PassByRef(ref int b)
    }
}
