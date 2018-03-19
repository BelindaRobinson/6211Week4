using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace displayitems
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Console.WriteLine("Please enter a name to add");
            string name = Console.ReadLine();
            string[] display = new string[20];
            
            foreach (char i in name)            
            {
                q.Enqueue(i);
            }
            foreach (char i in q)
            {
                q.ToArray(display);
            }
            Console.WriteLine(q.ToArray(display));
        
        }
    }
}
