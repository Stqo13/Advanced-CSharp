using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(nums);
            string input = Console.ReadLine().ToLower();
            while (input!="end")
            {
                string[] commandInfo = input.Split();
                switch (commandInfo[0])
                {
                    case "add":
                        int first = int.Parse(commandInfo[1]);
                        int second = int.Parse(commandInfo[2]);
                        numbers.Push(first);
                        numbers.Push(second);
                        break;
                    case "remove":
                        int count = int.Parse(commandInfo[1]);
                        if (count<numbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                numbers.Pop();
                            }
                        }
                        break;

                }
                input = Console.ReadLine().ToLower();
            }
            int sum = 0;
            int counter = numbers.Count();
            for (int i = 0; i < counter; i++)
            {
                sum += numbers.Pop();
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
