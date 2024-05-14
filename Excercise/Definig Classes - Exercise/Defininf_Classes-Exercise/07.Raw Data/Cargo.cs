using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.RawData
{
    public class Cargo
    {
        public Cargo(string type, int weight)
        {
			Type = type;
			Weight = weight;
        }
        private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}
		private int weight;

		public int Weight
		{
			get { return weight; }
			set { weight = value; }
		}
	}
}
