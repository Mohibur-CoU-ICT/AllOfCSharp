using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<string> stk3 = new Stack<string>(); // generic
            Stack stk = new Stack(); // collection
            // adding item
            stk.Push("One");
            stk.Push("Two");
            stk.Push("Three");
            stk.Push("Four");
            stk.Push("Five");

            // size and top
            Console.WriteLine("Size of stack = {0}\n", stk.Count);
            Console.WriteLine("Top of stack = {0}\n", stk.Peek());

            // traverse stk
            Console.WriteLine("Stack contains:");
            foreach (string item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // copy
            Stack stk2 = (Stack)stk.Clone();

            // search
            if (stk2.Contains("Six"))
            {
                Console.WriteLine("Six ia already present in stk2.\n");
            }
            else
            {
                stk2.Push("Six");
                Console.WriteLine("Six is added in stk2.\n");
            }

            // traverse stk2
            Console.WriteLine("stk2 contains:");
            while (stk2.Count > 0)
            {
                Console.WriteLine(stk2.Pop());
            }
            Console.WriteLine();
            Console.WriteLine("Now size of stk2 = {0}.\n", stk2.Count);

            // to string
            string s = stk2.ToString();
            Console.WriteLine("string representation of stk2 = " + s);

            // to array
            object[] arr = stk.ToArray();
            Console.WriteLine("Array representation of stk:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((string)arr[i]);
            }

            // delete -> pop, clear
            if (stk.Count > 0)
            {
                string top = (string)stk.Pop();
                Console.WriteLine("{0} is deleted.\n", top);
            }
            stk.Clear();
            Console.WriteLine("After clear() size = {0}.\n", stk.Count);
        }
    }
}
