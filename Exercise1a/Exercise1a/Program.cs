using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercise1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack a = new Stack(); //can go in class program and can be called thought the whole program
            stack1(a);
            stack1(a);
        }

        static void stack1(Stack a)

        {
            

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
        }

        
            
    }

        

    
}
