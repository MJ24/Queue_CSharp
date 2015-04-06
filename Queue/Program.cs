using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkQueue<int> queue = new LinkQueue<int>();
            //CSeqQueue<int> queue = new CSeqQueue<int>(4);
            MyPrint(queue);
            queue.Out();
            MyPrint(queue);
            queue.In(1);
            MyPrint(queue);
            queue.In(2);
            MyPrint(queue);
            queue.In(3);
            MyPrint(queue);
            queue.In(4);
            MyPrint(queue);
            queue.In(5);
            MyPrint(queue);
            queue.Out();
            MyPrint(queue);
            queue.In(5);
            MyPrint(queue);
            queue.Out();
            MyPrint(queue);
            queue.In(6);
            MyPrint(queue);
        }
        private static void MyPrint(IQueue<int> queue)
        {
            Console.WriteLine();
            Console.WriteLine("***start***");
            queue.Print();
            Console.WriteLine("####end####");
        }
    }
}
