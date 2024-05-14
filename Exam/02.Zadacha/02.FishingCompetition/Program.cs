namespace _02.FishingCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] fishingArea = new char[n, n];
            int rowPosition = 0;
            int colPosition = 0;
            int fishCaught = 0;
            int quota = 20;

            for (int row = 0; row < n; row++)
            {
                string rowInput = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    fishingArea[row, col] = rowInput[col];

                    if (fishingArea[row, col] == 'S')
                    {
                        rowPosition = row;
                        colPosition = col;
                        fishingArea[rowPosition, colPosition] = '-';
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "collect the nets")
            {
                if (command == "up")
                {
                    rowPosition--;
                    if (rowPosition < 0)
                    {
                        rowPosition = n - 1;
                    }
                }
                else if (command == "down")
                {
                    rowPosition++;
                    if (rowPosition >= n)
                    {
                        rowPosition = 0;
                    }
                }
                else if (command == "left")
                {
                    colPosition--;
                    if (colPosition < 0)
                    {
                        colPosition = n - 1;
                    }
                }
                else if (command == "right")
                {
                    colPosition++;
                    if (colPosition >= n)
                    {
                        colPosition = 0;
                    }
                }

                char currentCell = fishingArea[rowPosition, colPosition];
                if (char.IsDigit(currentCell))
                {
                    int fishInCell = int.Parse(currentCell.ToString());
                    fishCaught += fishInCell;
                    fishingArea[rowPosition, colPosition] = '-';
                }
                else if (currentCell == 'W')
                {
                    Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{rowPosition},{colPosition}]");
                    return;
                }

            }
            fishingArea[rowPosition, colPosition] = 'S';

            if (fishCaught >= quota)
            {
                Console.WriteLine("Success! You managed to reach the quota!");
            }
            else if(fishCaught<quota)
            {
                int lackOfFish = quota - fishCaught;
                Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {lackOfFish} tons of fish more.");
            }
            if (fishCaught>0)
            {
                Console.WriteLine($"Amount of fish caught: {fishCaught} tons.");
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(fishingArea[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}