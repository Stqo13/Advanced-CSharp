using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> names = new Queue<string>();
            int counter = 0;
            while (input != "End")
            {
                if (input != "Paid")
                {
                    names.Enqueue(input);
                    counter++;
                }
                else if (input == "Paid")
                {
                    for (int i = 0; i < counter; i++)
                    {
                        if (names.Any())
                        {
                            string result = names.Dequeue();
                            Console.WriteLine(result);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
