using System;

namespace AllOfCSharp
{
    class ThrowDemo
    {
        static void Main(string[] args)
        {
            try
            {
                CheckAge(15);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                CheckAge(25);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("You are old enough to access this site.");
            }
        }
    }
}
