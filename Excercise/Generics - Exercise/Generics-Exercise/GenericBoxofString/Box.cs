using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        private T value;
        public T Value 
        {
            get { return value; } 
            set { this.value = value; }
        }
        public object GetTypeOf()
        {
            return typeof(T);
        }
        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
