using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>(numbers);
            string result = string.Empty;
            while (evenNumbers.Any())
            {
                int number = evenNumbers.Dequeue();
                if (number%2==0)
                {
                    result += $"{number}, ";
                }
            }
            Console.WriteLine(result.TrimEnd(' ', ','));
        }
    }
}
