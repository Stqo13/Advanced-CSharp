using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string swap = commandInfo[0];
                if (int.TryParse(commandInfo[1], out int first) && int.TryParse(commandInfo[2], out int second)
                    && int.TryParse(commandInfo[3], out int third) && int.TryParse(commandInfo[4], out int fourth))
                {
                    int rowOne = first;
                    int colOne = second;
                    int rowTwo = third;
                    int colTwo = fourth;
                    if (swap != "swap" || commandInfo.Length != 5
                    || rowOne >= matrix.GetLength(0)
                    || rowTwo >= matrix.GetLength(0)
                    || colOne >= matrix.GetLength(1)
                    || colTwo >= matrix.GetLength(1)
                    || rowOne < 0 || rowTwo < 0
                    || colOne < 0 || colTwo < 0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string parameter = matrix[rowOne, colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = parameter;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                } 
                input = Console.ReadLine();
            }
        }
    }
}
