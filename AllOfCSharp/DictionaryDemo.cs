using System;
using System.Collections.Generic;

namespace AllOfCSharp
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(12, "December");
            months.Add(11, "November");
            months.Add(10, "October");
            months.Add(9, "September");
            months.Add(8, "August");
            months.Add(7, "July");
            months.Add(6, "June");
            months.Add(5, "May");
            months.Add(4, "April");
            months.Add(3, "March");
            months.Add(2, "February");
            months.Add(1, "January");

            Console.WriteLine("Month size = " + months.Count);

            foreach (KeyValuePair<int, string> kvp in months)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            // search key
            if (months.ContainsKey(5))
            {
                Console.WriteLine("Key 5 is present in the dictionary");
            }
            else
            {
                Console.WriteLine("Key 5 is not present in the dictionary");
            }

            // remove key
            months.Remove(12);
            // remove november and store it to string s
            months.Remove(11, out string s);
            Console.WriteLine("Value " + s + " is removed.");
            Console.WriteLine("After removing 2 elements size = " + months.Count);

            // search value
            if (months.ContainsValue("December"))
            {
                Console.WriteLine("Value December is present in the dictionary");
            }
            else
            {
                Console.WriteLine("Value December is not present in the dictionary");
            }
            
            Console.WriteLine("after removing some values months dictionary:");
            foreach (KeyValuePair<int,string> kvp in months)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            months.Clear();
            Console.WriteLine("After clear months size = " + months.Count);
        }
    }
}
