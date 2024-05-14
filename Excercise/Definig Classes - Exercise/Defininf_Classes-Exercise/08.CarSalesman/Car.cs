using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine, int weight, string color)
        {
			this.Model = model;
			this.Engine = engine;
			this.Weight = weight;
			this.Color = color;
        }
        private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		private Engine enigne;

		public Engine Engine
		{
			get { return enigne; }
			set { enigne = value; }
		}
		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

	}
}
