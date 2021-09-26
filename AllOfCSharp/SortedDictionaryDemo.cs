using System;
using System.Collections.Generic;

namespace AllOfCSharp
{
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortedDictionary Demo");
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(11609029, "Mizanur Rahman");
            sd.Add(11609026, "Sabbir Rahman");
            sd.Add(11609027, "Mohibur Rahman");
            sd.Add(11609021, "Mirazur Rahman");
            sd.Add(11609023, "Sohanur Rahman");
            Console.WriteLine("Size = " + sd.Count);

            foreach (KeyValuePair<int, string> kvp in sd)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            // search key
            if (sd.ContainsKey(11609027))
            {
                Console.WriteLine("Name of id=11609027 is" + sd[11609027]);
            }
            else
            {
                Console.WriteLine("Id = 11609027 is not present.");
            }

            // search value
            if (sd.ContainsValue("Kamrul Hasan"))
            {
                Console.WriteLine("Kamrul Hasan is already present in the dictionary.");
            }
            else
            {
                sd.Add(11609031, "Kamrul Hasan");
                Console.WriteLine("Kamrul Hasan is added in the dictionary.");
            }

            // remove
            if (sd.ContainsKey(11609021))
            {
                Console.WriteLine("Student with id = 11609021 is removed.");
            }
            else
            {
                Console.WriteLine("Student with id = 11609021 is not present.");
            }

            Console.WriteLine("\nNow dictionary looks like");
            foreach (KeyValuePair<int, string> kvp in sd)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            sd.Clear();
            Console.WriteLine("\nSize after sd.Clear() = " + sd.Count);
        }
    }
}
