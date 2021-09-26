using System;
using System.Collections.Generic;
using System.Text;

namespace AllOfCSharp
{
    class EnumDemo
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EnumDemo (enum keyword)\n");
            Console.Write("Enter month no (1-12) : ");
            
            int month = Convert.ToInt32(Console.ReadLine()) - 1;

            switch (month)
            {
                case 0:
                    Console.WriteLine("January");
                    break;
                case 1:
                    Console.WriteLine("February");
                    break;
                case 2:
                    Console.WriteLine("March");
                    break;
                case 3:
                    Console.WriteLine("April");
                    break;
                case 4:
                    Console.WriteLine("May");
                    break;
                case 5:
                    Console.WriteLine("June");
                    break;
                case 6:
                    Console.WriteLine("July");
                    break;
                case 7:
                    Console.WriteLine("August");
                    break;
                case 8:
                    Console.WriteLine("September");
                    break;
                case 9:
                    Console.WriteLine("October");
                    break;
                case 10:
                    Console.WriteLine("November");
                    break;
                case 11:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("You must enter a value between 1 and 12.");
                    break;
            }
        }
    }
}
