using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();
            HashSet<int> matches = new HashSet<int>();
            for (int i = 0; i < lengths[0]; i++)
            {
                int firstSet = int.Parse(Console.ReadLine());
                setOne.Add(firstSet);
            }
            for (int i = 0; i < lengths[1]; i++)
            {
                int secondSet = int.Parse(Console.ReadLine());
                setTwo.Add(secondSet);
            }
            foreach (var item in setOne)
            {
                if (setTwo.Contains(item))
                {
                    matches.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
