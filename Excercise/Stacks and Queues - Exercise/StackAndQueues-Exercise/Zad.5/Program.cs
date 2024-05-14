using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(input.Reverse());
            int racksUsed = 1;
            int sum = 0;
            while(clothes.Any())
            {
                int current = clothes.Pop();
                if (current+sum<=capacity)
                {
                    sum += current;
                }
                else
                {
                    racksUsed++;
                    sum = current;
                }
            }
            Console.WriteLine(racksUsed);
        }
    }
}
