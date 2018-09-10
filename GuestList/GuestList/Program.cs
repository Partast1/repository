using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int menuInput = try.parse
           


            //string navn = new string< Guest >;
            Queue<Guest> guests = new Queue<Guest>();
            guests.Enqueue(new Guest("bo", 2));
           
            foreach (Guest itemShow in guests)
            {
                Console.WriteLine(itemShow.Name);
                Console.WriteLine(itemShow.Age);
            }
            Console.WriteLine("1 for tilføj");
            int menuInput = int.Parse(Console.ReadLine());
            switch (menuInput)
            {
                case 1:
                Console.WriteLine("Skriv navn");
                string addToqueueName = Console.ReadLine();
                Console.WriteLine("Skriv tal");
                int addToQueueAge = int.Parse(Console.ReadLine());

                foreach (Guest itemAdd in guests)
                {
                    guests.Enqueue(new Guest(addToqueueName, addToQueueAge));
                }
                break;

                case 2:
                Console.WriteLine("Delete items");
                break;

                case 3:
                Console.WriteLine("Show number of items");
                break;
                case 4:
                Console.WriteLine("Show min and max items");
                break;
                case 5:
                Console.WriteLine("Find an item");
                break;
                case 6:
                Console.WriteLine("Print all items");
                break;
                case 7:
                Console.WriteLine("Exit");
                break;
            }
        
            Console.ReadKey();
        }
    }
}
