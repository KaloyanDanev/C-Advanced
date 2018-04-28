using System;
using System.IO;
using System.Text;

namespace Problem_1._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "../streams/text.txt";
            var resultedOddLines = new StringBuilder();

            using (var reader = new StreamReader(file))
            {
                var lineNumber = 0;
                var line = reader.ReadLine();

                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        resultedOddLines.Append($"{line}{Environment.NewLine}");
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }

            Console.Write(resultedOddLines.ToString());
        }
    }
}
