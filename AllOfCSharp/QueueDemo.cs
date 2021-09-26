using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class QueueDemo
    {
        static void Main(string[] args)
        {
            // collection
            Queue qu = new Queue();
            // adding item
            qu.Enqueue("First");
            qu.Enqueue("Second");
            qu.Enqueue("Third");
            qu.Enqueue("Forth");
            qu.Enqueue("Fifth");

            Console.WriteLine("size of qu = " + qu.Count);
            Console.WriteLine("Front of qu = " + qu.Peek());

            // removing item
            Console.WriteLine("\nPrinting and removing items from qu");
            while(qu.Count > 0)
            {
                Console.WriteLine(qu.Dequeue());
            }


            // generic
            Queue<int> qu2 = new Queue<int>();
            qu2.Enqueue(10);
            qu2.Enqueue(20);
            qu2.Enqueue(30);
            qu2.Enqueue(40);
            qu2.Enqueue(50);

            // search
            if (qu2.Contains(60))
            {
                Console.WriteLine("60 is already present in qu2");
            }
            else
            {
                qu2.Enqueue(60);
                Console.WriteLine("60 is added to qu2.");
            }

            Console.WriteLine("\nGeneric qu2 cotains:");
            foreach (var item in qu2)
            {
                Console.WriteLine(item);
            }

            // removing all items
            qu2.Clear();
            Console.WriteLine("After clear size of qu2 = {0}.\n", qu2.Count);
        }
    }
}
