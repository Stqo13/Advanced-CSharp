namespace Zad._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange=int.Parse(Console.ReadLine());
            List<int> devidors=Console.ReadLine().Split().Select(int.Parse).ToList();
            int counter = 0;
            Func<int, List<int>, List<int>> filter = (endRange, devidors) =>
            {
                List<int> result = new List<int>();
                for (int i = 1; i <= endRange; i++)
                {
                    for (int j = 0; j < devidors.Count; j++)
                    {
                        if (i % devidors[j]==0)
                        {
                            counter++;
                        }
                    }
                    if (counter==devidors.Count)
                    {
                        result.Add(i);
                    }
                    counter = 0;
                }
                return result;
            };
            List<int> result = filter(endOfRange, devidors);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}