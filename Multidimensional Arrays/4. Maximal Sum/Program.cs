using System;
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
            int[] rowsAndColumns = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColumns[0], rowsAndColumns[1]];
            for (int rows = 0; rows < rowsAndColumns[0]; rows++)
            {
                var values = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < rowsAndColumns[1]; col++)
                {
                    matrix[rows, col] = values[col];
                }
            }
            int sum = 0;
            int rowIndex = 0;
            int columnIndex = 0;
            for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var tempSum = matrix[rows, col] + matrix[rows, col + 1] + matrix[rows, col + 2]
                                  + matrix[rows + 1, col] + matrix[rows + 1, col + 1] + matrix[rows + 1, col + 2]
                                  + matrix[rows + 2, col] + matrix[rows + 2, col + 1] + matrix[rows + 2, col + 2];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = rows;
                        columnIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine(matrix[rowIndex, columnIndex] + " " + matrix[rowIndex, columnIndex + 1] + " " + matrix[rowIndex, columnIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 1, columnIndex] + " " + matrix[rowIndex + 1, columnIndex + 1] + " " + matrix[rowIndex + 1, columnIndex + 2]);
            Console.WriteLine(matrix[rowIndex + 2, columnIndex] + " " + matrix[rowIndex + 2, columnIndex + 1] + " " + matrix[rowIndex + 2, columnIndex + 2]);
            
        }
    }
}
