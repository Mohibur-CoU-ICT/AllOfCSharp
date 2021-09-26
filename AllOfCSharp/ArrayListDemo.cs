using System;
using System.Collections;
using System.Text;

namespace AllOfCSharp
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayListDemo");
            ArrayList al = new ArrayList();
            
            // add
            al.Add(10);
            al.Add(true);
            al.Add(30.89);
            al.Add("Mohibur");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nCount = " + al.Count);
            Console.WriteLine("\nCapacity = " + al.Capacity);
            try
            {
                al.Sort();
                Console.Write("\nAfter sorting : ");
                foreach (var item in al)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // insert
            al.Insert(3, 40);
            Console.Write("\nAfter insert 40 at position 3 : ");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // remove
            al.Remove("Mohibur");
            al.RemoveAt(2);
            Console.Write("\nAfter removing \"Mohibur\" and second value : ");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // reverse
            al.Reverse();
            Console.Write("\nAfter reverse : ");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // clear
            al.Clear();
            Console.WriteLine("\nAfter clear() Size = " + al.Count);
        }
    }
}
