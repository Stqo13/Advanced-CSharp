using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {       
            string tireInfo=Console.ReadLine();
            List<Tire[]> tires = new List<Tire[]>();
            while (tireInfo != "No more tires")
            {
                string[] commandInfo = tireInfo.Split();
                Tire[] tire = new Tire[4]
                {
                    new Tire(int.Parse(commandInfo[0]), double.Parse(commandInfo[1])),
                    new Tire(int.Parse(commandInfo[2]), double.Parse(commandInfo[3])),
                    new Tire(int.Parse(commandInfo[4]), double.Parse(commandInfo[5])),
                    new Tire(int.Parse(commandInfo[6]), double.Parse(commandInfo[7]))
                };
                tires.Add(tire);
                tireInfo = Console.ReadLine();
            }
            string engineInfo = Console.ReadLine();
            List<Engine>engines = new List<Engine>();
            while (engineInfo!="Engines done")
            {
                string[] commandInfo = engineInfo.Split();
                Engine engine = new Engine(int.Parse(commandInfo[0]), double.Parse(commandInfo[1]));
                engines.Add(engine);
                engineInfo = Console.ReadLine();
            }
            string specialInfo= Console.ReadLine();
            List<Car> cars = new List<Car>();
            while (specialInfo != "Show special")
            {
                string[] commandInfo = specialInfo.Split();
                Car car = new Car();
                car.Make = commandInfo[0];
                car.Model = commandInfo[1];
                car.Year = int.Parse(commandInfo[2]);
                car.FuelQuantity = double.Parse(commandInfo[3]);
                car.FuelConsumption = double.Parse(commandInfo[4]);
                int engineIndex = int.Parse(commandInfo[5]);
                car.Engine = engines[engineIndex];
                int tiresIndex = int.Parse(commandInfo[6]);
                car.Tires = tires[tiresIndex];
                cars.Add(car);
                specialInfo = Console.ReadLine();
            }
            List<Car>specialCars = new List<Car>();
            foreach (Car car in cars)
            {
                if (car.Year>=2017 
                    && car.Engine.HorsePower>330.0 
                    && car.Tires.Sum(tire=>tire.Pressure)>=9 
                    && car.Tires.Sum(tire => tire.Pressure) <= 10)
                {
                    specialCars.Add(car);
                }
            }
            foreach (var item in specialCars)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Make: {item.Make}");
                stringBuilder.AppendLine($"Model: {item.Model}");
                stringBuilder.AppendLine($"Year: {item.Year}");
                stringBuilder.AppendLine($"HorsePowers: {item.Engine.HorsePower}");
                stringBuilder.AppendLine($"FuelQuantity: {item.DriveTwenty()}");
                Console.WriteLine(stringBuilder.ToString().Trim());
            }
            //Tire[] tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 23)
            //};
            //Engine engine = new Engine(560, 6300);
            //Car car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity = double.Parse(Console.ReadLine());
            //double fuelConsumption = double.Parse(Console.ReadLine());
            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
        }
    }
}
