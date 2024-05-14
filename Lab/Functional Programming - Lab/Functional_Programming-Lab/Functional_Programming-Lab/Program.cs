using System;
using System.Linq;
using System.Collections.Generic;

namespace Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            numbers = numbers.Where(x => x % 2 == 0).OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
