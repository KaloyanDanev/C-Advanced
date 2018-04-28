using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            char[] open = new[] {'(', '[', '{'};
            char[] close = new[] {')', ']', '}'};

            var stack = new Stack<char>();
            foreach (var element in input)
            {
                if (open.Contains(element))
                {
                    stack.Push(element);
                } else if (close.Contains(element))
                {
                    var lastElement = stack.Pop();
                    int opening = Array.IndexOf(open, lastElement);
                    int closing = Array.IndexOf(close, element);

                    if (opening != closing)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
