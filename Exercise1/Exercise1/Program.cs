using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack a = new Stack();

            Console.WriteLine("Please enter name");

            string name = Console.ReadLine();

            foreach (char i in name)
            {
                a.Push(i);
            }

            foreach (char i in a)
            {
                Console.Write(i);
            }

            Console.ReadLine();

            Stack b = new Stack();

            b.Push('B');
            b.Push('E');
            b.Push('E');

            foreach(char c in b)
            {
                Console.Write(c + "");
            }


        }
    }
}
