using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] += numbers[i] * 0.2;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
