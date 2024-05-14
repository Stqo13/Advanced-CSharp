namespace GenericBoxOfInteger
{
    public class Startup
    {
        static void Main(string[] args)
        {
            List<Box<int>>boxes = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>();
                box.Value = number;
                boxes.Add(box);
            }
            foreach (Box<int> box in boxes)
            {
                Console.WriteLine($"{box.GetTypeOf()}: {box.ToString()}");
            }
        }
    }
}