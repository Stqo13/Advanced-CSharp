namespace Zad._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            SirPrint(list);
        }
        static void SirPrint(List<string> knights)
        {
            foreach (var item in knights)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}