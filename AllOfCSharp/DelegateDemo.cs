using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    delegate int NumberChanger(int n);

    class DelegateDemo
    {
        static int num = 0;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int p)
        {
            num *= p;
            return num;
        }

        public static int GetNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultiplyNum);
            nc1(25);
            Console.WriteLine("Value of num = {0}", GetNum());
            nc2(5);
            Console.WriteLine("Value of num = {0}", GetNum());
            Console.ReadLine();
        }
    }
}
