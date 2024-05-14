using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers = numbers.OrderByDescending(x => x).Take(3).ToList();
            Console.Write(string.Join((" "), numbers));
        }
    }
}
