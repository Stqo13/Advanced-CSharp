namespace Zad._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(numbers.Min());
        }
    }
}