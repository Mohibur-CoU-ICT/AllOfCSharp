using System;

namespace AllOfCSharp
{
    class LoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loop");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(10 + " x " + i + " = " + 10 * i);
            }

            Console.WriteLine("\nwhile lopp");
            int num = 2;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num += 2;
            }

            Console.WriteLine("\ndo-while loop");
            num = 1;
            do
            {
                Console.WriteLine(num);
                num += 2;
            } while (num < 10);

            Console.ReadLine();
        }
    }
}
