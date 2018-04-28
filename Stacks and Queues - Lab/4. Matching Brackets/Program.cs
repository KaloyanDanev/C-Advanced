using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();
            for (int counter = 0; counter < input.Length; counter++)
            {
                if (input[counter] == '(')
                {
                    stack.Push(counter);
                }
                if (input[counter] == ')')
                {
                    var openBracket = stack.Pop();
                    var lenght = counter - openBracket + 1;
                    Console.WriteLine(input.Substring(openBracket, lenght));
                }
            }
        }
    }
}
