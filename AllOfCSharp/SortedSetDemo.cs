using System;
using System.Collections.Generic;
using System.Linq;

namespace AllOfCSharp
{
    class SortedSetDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortedSet Demo");
            SortedSet<int> nums = new SortedSet<int>();
            nums.Add(20);
            nums.Add(50);
            nums.Add(10);
            nums.Add(30);
            nums.Add(30);
            nums.Add(40);

            Console.WriteLine("Size of nums = " + nums.Count);
            foreach (var item in nums)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // remove
            if (nums.Remove(30))
            {
                Console.WriteLine("30 removes successfully.");
            }
            else
            {
                Console.WriteLine("30 couldn't be removed");
            }
            if (nums.Remove(30))
            {
                Console.WriteLine("30 removes successfully.");
            }
            else
            {
                Console.WriteLine("30 couldn't be removed");
            }

            // search
            if (nums.Contains(40))
            {
                Console.WriteLine("40 present in nums.");
            }
            else
            {
                Console.WriteLine("40 is not present in nums.");
            }

            Console.WriteLine("Maximum number in nums = " + nums.Max());
            Console.WriteLine("Minimum number in nums = " + nums.Min());
            Console.WriteLine("Sum of nums = " + nums.Sum());

            nums.Clear();
            Console.WriteLine("After nums.Clear() nums size = " + nums.Count);

            Console.ReadLine();
        }
    }
}
