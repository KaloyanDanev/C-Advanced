using System;
using System.IO;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        public static object UserInterface { get; private set; }

        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../streams/text.txt"))
            {
                string line;
                int n = 1;
                using (var writer = new StreamWriter("../Problem 2. Line Numbers/output.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                        writer.WriteLine("Line {0}: {1}", n++, line);
                }
            }
        }
    }
}