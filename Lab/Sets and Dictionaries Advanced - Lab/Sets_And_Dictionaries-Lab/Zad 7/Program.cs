using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();
            string input = Console.ReadLine();
            while (input!="END")
            {
                string[] commandInfo = input.Split(", ");
                string direction = commandInfo[0];
                string number = commandInfo[1];
                switch (direction)
                {
                    case "IN":
                        carNumbers.Add(number);
                        break;
                    case "OUT":
                        carNumbers.Remove(number);
                        break;
                }
                input = Console.ReadLine();
            }
            if (carNumbers.Any())
            {
                foreach (var item in carNumbers)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
