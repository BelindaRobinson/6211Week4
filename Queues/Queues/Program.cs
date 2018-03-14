using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("Pick a Queue");
                Console.Write(new string('\n', 2));              
                Console.WriteLine("1. Add items");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Find an item");
                Console.WriteLine("5. Display all of the items");
                Console.WriteLine("6. Exit");
                menuchoice = Console.ReadKey(false).KeyChar;

                //switch (menuchoice)
                //{
                //    case '1':
                //        Pick();
                //        menuchoice = '0';

                //}
            }
        }
    }
}
