namespace CustomThreeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Threeuple
            string[] personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] bankInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Threeuple<string, string, string> person =
                new Threeuple<string, string, string>($"{personInfo[0]} {personInfo[1]}", personInfo[2], string.Join(" ", personInfo[3..]));
            Threeuple<string, int, bool> drinks =
                new Threeuple<string, int, bool>(beerInfo[0], int.Parse(beerInfo[1]), beerInfo[2] == "drunk");
            Threeuple<string, double, string> bank =
                new Threeuple<string, double, string>(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);
            Console.WriteLine(person.ToString());
            Console.WriteLine(drinks.ToString());
            Console.WriteLine(bank.ToString());
        }
    }
}