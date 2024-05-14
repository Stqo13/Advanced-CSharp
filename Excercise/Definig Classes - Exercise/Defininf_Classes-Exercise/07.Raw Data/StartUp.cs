namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car>cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model= commandInfo[0];
                int engineSpeed = int.Parse(commandInfo[1]);
                int enginePower = int.Parse(commandInfo[2]);
                int cargoWeight = int.Parse(commandInfo[3]);
                string cargoType = commandInfo[4];
                double tire1Pressure = double.Parse(commandInfo[5]);
                int tire1Age= int.Parse(commandInfo[6]);
                double tire2Pressure = double.Parse(commandInfo[7]);
                int tire2Age = int.Parse(commandInfo[8]);
                double tire3Pressure = double.Parse(commandInfo[9]);
                int tire3Age = int.Parse(commandInfo[10]);
                double tire4Pressure = double.Parse(commandInfo[11]);
                int tire4Age = int.Parse(commandInfo[12]);
                Car car = new Car(model, engineSpeed, enginePower,
                    cargoType, cargoWeight,
                    tire1Age, tire1Pressure, tire2Age, tire2Pressure,
                    tire3Age, tire3Pressure, tire4Age, tire4Pressure);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            foreach (Car car in cars)
            {
                if (command == "fragile" && car.Cargo.Type=="fragile" && car.Tires.Any(tire=>tire.Pressure < 1))
                {
                    Console.WriteLine($"{car.Model}");
                }
                else if (command == "flammable" && car.Cargo.Type == "flammable" && car.Engine.Power>250)
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}