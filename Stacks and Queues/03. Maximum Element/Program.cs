using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int cmmands = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var max = new Stack<int>();

            max.Push(int.MinValue);
            for (int i = 0; i < cmmands; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (command[0])
                {
                    case 1:
                        var element = command[1];
                        stack.Push(element);
                        if (element >= max.Peek())
                        {
                            max.Push(element);
                        }
                        break;

                    case 2:
                        var pop = stack.Pop();
                        if (max.Peek() == pop)
                        {
                            max.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = max.Peek();
                        Console.WriteLine(maxElement);
                        break;
                }
            }
        }
    }
}
