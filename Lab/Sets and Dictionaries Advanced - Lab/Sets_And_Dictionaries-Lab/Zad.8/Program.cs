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
            HashSet<string> vipInvites = new HashSet<string>();
            HashSet<string> regularInvites = new HashSet<string>();
            while (input != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipInvites.Add(input);
                }
                else
                {
                    regularInvites.Add(input);
                }
                input = Console.ReadLine();
            }
            while (input!="END")
            {
                if (vipInvites.Contains(input))
                {
                    vipInvites.Remove(input);
                }
                else if (regularInvites.Contains(input))
                {
                    regularInvites.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(vipInvites.Count+regularInvites.Count);
            foreach (var vips in vipInvites)
            {
                Console.WriteLine(vips);
            }
            foreach (var regulars in regularInvites)
            {
                Console.WriteLine(regulars);
            }
        }
    }
}
