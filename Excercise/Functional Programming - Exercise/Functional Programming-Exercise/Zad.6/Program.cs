
using System.Threading.Channels;

namespace Zad._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>numbers= Console.ReadLine().Split().Select(int.Parse).ToList();
            int num=int.Parse(Console.ReadLine());
            Func<int, List<int>, List<int>> function = (devidor, numbers) =>
            {
                List<int>result= new List<int>();
                foreach (var item in numbers)
                {
                    if (item%devidor!=0)
                    {
                        result.Add(item);
                    }
                }
                result.Reverse();
                return result;
            };
            List<int> result = function(num, numbers);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}