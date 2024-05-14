namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Box<string>>boxes = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                Box<string> box = new Box<string>()
                {
                    Value = element
                };
                boxes.Add(box);
            }
            foreach (Box<string> box in boxes)
            {
                Console.WriteLine($"{box.GetTypeOf()}: {box.ToString()}");
            }
        }
    }
}