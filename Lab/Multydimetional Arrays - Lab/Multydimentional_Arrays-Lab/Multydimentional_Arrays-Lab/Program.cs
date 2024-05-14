using System;
using System.Linq;
using System.Collections.Generic;

namespace Multydimentional_Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, sizes));
            Console.WriteLine(sum);
        }
    }
}
