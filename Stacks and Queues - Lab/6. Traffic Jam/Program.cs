using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var input = Console.ReadLine();
            int total = 0;
            while (input!="end")
            {
                if (input == "green")
                {
                    var pass = Math.Min(queue.Count, cars);
                    for (int i = 0; i < pass; i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        total++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                } 
                input = Console.ReadLine();      
        }
            Console.WriteLine($"{total} cars passed the crossroads.");
        }
    }
}
