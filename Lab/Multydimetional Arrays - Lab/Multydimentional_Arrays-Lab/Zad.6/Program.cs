using System;
using System.Linq;
using System.Collections.Generic;

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
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string command = Console.ReadLine();
            while (command!="END")
            {
                string[] commandInfo = command.Split();
                int row = int.Parse(commandInfo[1]);
                int col = int.Parse(commandInfo[2]);
                int value = int.Parse(commandInfo[3]);
                if (row<0||col<0||row>=jagged.Length||col>=jagged[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (commandInfo[0])
                    {
                        case "Add":
                            jagged[row][col] += value;
                            break;
                        case "Subtract":
                            jagged[row][col] -= value;
                            break;
                    }
                }
                command = Console.ReadLine();
            }
            for (int row = 0; row < jagged.Length; row++)
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
