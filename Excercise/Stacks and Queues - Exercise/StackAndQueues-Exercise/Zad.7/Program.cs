using System;
using System.Linq;
using System.Collections.Generic;

namespace Zad._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumpCount = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            for (int i = 0; i < petrolPumpCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int petrol = input[0];
                int distance = input[1];
                pumps.Enqueue(input);
            }
            int bestRoute = 0;
            while (true)
            {
                int totalPetrol = 0;
                foreach (var item in pumps)
                {
                    totalPetrol += item[0];
                    int currentDistance = item[1];
                    if (totalPetrol-currentDistance<0)
                    {
                        totalPetrol = 0;
                        break;
                    }
                    else
                    {
                        totalPetrol -= currentDistance;
                    }
                }
                if (totalPetrol>0)
                {
                    break;
                }
                bestRoute++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(bestRoute);
        }
    }
}
