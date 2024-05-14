using System.Text;

namespace _08.CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);
                int displacement=0;
                string efficiency = null;
                if (engineInfo.Length>2 && int.TryParse(engineInfo[2], out int parseDisplacement))
                {
                    displacement = parseDisplacement;
                }
                else if(engineInfo.Length>2)
                {
                    efficiency = engineInfo[2];
                }
                if (engineInfo.Length>3)
                {
                    efficiency = engineInfo[3];
                }
                Engine engine = new Engine(model, power, displacement, efficiency);
                engines[model] = engine;
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engine = carInfo[1];
                int weight = 0;
                string color = null;
                if (carInfo.Length > 2 && int.TryParse(carInfo[2], out int parsedWeight))
                {
                    weight = parsedWeight;
                }
                else if(carInfo.Length>2)
                {
                    color= carInfo[2];
                }
                if (carInfo.Length > 3)
                {
                    color = carInfo[3];
                }
                Car car = new Car(model, engines[engine], weight, color);
                cars.Add(car);
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"{item.Engine.Model}:");
                Console.WriteLine($"Power: {item.Engine.Power}");
                if (item.Engine.Displacement == 0)
                {
                    Console.WriteLine($"Displacement: n/a");
                }
                else
                {
                    Console.WriteLine($"Displacement: {item.Engine.Displacement}");
                }
                if (item.Engine.Efficiency == null)
                {
                    Console.WriteLine($"Efficiency: n/a");
                }
                else
                {
                    Console.WriteLine($"Efficiency: {item.Engine.Efficiency}");
                }
                if (item.Weight == 0)
                {
                    Console.WriteLine($"Weight: n/a");
                }
                else
                {
                    Console.WriteLine($"Weight: {item.Weight}");
                }
                if (item.Color == null)
                {
                    Console.WriteLine($"Color: n/a");
                }
                else
                {
                    Console.WriteLine($"Color: {item.Color}");
                }
            }
        }
    }
}