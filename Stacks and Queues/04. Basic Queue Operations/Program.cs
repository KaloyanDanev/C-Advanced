using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> operations = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int nAdd = operations.Dequeue();
            int sRemove = operations.Dequeue();
            int xSmallElement = operations.Dequeue();

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> result = new Queue<int>();


            for (int i = 0; i < nAdd; i++)
            {
                result.Enqueue(queue.Dequeue());
            }



            for (int i = 0; i < sRemove; i++)
            {
                result.Dequeue();
            }
            if (result.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (result.Contains(xSmallElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(result.Min());
            }
        }
    }
}