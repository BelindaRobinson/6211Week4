using System;
using System.Collections;

namespace additems
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            Console.WriteLine("Please enter a name to add");
            string name = Console.ReadLine();

            foreach (char i in name)
            {
                q.Enqueue(i);
            }
            foreach (char i in q)
            {
                Console.Write(i);
            }
        }        
    }
}
