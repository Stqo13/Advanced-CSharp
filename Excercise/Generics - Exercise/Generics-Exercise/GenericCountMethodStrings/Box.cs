using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class Box<T> where T:IComparable<T>
    {
		private List<T> values;
        public Box()
        {
            values = new List<T>();
        }
        public void Add(T value)
        {
            values.Add(value);
        }
        public int Compare(T element)
        {
            int count = 0;
            foreach (T item in values)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
	}
}
