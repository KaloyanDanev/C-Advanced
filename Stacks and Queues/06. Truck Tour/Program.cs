using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                queue.Enqueue(pump);
            }
            for (int start = 0; start < n - 1; start++)
            {
                int fuel = 0;
                bool isSolution = true;
                for (int passed = 0; passed < n; passed++)
                {
                    var currentPump = queue.Dequeue();
                    int pumpFuel = currentPump[0];
                    int nextPump = currentPump[1];
                    queue.Enqueue(currentPump);
                    fuel += pumpFuel - nextPump;
                    if (fuel < 0)
                    {
                        start += passed;
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    Console.WriteLine(start);
                    Environment.Exit(0);
                }
            }
        }
    }
}
