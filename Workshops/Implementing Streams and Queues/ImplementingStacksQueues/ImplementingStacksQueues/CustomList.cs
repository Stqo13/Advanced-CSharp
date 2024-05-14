using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStacksQueues
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        public int this[int index]
        {
            get
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.items[index];
            }
            set
            {
                if (index>=this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }
        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public void Add(int item)
        {
            if (this.items.Length==this.Count)
            {
                this.Resize();
            }
            this.items[this.Count] = item;
            this.Count++;
        }
    }
}
