using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Engine
    {
		public Engine(string model, int power, int displacement, string efficiency)
        {
			this.Model = model;
			this.Power = power;
			this.Displacement = displacement;
			this.Efficiency = efficiency;
        }
        private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private int power;

		public int Power
		{
			get { return power; }
			set { power = value; }
		}
		private int displacement;

		public int Displacement
		{
			get { return displacement; }
			set { displacement = value; }
		}
		private string efficiency;

		public string Efficiency
        {
			get { return efficiency; }
			set { efficiency = value; }
		}

	}
}
