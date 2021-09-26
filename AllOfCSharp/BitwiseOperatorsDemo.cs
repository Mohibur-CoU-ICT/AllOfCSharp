using System;

namespace AllOfCSharp
{
    class BitwiseOperatorsDemo
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 13;
            Console.WriteLine("a = " + Convert.ToString(a, 2));
            Console.WriteLine("b = " + Convert.ToString(b, 2));
            Console.WriteLine("a = " + a + ", b = " + b);
            Console.WriteLine("a & b = " + (a & b));
            Console.WriteLine("a | b = " + (a | b));
            Console.WriteLine("a ^ b = " + (a ^ b));
            Console.WriteLine("~a = " + (~a));
            Console.WriteLine("a << 1 = " + (a << 1));
            Console.WriteLine("a >> 1 = " + (a >> 1));
            Console.ReadLine();
        }
    }
}
