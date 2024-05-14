using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(numbers);
            bool isComplete = true;
            if (orders.Any())
            {
                Console.WriteLine(orders.Max());
            }
            for(int i=0; i<numbers.Length;i++)
            {
                if (quantity >= numbers[i])
                {
                    int order = orders.Dequeue();
                    quantity -= order;
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    isComplete = false;
                    break;
                }
            }
            if(isComplete)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
