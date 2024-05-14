using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(current))
                {
                    numbers.Add(current, 0);
                }
                    numbers[current]++;
            }
            foreach (var item in numbers)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
