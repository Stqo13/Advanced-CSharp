﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> stack;
        public Box()
        {
            stack = new Stack<T>();
        }
        public void Add(T element)
        {
            stack.Push(element);
        }
        public T Remove() 
        { 
            return stack.Pop(); 
        }
        public int Count
        {
            get { return stack.Count; }
        }
    }
}
