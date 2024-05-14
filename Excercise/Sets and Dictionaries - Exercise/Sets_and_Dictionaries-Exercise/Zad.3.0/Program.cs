using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemicalElements = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    chemicalElements.Add(elements[j]);
                }
            }
            chemicalElements = chemicalElements.OrderBy(x => x).ToHashSet();
            foreach (var item in chemicalElements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
