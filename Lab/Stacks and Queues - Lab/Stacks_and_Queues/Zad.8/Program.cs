using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//4
            string input = Console.ReadLine();//car name or green
            Queue<string> carNames = new Queue<string>();
            int counter = 0;
            while (input!="end")
            {
                if (input!="green")
                {
                    carNames.Enqueue(input);
                }
                else if (input=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carNames.Any())
                        {
                          string result = carNames.Dequeue();
                          Console.WriteLine($"{result} passed!");
                          counter++;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
