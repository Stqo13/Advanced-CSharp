using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> numbers = new Dictionary<double, int>();
            foreach (var item in input)
            {
                if (!numbers.ContainsKey(item))
                {
                    numbers.Add(item, 0);
                }
                    numbers[item]++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
