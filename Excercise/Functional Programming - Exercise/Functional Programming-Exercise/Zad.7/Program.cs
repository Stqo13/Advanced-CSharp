using System.Net.Http.Headers;

namespace Zad._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length=int.Parse(Console.ReadLine());
            List<string>names=Console.ReadLine().Split().ToList();
            Func<int, List<string>, List<string>> filter = (length, names) =>
            {
                List<string>result = new List<string>();
                foreach (var name in names)
                {
                    if (name.Length<=length)
                    {
                        result.Add(name);
                    }
                }
                return result;
            };
            List<string> result = filter(length, names);
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}