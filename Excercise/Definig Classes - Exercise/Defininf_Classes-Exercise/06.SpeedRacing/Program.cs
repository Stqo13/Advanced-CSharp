namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car>cars= new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[]carInfo=Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car();
                car.Model = carInfo[0];
                car.FuelAmount = double.Parse(carInfo[1]);
                car.FuelConsumptionPerKilometer = double.Parse(carInfo[2]);
                cars.Add(car);
            }
            string input= Console.ReadLine();
            while (input!="End")
            {
                string[] driveInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = driveInfo[1];
                double distance = double.Parse(driveInfo[2]);
                Car car = cars.FirstOrDefault(car => car.Model == carModel);
                car.DriveDistance(car, distance);
                input = Console.ReadLine();
            }
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}