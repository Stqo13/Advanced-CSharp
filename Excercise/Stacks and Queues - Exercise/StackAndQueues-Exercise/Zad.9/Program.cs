using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Zad._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> states = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                switch (commands[0])
                {
                    case "1":
                        states.Push(text);
                        text += commands[1];
                        break;
                    case "2":
                        states.Push(text);
                        int count = int.Parse(commands[1]);
                        text = text.Substring(0, text.Length - count);
                        break;
                    case "3":
                        int index = int.Parse(commands[1]);
                        Console.WriteLine(text[index-1]);
                        break;
                    case "4":
                        text = states.Pop();
                        break;
                }
            }
        }
    }
}
