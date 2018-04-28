using System;
using System.Linq;

namespace _3._Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None).Select(int.Parse).ToArray();
            var sizes = new int[3];
            foreach (var number in numbers)
            {
                sizes[Math.Abs(number % 3)]++;
            }
            int[][] jaggedArr = new int[3][];
            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArr[counter] = new int[sizes[counter]];
            }
            int[] index = new int[3];
            foreach (var number in numbers)
            {
                var reminder = Math.Abs(number % 3);
                jaggedArr[number % 3][index[reminder]] = number;
                index[reminder]++;
            }
            for (int rows = 0; rows < jaggedArr.Length; rows++)
            {
                for (int cols = 0; cols < jaggedArr[rows].Length; cols++)
                {
                    Console.Write(jaggedArr[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
