using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();

            Console.Write("{0} ", n);
            queue.Enqueue(n);
            int start = 1;

            while (start < 50)
            {
                n = queue.Dequeue();
                Console.Write("{0} ", n + 1);
                queue.Enqueue(n + 1);
                start++;
                if (start < 50)
                {
                    Console.Write("{0} ", 2 * n + 1);
                    queue.Enqueue(2 * n + 1);
                    start++;
                }
                else break;
                if (start < 50)
                {
                    Console.Write("{0} ", n + 2);
                    queue.Enqueue(n + 2);
                    start++;
                }
                else break;
            }
        }
    }
}
