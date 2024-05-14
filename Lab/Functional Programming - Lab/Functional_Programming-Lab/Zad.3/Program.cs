using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                if (char.IsUpper(item[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
