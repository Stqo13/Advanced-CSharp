namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int element=int.Parse(Console.ReadLine());
                list.Add(element);
            }
            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Swap<int>(list, indexes[0], indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static List<T> Swap<T>(List<T>values, int first, int second)
        {
            T copy = values[first];
            values[first] = values[second];
            values[second]= copy;
            return values;
        }
    }
}