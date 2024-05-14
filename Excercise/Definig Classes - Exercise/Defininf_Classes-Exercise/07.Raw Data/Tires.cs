using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Tires
    {
        public Tires(double pressure, int age)
        {
	        Pressure = pressure;
            Age = age;
        }
        private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private double pressure;

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}
	}
}
