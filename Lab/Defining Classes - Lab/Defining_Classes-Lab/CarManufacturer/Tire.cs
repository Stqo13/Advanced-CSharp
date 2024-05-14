﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year, double pressure)
        {
			this.Year = year;
			this.Pressure = pressure;
        }
        private int year;

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		private double pressure;

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

	}
}
