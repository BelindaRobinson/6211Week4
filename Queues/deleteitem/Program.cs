﻿using System;
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
            Console.WriteLine("Please enter a name to add");
            string name = Console.ReadLine();

            foreach (char i in name)
            {
                q.Enqueue(i);
            }
          
            Console.WriteLine("Now the following letter will be removed from your name");
            char ch = (char)q.Dequeue();
            Console.WriteLine(ch);
            
        }
    }
}
