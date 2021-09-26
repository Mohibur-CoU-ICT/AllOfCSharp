using System;

namespace AllOfCSharp
{
    class MathDemo
    {
        static void Main(string[] args)
        {
            int mx = Math.Max(10, 20);
            Console.WriteLine("Max = " + mx);

            int mn = Math.Min(10, 20);
            Console.WriteLine("Max = " + mn);

            double sqr = Math.Sqrt(65);
            Console.WriteLine("Square root = " + sqr);

            double abs = Math.Abs(-5.5);
            Console.WriteLine("Absolute value = " + abs);

            int round = (int)Math.Round(6.9);
            Console.WriteLine("Round = " + round);
        }
    }
}
