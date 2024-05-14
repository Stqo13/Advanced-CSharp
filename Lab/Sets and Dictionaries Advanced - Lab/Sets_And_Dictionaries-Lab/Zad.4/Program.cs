using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input!="Revision")
            {
                string[] commandInfo = input.Split(", ");
                string shop = commandInfo[0];
                string product = commandInfo[1];
                double price = double.Parse(commandInfo[2]);
                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
                input = Console.ReadLine();
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x=>x.Key, x=>x.Value);
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
