using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesis = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='{'||input[i]=='['||input[i]=='(')
                {
                    parenthesis.Push(input[i]);
                    continue;
                }
                if (!parenthesis.Any())
                {
                    Console.WriteLine("NO");
                    return;
                }
                if(input[i] == ')' && parenthesis.Peek()=='(')
                {
                    parenthesis.Pop();
                }
                else if (input[i] == ']' && parenthesis.Peek() == '[')
                {
                    parenthesis.Pop();
                }
                else if (input[i] == '}' && parenthesis.Peek() == '{')
                {
                    parenthesis.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
