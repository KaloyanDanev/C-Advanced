using System;
using System.Diagnostics;

namespace _4._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int[][] triangle = new int[height][];
            for (int currentHeigh = 0; currentHeigh < height; currentHeigh++)
            {
                triangle[currentHeigh] = new int[currentHeigh + 1];
                triangle[currentHeigh][0] = 1;
                triangle[currentHeigh][currentHeigh] = 1;
                if (currentHeigh >= 2)
                {
                    for (int widthCounter = 1; widthCounter < currentHeigh; widthCounter++)
                    {
                        triangle[currentHeigh][widthCounter] = triangle[currentHeigh - 1][widthCounter - 1]
                                                               + triangle[currentHeigh - 1][widthCounter];
                    }
                }
            }
            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int cols = 0; cols < triangle[rows].Length; cols++)
                {
                    Console.Write(triangle[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
