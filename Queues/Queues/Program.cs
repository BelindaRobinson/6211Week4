using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queues
{
    class Program
    {
        static Queue q2 = new Queue();
        static void Main(string[] args)
        {
            Queue q = new Queue();
            menu(q);            
        }

        static void menu(Queue q)
        {
            string menuchoice = "0";
            
            while (menuchoice == "0")
            {
                Console.WriteLine("Please select a topic");
                Console.WriteLine("1. add items");
                Console.WriteLine("2. delete items");
                Console.WriteLine("3. display items");
                Console.WriteLine("4. find items");
                Console.WriteLine("5. show number of items");

                menuchoice = Console.ReadLine();

                switch (menuchoice)
                {
                    case "1":
                        additems(q);
                        menuchoice = "0";
                        break;

                    case "2":
                        deleteitems(q);
                        menuchoice ="0";
                        break;

                    case "3":
                        displayitems(q);
                        menuchoice = "0";
                        break;

                    case "4":
                        finditems(q);
                        menuchoice = "0";
                        break;

                    case "5":
                        shownumberitems(q);
                        menuchoice = "0";
                        break;
                                            
                }
            }
        }

        static void additems(Queue q)
        {
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

        static void deleteitems(Queue q)
        {
           
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

        static void displayitems(Queue q)
        {
            
            Console.WriteLine("Please enter a name to add");
            string name = Console.ReadLine();
            string[] display = new string[20];

            foreach (char i in name)
            {
                q.Enqueue(i);
            }
            
        }

        static void finditems(Queue q)
        {
            
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

        static void shownumberitems(Queue q)
        {

        }
    }
}
