﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Arrays___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var values = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < rowsAndColumns[1]; col++)
                {
                    matrix[rows, col] = values[col];
                }
            }
            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[rows, col];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
