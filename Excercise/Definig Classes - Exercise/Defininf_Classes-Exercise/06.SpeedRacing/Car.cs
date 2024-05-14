using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
			this.TravelledDistance = 0;
        }
        private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private double fuelAmount;

		public double FuelAmount
        {
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}
		private double fuelConsumptionPerKilometer;

		public double FuelConsumptionPerKilometer
        {
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}
		private double travelledDistance;

		public double TravelledDistance
        {
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}
		public void DriveDistance(Car car, double distance)
		{
			if (car.FuelConsumptionPerKilometer*distance<=car.FuelAmount)
			{
				car.FuelAmount -= distance * car.FuelConsumptionPerKilometer;
				car.TravelledDistance += distance;
			}
			else
			{
                Console.WriteLine("Insufficient fuel for the drive");
            }
		}
	}
}
