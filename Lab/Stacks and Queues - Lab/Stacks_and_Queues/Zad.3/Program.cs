using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> elements = new Stack<string>(input.Reverse());
            int result = int.Parse(elements.Pop());
            while (elements.Count>0)
            {
                string sing = elements.Pop();
                int number = int.Parse(elements.Pop());
                switch (sing)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
