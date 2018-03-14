using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace deleteitems
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('b');
            q.Enqueue('c');
            q.Enqueue('e');
            Console.WriteLine("Current queue");

            foreach (char i in q)
            {
                Console.Write(i + "");
            }


        }
    }
}
