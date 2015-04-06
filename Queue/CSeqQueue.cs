using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    //CircleSequenceQueue 循环顺序队列
    public class CSeqQueue<T> : IQueue<T>
    {
        private T[] data;
        private int front;
        //rear存的是最后一个元素的下一个！
        private int rear;
        private int maxSize;

        //注意index范围不是1到maxSize-1
        //而是1到GetLength()！！！！！！
        public T this[int index]
        {
            get
            {
                int length = (rear - front + maxSize) % maxSize;
                if (index > 0 && index <= length)
                {
                    return data[(front + index - 1) % maxSize];
                }
                else
                {
                    Console.WriteLine("队列长度为:{0}，您输入的范围有误", length);
                    return default(T);
                }
            }
            set
            {
                int length = (rear - front + maxSize) % maxSize;
                if (index > 0 && index <= length)
                {
                    data[(front + index - 1) % maxSize] = value;
                }
                else
                {
                    Console.WriteLine("队列长度为:{0}，您输入的范围有误", length);
                }
            }
        }
        public int Front
        {
            get { return front; }
        }
        public int Rear
        {
            get { return rear; }
        }
        //这里故意给真正的数组长度maxSize多申请一位用于放空的占位符
        public int MaxSize
        {
            get { return maxSize - 1; }
        }
        //这里故意给真正的数组长度maxSize多申请一位用于放空的占位符
        public CSeqQueue(int size)
        {
            maxSize = size + 1;
            data = new T[maxSize];
            front = 0;
            rear = 0;
        }

        public int GetLength()
        {
            return (rear - front + maxSize) % maxSize;
        }

        public bool IsEmpty()
        {
            return rear == front;
        }

        private bool IsFull()
        {
            return (rear + 1) % maxSize == front;
        }

        public void Clear()
        {
            rear = 0;
            front = 0;
        }

        public void In(T elem)
        {
            if (IsFull())
            {
                Console.WriteLine("循环队列已满！");
            }
            else
            {
                data[rear] = elem;
                rear = (rear + 1) % maxSize;
            }
        }

        public T Out()
        {
            T result = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("循环队列为空！");
            }
            else
            {
                result = data[front];
                front = (front + 1) % maxSize;
            }
            return result;
        }

        public T GetFront()
        {
            T result = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("循环队列为空！");
            }
            else
            {
                result = data[front];
            }
            return result;
        }
    }
}
