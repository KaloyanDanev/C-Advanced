using System;

namespace _11._Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            bool[][] parking = new bool[rows][];
        }
    }
}
