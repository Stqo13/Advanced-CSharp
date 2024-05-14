using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] colorOfClothes = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string[] clothes = colorOfClothes[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                string color = colorOfClothes[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    string item = clothes[j];
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color].Add(item, 0);
                        wardrobe[color][item]++;
                    }
                    else
                    {
                        wardrobe[color][item]++;
                    }
                }
            }
            string[] wantedItem = Console.ReadLine().Split();
            string wantedColor = wantedItem[0];
            string clothing = wantedItem[1];
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var kvp in item.Value)
                {
                    if (item.Key==wantedColor && kvp.Key==clothing)
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }
    }
}
