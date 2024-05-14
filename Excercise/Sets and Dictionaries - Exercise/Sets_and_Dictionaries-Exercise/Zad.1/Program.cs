using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string users = Console.ReadLine();
                usernames.Add(users);
            }
            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
