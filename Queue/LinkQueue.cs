using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int length;

        public Node<T> Front
        {
            get { return front; }
        }
        public Node<T> Rear
        {
            get { return rear; }
        }
        public int Length
        {
            get { return length; }
        }
        public LinkQueue()
        {
            front = null;
            rear = null;
            length = 0;
        }

        public int GetLength()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return front == null && rear == null && length == 0;
        }

        public void Clear()
        {
            front = null;
            rear = null;
            length = 0;
        }

        public void In(T elem)
        {
            Node<T> newNode = new Node<T>(elem);
            if (IsEmpty())
            {
                front = newNode;
                rear = newNode;
                length++;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                length++;
            }
        }

        public T Out()
        {
            T result = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("链队列为空！");
            }
            else
            {
                result = front.Data;
                front = front.Next;
                length--;
            }
            return result;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                return front.Data;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("链队列为空！");
            }
            Node<T> p = front;
            while (p != null)
            {
                Console.WriteLine(p.Data);
                p = p.Next;
            }
        }
    }
}
