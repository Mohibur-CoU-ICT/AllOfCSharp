using System;
using System.Collections.Generic;

namespace AllOfCSharp
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<int> even = new HashSet<int>();
            HashSet<int> odd = new HashSet<int>();
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.Write("Even contains : ");
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Odd contains : ");
            foreach (int item in odd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
            // count to find size
            Console.WriteLine("Size of even = " + even.Count);
            Console.WriteLine("Size of odd = " + odd.Count);

            // search an item
            if (even.Contains(6))
            {
                Console.WriteLine("Even contains 6");
            }
            else
            {
                Console.WriteLine("Even doesn't contain 6");
            }
            
            if (odd.Contains(6))
            {
                Console.WriteLine("Odd contains 6");
            }
            else
            {
                Console.WriteLine("Odd doesn't contain 6");
            }

            // union
            even.UnionWith(odd);
            Console.Write("Even union Odd = ");
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // remove an element
            even.Remove(5);
            Console.WriteLine("After removing 5 from even");
            Console.Write("Even = ");
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // intersection
            even.IntersectWith(odd);
            Console.Write("Even intersection Odd = ");
            foreach (int item in even)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // clear a set i.e. remove all element from a set
            odd.Clear();
            Console.WriteLine("After odd.Clear(), Odd = ");
            foreach (int item in odd)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
