using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> studentInfo = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[]input= Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentInfo.ContainsKey(name))
                {
                    studentInfo.Add(name, new List<decimal>());
                }
                studentInfo[name].Add(grade);
            }
            foreach (var kvp in studentInfo)
            {
                Console.Write($"{kvp.Key} -> ");
                foreach (var item in kvp.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
