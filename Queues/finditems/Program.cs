using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace finditems
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

            Console.WriteLine("Please enter a character to check if it in your name");
            string charactor = Console.ReadLine();

            foreach (var i in charactor) // true value == true only works for numbers
            {
                q.Contains(i);
            }

            Console.WriteLine(q.Contains(charactor));

        }
    }
}
