using System;
using System.Collections.Generic;

namespace AllOfCSharp
{
    class TryCatchDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryCatch Demo");

            int[] arr = { 5, 10, 15, 20 };
            try
            {
                Console.WriteLine(arr[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This statement execute whether an exception occur or not.");
            }
            Console.ReadLine();
        }
    }
}
