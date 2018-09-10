using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool lentouttest = new bool();
            Book Boollent = new Book();
            Boollent.LentOut = false;
            Book titelBook = new Book();
            List<Book> LibraryBooks = new List<Book>();
            Book Necronomicon = new Book("testbog", 108, "Bo Olesen", true, false);
            Book Anarchist = new Book("kogebog", 205, "Helle Hansen", false, true);
            Book Satanic = new Book("bogen", 350, "Bente", true, false);
            Book Fritzl = new Book("kodebog", 204, "Bill gates", true, false);
            LibraryBooks.Add(Necronomicon);
            LibraryBooks.Add(Anarchist);
            LibraryBooks.Add(Satanic);
            LibraryBooks.Add(Fritzl);

            Stack<Book> lentingStack = new Stack<Book>();

            Console.WriteLine("Welcome to the library");
            Console.WriteLine("Choose a book to loan: (1). testbog(2). kogebog(3). bogen(4). kodebog");
            foreach (Book Books in LibraryBooks)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(Books.Titel);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Books.PageCount);
                Console.WriteLine(Books.Author);
                Console.WriteLine(Books.HardCover);
                if (Boollent.LentOut == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Boollent.LentOut);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Boollent.LentOut);
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            Console.ReadKey();
            string Choosebook = (Console.ReadLine());

            foreach (Book item in LibraryBooks)
            {
                if (Choosebook.ToLower() == titelBook.Titel )
                {
                    lentingStack.Push(item);
                }
               


            }
            Console.ReadKey();

            //foreach (Book itemStack in lentingStack)
            //{
            //    string topOfStack = lentingStack.Pop(itemStack);
            //    Console.WriteLine(lentingStack[itemStack]);
            //}

           
        }
    }
}
