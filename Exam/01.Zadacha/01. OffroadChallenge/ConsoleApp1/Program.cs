using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuels = new Stack<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
            );
            Queue<int> indexes = new Queue<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
            );
            Queue<int> quantities = new Queue<int>(
                Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
            );

            int counter = 0;
            List<string> reachedAltitudes = new List<string>();
            bool hasFailedToReachTop = false;

            while (fuels.Count > 0 && indexes.Count > 0 && quantities.Count > 0)
            {
                int fuel = fuels.Pop();
                int index = indexes.Dequeue();
                int quantity = quantities.Dequeue();
                int result = fuel - index;

                if (result >= quantity)
                {
                    counter++;
                    reachedAltitudes.Add($"Altitude {counter}");
                    Console.WriteLine($"John has reached: Altitude {counter}");
                }
                else
                {
                    hasFailedToReachTop = true;
                    Console.WriteLine($"John did not reach: Altitude {counter + 1}");
                    break;
                }
            }

            if (hasFailedToReachTop)
            {
                Console.WriteLine("John failed to reach the top.");
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }

            if (reachedAltitudes.Count > 0)
            {
                Console.WriteLine("Reached altitudes: " + string.Join(", ", reachedAltitudes));
            }
            else
            {
                Console.WriteLine("John didn't reach any altitude.");
            }
        }
    }
}
