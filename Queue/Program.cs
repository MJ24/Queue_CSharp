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
            //IQueue<int> queue = new CSeqQueue<int>(4);
            CSeqQueue<int> queue = new CSeqQueue<int>(4);
            queue.Out();
            queue.In(1);
            queue.In(2);
            queue.In(3);
            queue.In(4);
            queue.In(5);
            queue.Out();
            queue.In(5);
            queue.Out();
            queue.In(6);
        }
    }
}
