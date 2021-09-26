using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class MultidimensionalArrayDemo
    {
        static void Main(string[] args)
        {
            // There are 3 ways to initialize multidimensional array in C# while declaration.
            int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = new int[,] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int[,] arr3 = { { 5, 10, 15 }, { 6, 12, 18 }, { 7, 14, 21 } };

            PrintArray(arr1, 3, 3);
            PrintArray(arr2, 3, 3);
            PrintArray(arr3, 3, 3);
        }

        static void PrintArray(int[,] arr, int r, int c)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
