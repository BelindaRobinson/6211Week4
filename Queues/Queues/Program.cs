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

        static void Main(string[] args)       
        {
            menu();                       
        }

        static void menu()
        {
            var menuchoice = '0';
            
            while (menuchoice == '0')
            {
                Console.Write(new string('\n', 8));
                Console.WriteLine("Please select a topic");
                Console.WriteLine(new string('\n', 2));
                Console.WriteLine("1. add items");
                Console.WriteLine("2. delete items");
                Console.WriteLine("3. display items");
                Console.WriteLine("4. find items");
                Console.WriteLine("5. show number of items");
                menuchoice = Console.ReadKey(false).KeyChar;

                switch (menuchoice)
                {
                    case '1':
                        additems();
                        menuchoice = '0';
                        break;

                    case '2':
                        deleteitems();
                        menuchoice = '0';
                        break;

                    case '3':
                        displayitems();
                        menuchoice = '0';
                        break;

                    case '4':
                        finditems();
                        menuchoice = '0';
                        break;

                    case '5':
                        shownumberitems();
                        menuchoice = '0';
                        break;
                                            
                }
            }
        }

        static void additems()
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

        static void deleteitems()
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

        static void displayitems()
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
                //q.ToArray(display);
            }
            //Console.WriteLine(q.ToArray(display));
        }

        static void finditems()
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

        static void shownumberitems()
        {

        }
    }
}
