namespace Zad._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int>odds = new List<int>();
            List<int>evens = new List<int>();
            for (int i = array[0]; i <= array[1]; i++)
            {
                if (i%2==0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }
            string command = Console.ReadLine();
            if (command=="odd")
            {
                Console.WriteLine(string.Join(" ", odds));
            }
            else if (command=="even")
            {
                Console.WriteLine(string.Join(" ", evens));
            }
        }
    }
}