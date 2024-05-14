using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int startRow = 0;
            int startCol = 0;
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2]+matrix[row+2,col]+matrix[row+2,col+1];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        startRow = row;
                        startCol = col;
                    }
                    currentSum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[startRow, startCol]} {matrix[startRow, startCol+1]} {matrix[startRow, startCol+2]}");
            Console.WriteLine($"{matrix[startRow+1, startCol]} {matrix[startRow+1, startCol+1]} {matrix[startRow+1, startCol+2]}");
            Console.WriteLine($"{matrix[startRow+2, startCol]} {matrix[startRow+2, startCol+1]} {matrix[startRow+2, startCol+2]}");
        }
    }
}
