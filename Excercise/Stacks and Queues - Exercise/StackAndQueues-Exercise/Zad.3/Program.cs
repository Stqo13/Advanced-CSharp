using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commandInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (commandInfo[0])
                {
                    case 1:
                        int insertNumber = commandInfo[1];
                        numbers.Push(insertNumber);
                        break;
                    case 2:
                        numbers.Pop();
                        break;
                    case 3:
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case 4:
                        if (numbers.Any())
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
