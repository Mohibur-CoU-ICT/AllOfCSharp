using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class JaggedArrayDemo
    {
        static void Main(string[] args)
        {
            //In C#, jagged array is also known as "array of arrays" because its elements are arrays.
            //The element size of jagged array can be different.

            Console.WriteLine("Jagged Array Demo");

            // initialization of array method 1
            int[][] arr = new int[2][];
            arr[0] = new int[] { 5, 10 };
            arr[1] = new int[] { 3, 6, 9 };

            // traverse array elements
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=0; j<arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // initialization of array method 2
            int[][] arr2 = new int[3][]
            {
                new int[] {3, 6},
                new int[] {4, 8, 12},
                new int[] {5, 10, 15, 20}
            };

            // traverse 
            for(int i=0; i<arr2.Length; i++)
            {
                for(int j=0; j<arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
