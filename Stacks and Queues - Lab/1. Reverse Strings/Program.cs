using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_and_Queues___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>(input.ToCharArray());
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop().ToString());
            }   
        }
    }
}
