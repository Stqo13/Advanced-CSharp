using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Car
    {
        public Car(string model, int speed, int power,
			string type, int weight,
            int tire1Age, double tire1Pressure,
            int tire2Age, double tire2Pressure,
            int tire3Age, double tire3Pressure,
            int tire4Age, double tire4Pressure)
		{
			this.Model = model;
			this.Engine = new Engine(speed, power);
			this.Cargo = new Cargo(type, weight);
			this.Tires = new Tires[4];
			Tires[0] = new Tires(tire1Pressure, tire1Age);
			Tires[1] = new Tires(tire2Pressure, tire2Age);
			Tires[2] = new Tires(tire3Pressure, tire3Age);
			Tires[3] = new Tires(tire4Pressure, tire4Age);
		}
        private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private Engine engine;

		public Engine Engine
		{
			get { return engine; }
			set { engine = value; }
		}
		private Cargo cargo;

		public Cargo Cargo
		{
			get { return cargo; }
			set { cargo = value; }
		}
		private Tires[] tires;

		public Tires[] Tires
		{
			get { return tires; }
			set { tires = value; }
		}

	}
}
