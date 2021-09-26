using System;
using System.Linq;

namespace AllOfCSharp
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integer Array");
            int[] arr = new int[5];
            arr[0] = 5;
            arr[1] = 20;
            arr[2] = 25;
            arr[3] = 10;
            arr[4] = 15;
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Array.Reverse(arr);
            Console.Write("After reverse : ");
            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Array.Sort(arr);
            Console.Write("After sorting : ");
            foreach(int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Using some method of System.linq namespace");
            int mx = arr.Max();
            Console.WriteLine("Max element = " + mx);
            int mn = arr.Min();
            Console.WriteLine("Min element = " + mn);
            int sum = arr.Sum();
            Console.WriteLine("Sum of all element = " + sum);


            Array.Fill(arr, -1);
            Console.WriteLine("After fill by -1");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.WriteLine("After resizing to size 4");
            Array.Resize(ref arr, 4);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


            Console.WriteLine("\nString Array");
            string[] cars = { "Volvo", "VMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }
            Console.WriteLine();

            
            Console.ReadLine();
        }
    }
}
