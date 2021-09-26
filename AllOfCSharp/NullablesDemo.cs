using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class NullablesDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NullablesDemo");
            int? num1 = null;
            int num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolVal = new bool?();

            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);
            Console.WriteLine("num3 = " + num3);
            Console.WriteLine("num4 = " + num4);
            Console.WriteLine("num4 = " + boolVal);

            //The Null Coalescing Operator(??)
            double num5;
            num5 = num3 ?? 5.34;
            Console.WriteLine("num5 = " + num5);
            num5 = num4 ?? 5.34;
            Console.WriteLine("num5 = " + num5);
        }
    }
}
