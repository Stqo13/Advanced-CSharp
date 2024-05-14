using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int row = 0; row < rows-1; row++)
            {
                if (jagged[row].Length==jagged[row+1].Length)
                {   //
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row+1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            string input = Console.ReadLine();
            while (input!="End")
            {
                string[] commandInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);
                switch (commandInfo[0])
                {
                    case "Add":
                        if (row < jagged.Length
                            && row >= 0
                            && col < jagged[row].Length 
                            && col >=0)
                        {
                            jagged[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (row < jagged.Length
                            && row >= 0
                            && col < jagged[row].Length
                            && col >= 0)
                        {
                            jagged[row][col] -= value;
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
