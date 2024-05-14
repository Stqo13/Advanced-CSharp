using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> participants = new Queue<string>(names);
            while (participants.Count>1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    string name = participants.Dequeue();
                    participants.Enqueue(name);
                }
                Console.WriteLine($"Removed {participants.Dequeue()}");
            }
            Console.WriteLine($"Last is {participants.Peek()}");
        }
    }
}
