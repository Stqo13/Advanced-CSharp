namespace GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                box.Add(element);
            }
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(box.Compare(number));
        }
    }
}