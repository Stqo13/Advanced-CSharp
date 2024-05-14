namespace Zad._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names=Console.ReadLine().Split().ToList();
            string input=Console.ReadLine();
            Func<string, List<string>, List<string>> filter = (command, names) =>
            {
                List<string> result = new List<string>();
                while (command!="Party!")
                {
                    string[] commandInfo = command.Split();
                    switch (commandInfo[0])
                    {
                        case "Remove":

                            break;
                    }
                    command = Console.ReadLine();
                }
                return result;
            };
        }
    }
}