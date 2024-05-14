using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class SoftUniDoublyLinkedList
    {
        
    }
    public class ListNode
    {
        private int value;

        public int Value
        {
            get { return value; }
            set { value = value; }
        }
        private ListNode nextNode;

        public ListNode NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
        private ListNode previousNode;

        public ListNode PreviousNode
        {
            get { return previousNode; }
            set { previousNode = value; }
        }
        public ListNode(int value)
        {
            this.Value = value;
        }
        private ListNode head;
        private ListNode tail;

        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                var newHead = new ListNode(element);
                this.head = newHead;
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }
            this.Count++;
        }
        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(element);
            }
            else
            {
                var newTail = new ListNode(element);
                this.head = newTail;
                newTail.NextNode = this.tail;
                this.tail.PreviousNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }
        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            var lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail != null)
            {
                this.tail.NextNode = null;
            }
            else
            {
                this.head = null;
            }
            this.Count--;
            return lastElement;
        }
        public void ForEach(Action<int> action)
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }
    }
}
