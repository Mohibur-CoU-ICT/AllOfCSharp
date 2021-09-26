using System;
using System.Collections;
using System.Text;

namespace AllOfCSharp
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(11609027, "Mohibur Rahman");
            sl.Add(11609028, "Mojahidul Islam");
            sl.Add(11609029, "Mizanur Rahman");
            sl.Add(11609030, "Moshiur Rahman");
            sl.Add(11609031, "Iqbal Hossain");
            sl.Add(11609032, "Mazhar Mamun");

            Console.WriteLine("Size = {0}\n", sl.Count);

            // printing sorted list
            ICollection keys = sl.Keys;
            foreach(int id in keys)
            {
                Console.WriteLine(id + " " + sl[id]);
            }
            Console.WriteLine();

            // search key
            if (sl.ContainsKey(11609033))
            {
                Console.WriteLine("Id 11609033 is already present.");
            }
            else
            {
                sl.Add(11609033, "Fahim Miah");
                Console.WriteLine("Fahim Miah with id 11609033 is added");
            }
            // search value
            if (sl.ContainsValue("Kamrul Hasan"))
            {
                Console.WriteLine("Kamrul Hasan is already present.");
            }
            else
            {
                sl.Add(11609034, "Kamrul Hasan");
                Console.WriteLine("Kamrul Hasan with id 11609034 is added.");
            }

            Console.WriteLine("key of 4th element = {0}", sl.GetKey(4));
            Console.WriteLine("value of 4th element = {0}", sl.GetByIndex(4));
            Console.WriteLine("Index of key 11609034 = {0}", sl.IndexOfKey(11609034));
            Console.WriteLine("Index of value Kamrul Hasan = {0}\n", sl.IndexOfValue("Kamrul Hasan"));

            // remove
            sl.Remove(11609033);
            sl.RemoveAt(4);
            Console.WriteLine("After removing two element:");
            IList _key = sl.GetKeyList();
            foreach (int k in _key)
            {
                Console.WriteLine(k + " " + sl[k]);
            }

            sl.Clear();
            Console.WriteLine("After clear() size = {0}", sl.Count);
        }
    }
}
