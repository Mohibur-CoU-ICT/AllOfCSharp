using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class HashtableDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable Demo\n");
            Hashtable ht = new Hashtable();
            // insert
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add("Bangladesh", "Dhaka");
            ht.Add("Mohibur", 11609027);

            Console.WriteLine("Size of hashtable = " + ht.Count);

            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }

            // update
            ht["Mohibur"] = "11609027";
            
            // search key
            if (ht.ContainsKey("Bangladesh"))
            {
                Console.WriteLine("\nBangladesh is present in hashtable.\n");
            }
            else
            {
                Console.WriteLine("\nBangladesh isn't present in hashtable.\n");
            }
            
            // search value
            if (!ht.ContainsValue("Apple"))
            {
                ht.Add("Fruit", "Apple");
                Console.WriteLine("{Fruit, Apple} is inserted.\n");
            }
            else
            {
                Console.WriteLine("Apple is already present as a value.\n");
            }

            // remove
            // check key before removing it
            if (ht.ContainsKey(30))
            {
                ht.Remove(30);
            }
            else
            {
                Console.WriteLine("30 is not present in hashtable.\n");
            }

            ICollection keys = ht.Keys;
            foreach(var k in keys)
            {
                Console.WriteLine(k + " " + ht[k]);
            }

            ht.Clear();
            Console.WriteLine("\nAfter ht.Clear() size = " + ht.Count);

            Console.ReadLine();
        }
    }
}
