using System;
using System.IO;

namespace AllOfCSharp
{
    class StreamReaderDemo
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader
                using StreamReader sr = new StreamReader("E://C#//AllOfCSharp//AllOfCSharp//StreamReaderDemo.txt"); //format 1
                //StreamReader sr = new StreamReader("E://C#//AllOfCSharp//AllOfCSharp//StreamReaderDemo.txt"); // format 2
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                //sr.Close(); // needed for format 2
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
