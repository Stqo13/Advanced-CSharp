using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>(songNames); 
            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string song = string.Join(" ",commands.Skip(1));
                        if (!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
                if (!queue.Any())
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
            }
        }
    }
}
