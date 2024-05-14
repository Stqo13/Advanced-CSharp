using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (!occurrences.ContainsKey(currentChar))
                {
                    occurrences.Add(currentChar, 0);
                }
                occurrences[currentChar]++;
            }
            occurrences = occurrences.OrderBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
