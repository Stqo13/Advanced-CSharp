using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int mainSum = 0;
            int secondarySum = 0;
            for (int i = 0; i < n; i++)
            {
                mainSum += matrix[i, i];
                secondarySum += matrix[i+matrix.GetLength(1)-i-1];
            }
            
        }
    }
}

