using System.Data;
using System.Globalization;
using System.Net.Http.Headers;
using System.Xml;

namespace Zad._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            Func<string, List<int>, List<int>> calculate = (command, numbers) =>
            {
                List<int> result = new List<int>();
                foreach (var item in numbers)
                {
                    switch (command)
                    {
                        case "add":
                            result.Add(item + 1);
                            break;
                        case "subtract":
                            result.Add(item - 1);
                            break;
                        case "multiply":
                            result.Add(item * 2);
                            break;
                    }
                }
                return result;
            };
            Action<List<int>> print = numbers => Console.WriteLine(string.Join(" ", numbers));
            while (command!="end")
            {
                if (command == "print")
                {
                    print(numbers);
                }
                else
                {
                    numbers = calculate(command, numbers);
                }
                command = Console.ReadLine();
            }
        }
    }
}