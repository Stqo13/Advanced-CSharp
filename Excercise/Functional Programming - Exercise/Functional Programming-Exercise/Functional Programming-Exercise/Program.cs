using System.Threading.Channels;

namespace Functional_Programming_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Print(words);
        }
        static void Print(List<string>words)
        {
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}