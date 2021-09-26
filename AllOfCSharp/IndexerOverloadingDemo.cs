using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class IndexerOverloadingDemo
    {
        private string[] names = new string[size];
        public static int size = 10;

        public IndexerOverloadingDemo()
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
                if (index >= 0 && index < size)
                {
                    names[index] = value;
                }
            }
        }

        // overloading indexer
        public int this[string name]
        {
            get
            {
                int index = 0;
                while(index < size)
                {
                    if (names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }

        static void Main(string[] args)
        {
            IndexerOverloadingDemo names = new IndexerOverloadingDemo();
            names[1] = "IndexerOverloading";
            names[2] = "IndexerOverloading";
            names[3] = "IndexerOverloading";
            names[4] = "IndexerOverloading";
            names[5] = "IndexerOverloading";
            names[6] = "IndexerOverloading";
            names[7] = "IndexerOverloading";

            // using the first indexer with int parameter
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(names[i]);
            }

            // using the second indexer with the string parameter
            Console.WriteLine(names["Mohibur"]);
            Console.WriteLine(names["Moshiur"]);
            Console.ReadLine();
        }
    }
}
