using System;
using System.Linq;
using System.Collections.Generic;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int height = int.Parse(Console.ReadLine());
            long[][] triangle = new long[height][];

            for (int i = 0; i < height; i++)
            {
                long[] row = new long[i + 1];
                row[0] = 1;
                row[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    row[j] = triangle[i - 1][j] + triangle[i - 1][j - 1];
                }

                triangle[i] = row;
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(string.Join(' ', triangle[i]));
            }
            */
            int rows = int.Parse(Console.ReadLine());
            int currentLength = 1;
            long[][] triangle = new long[rows][];
 
            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new long[currentLength];
                triangle[i][0] = 1;                             
                triangle[i][currentLength - 1] = 1;            
                if (currentLength > 2)
                {
                    for (int j = 1; j < currentLength - 1; j++)
                    {
                        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                    }
                }
 
                currentLength++;
            }
            foreach (long[] row in triangle)
            {
                Console.WriteLine(string.Join(' ', row));
            }
        }
    }
}
