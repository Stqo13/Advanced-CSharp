namespace TupleExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] beerInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] numberInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CustomTuple<string, string> nameAddress = 
                new CustomTuple<string, string>($"{personInfo[0]} {personInfo[1]}", personInfo[2]);
            CustomTuple<string, double> nameBeer = 
                new CustomTuple<string, double>(beerInfo[0], double.Parse(beerInfo[1]));
            CustomTuple<int, double> numbers = 
                new CustomTuple<int, double>(int.Parse(numberInfo[0]), double.Parse(numberInfo[1]));
            Console.WriteLine(nameAddress.ToString());
            Console.WriteLine(nameBeer.ToString());
            Console.WriteLine(numbers.ToString());
        }
    }
}