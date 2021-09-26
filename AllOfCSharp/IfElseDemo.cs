using System;

namespace AllOfCSharp
{
    class IfElseDemo
    {
        static void Main(string[] args)
        {
            int x = 10;
            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadLine();
        }
    }
}
