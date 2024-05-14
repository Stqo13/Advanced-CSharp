using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
	public class Car
	{
		public Car()
		{
			this.Make = "VW";
			this.Model = "Golf";
			this.Year = 2025;
			this.FuelQuantity = 200;
			this.FuelConsumption = 10;
		}
		public Car(string make, string model, int year)
			: this()
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}
		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
			: this(make, model, year)
		{
			this.FuelQuantity = fuelQuantity;
			this.FuelConsumption = fuelConsumption;
		}
		public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
			: this(make, model, year, fuelQuantity, fuelConsumption)
        {
			this.Engine = engine;
			this.Tires = tires;
        }
        private string make;

		public string Make
		{
			get { return make; }
			set { make = value; }
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private int years;

		public int Year
		{
			get { return years; }
			set { years = value; }
		}
		private double fuelQunatity;

		public double FuelQuantity
		{
			get { return fuelQunatity; }
			set { fuelQunatity = value; }
		}
		private double fuelConsumption;

		public double FuelConsumption
		{
			get { return fuelConsumption; }
			set { fuelConsumption = value; }
		}
		private Tire[] tires;
        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        private Engine engine; 
        public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		public void Drive(double distance)
		{
			if (distance*this.fuelConsumption>this.fuelQunatity)
			{
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
			else
			{
				fuelQunatity -= distance * fuelConsumption;
			}
		}
		public double DriveTwenty()
		{
			this.fuelQunatity -= fuelConsumption / 100 * 20;
			return this.fuelQunatity;
		}
		public string WhoAmI()
		{
			StringBuilder result = new StringBuilder();
			result.AppendLine($"Make: {this.Make}");
			result.AppendLine($"Model: {this.Model}");
			result.AppendLine($"Year: {this.Year}");
			result.AppendLine($"Fuel: {this.FuelQuantity:f2}");
			return result.ToString().Trim();
		}
    }
}
