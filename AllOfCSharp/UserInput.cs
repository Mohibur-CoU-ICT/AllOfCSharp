using System;

namespace AllOfCSharp
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello, " + name);

            
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are a kid of " + age + " years old.");
            }
            else if (age < 50)
            {
                Console.WriteLine("You are a young man of " + age + " years old.");
            }
            else
            {
                Console.WriteLine("You are an old man of " + age + " years old.");
            }


            Console.Write("Enter your sex (M/F) : ");
            char sex = Convert.ToChar(Console.ReadLine());
            if (sex == 'm' || sex == 'M')
            {
                Console.WriteLine("You are a male.");
            }
            else if (sex == 'f' || sex == 'F')
            {
                Console.WriteLine("You are a female.");
            }
            else
            {
                Console.WriteLine("You entered an invalid sex character.");
            }


            Console.Write("Enter your salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your salary is = " + salary);
            
            Console.Write("Enter your salary increment : ");
            decimal salaryIncrement = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your salary increment rate is = " + salaryIncrement);
            
            Console.ReadLine();
        }
    }
}
