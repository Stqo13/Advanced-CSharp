using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>>information=new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string continent = command[0];
                string country = command[1];
                string city = command[2];
                if (!information.ContainsKey(continent))
                {
                    information.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!information[continent].ContainsKey(country))
                {
                    information[continent].Add(country, new List<string>());
                }
                information[continent][country].Add(city);
            }
            foreach (var continent in information)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
