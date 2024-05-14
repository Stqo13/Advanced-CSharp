using System;
using System.Linq;
using System.Collections.Generic;

namespace StackAndQueues_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(nums);
            for (int i = 0; i < commands[1]; i++)
            {
                numbers.Pop();
            }
            if (numbers.Count==0)
            {
                Console.WriteLine("0");
                return;
            }
            bool flag = false;
            int min = int.MaxValue;
            foreach (var item in numbers)
            {  
                if (min>item)
                {
                    min = item;
                }
                if (item== commands[2])
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(min);
            }
        }
    }
}
