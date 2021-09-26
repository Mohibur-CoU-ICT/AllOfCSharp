using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class IndexerDemo
    {
        private string[] names = new string[size];
        public static int size = 10;

        public IndexerDemo()
        {
            for (int i = 0; i < size; i++)
            {
                names[i] = "Mohibur";
            }
        }

        // defining an indexer
        public string this[int index]
        {
            get
            {
                string ans = "";
                if (index >= 0 && index < size)
                {
                    ans = names[index];
                }
                return ans;
            }
            set
            {
                if(index >= 0 && index < size)
                {
                    names[index] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            IndexerDemo names = new IndexerDemo();
            names[1] = "Moshiur";
            names[2] = "Mojahid";
            names[3] = "Mamum";
            names[4] = "Masum";
            names[5] = "Mahfuz";
            names[6] = "Masuk";
            names[7] = "Mabin";

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
