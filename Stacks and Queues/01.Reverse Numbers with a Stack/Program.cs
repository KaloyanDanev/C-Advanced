using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_Numbers_with_a_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            foreach (var num in numbers)
            {
                stack.Push(num);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
