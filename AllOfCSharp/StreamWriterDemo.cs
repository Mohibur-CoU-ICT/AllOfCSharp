using System;
using System.IO;

namespace AllOfCSharp
{
    class StreamWriterDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write exit to stop.");
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader
                using (StreamWriter sw = new StreamWriter("E://C#//AllOfCSharp//AllOfCSharp//StreamWriterDemo.txt"))
                {
                    string s;
                    while ((s = Console.ReadLine()) != "exit")
                    {
                        sw.WriteLine(s);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
