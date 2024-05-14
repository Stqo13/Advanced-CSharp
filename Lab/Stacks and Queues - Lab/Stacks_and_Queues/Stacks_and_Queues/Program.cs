using System;
using System.Linq;
using System.Collections.Generic;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>(input);
            while (reverse.Any())
            {
                char result = reverse.Pop();
                Console.Write(result);
            }
        }
    }
}
