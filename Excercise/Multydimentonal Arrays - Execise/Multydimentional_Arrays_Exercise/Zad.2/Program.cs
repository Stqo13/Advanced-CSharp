using System;
using System.Linq;   
using System.Collections.Generic;

namespace Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            int numbersOfSquares = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentChar = matrix[row,col];
                    if (currentChar==matrix[row,col+1] 
                        && currentChar==matrix[row+1, col] 
                        && currentChar==matrix[row+1, col+1])
                    {
                        numbersOfSquares++;
                    }
                }
            }
            Console.WriteLine(numbersOfSquares);
        }     
    }
}
