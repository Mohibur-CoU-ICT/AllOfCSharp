using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    delegate int NumberChanger2(int n);

    class DelegateMulticastingDemo
    {
        static int num = 10;

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
            NumberChanger2 nc;
            NumberChanger2 nc1 = new NumberChanger2(AddNum);
            NumberChanger2 nc2 = new NumberChanger2(MultiplyNum);
            nc = nc1;
            nc += nc2;
            nc(20);
            Console.WriteLine("Value of num = {0}", GetNum());
            Console.ReadLine();
        }
    }
}
