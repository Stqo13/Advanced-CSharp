using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    indexes.Push(i);
                }
                else if(input[i]==')')
                {
                    int index = indexes.Pop();
                    for (int j = index; j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
