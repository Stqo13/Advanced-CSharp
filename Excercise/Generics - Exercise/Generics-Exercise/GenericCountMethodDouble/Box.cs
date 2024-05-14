using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> values;
        public Box()
        {
            values = new List<T>();
        }
        public void Add(T element)
        {
            values.Add(element);
        }
        public int Compare(T number)
        {
            int count = 0;
            foreach (T item in values)
            {
                if (item.CompareTo(number)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
