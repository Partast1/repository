using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libaryfree
{
    class Program
    {
        static void Main(string[] args)
        {

            bool whilellopbool = true;
            //create new list of books
            List<Book> listedBooks = new List<Book>();
            //Create new books
            Book bogen = new Book("hans jensen", 192, "Bogen", 185229);
            Book Hans = new Book("Ole petersen", 204, "Hans og grete", 752810);
            Book lotr = new Book("tolken", 364, "Lord of the rings 1", 942018);
            Book lotr2 = new Book("tolken", 327, "Lord of the rings 2", 942019);
            Book lotr3 = new Book("tolken", 401, "Lord of the rings 3", 942020);
            listedBooks.Add(bogen);
            listedBooks.Add(Hans);
            listedBooks.Add(lotr);
            listedBooks.Add(lotr2);
            listedBooks.Add(lotr3);

            Stack<Book> pendingList = new Stack<Book>();

            while (whilellopbool == true)
            {
                int index = 0;
                Console.WriteLine("Available libary books");
                foreach (Book bookItem in listedBooks)
                {

                    Console.WriteLine("Index: {0} -- Author of book: {1} Length of book: {2} Titel of book: {3} Id = {4}", index, bookItem.Author, bookItem.PageCount, bookItem.Titel, bookItem.Id);
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine("1. for choose books to lent - 2. check out - 3. exit");
                Console.WriteLine();
                foreach (Book pendItem in pendingList)
                {
                    Console.WriteLine("Pending books");
                    Console.WriteLine("Author of book: {0} Length of book: {1} Titel of book: {2} Id = {3}", pendItem.Author, pendItem.PageCount, pendItem.Titel, pendItem.Id);

                }

                //Input to switch statement & switch
                int choiceInput = int.Parse(Console.ReadLine());
                switch (choiceInput)
                {
                    case 1:
                    Console.WriteLine("Type input on book you want to lent");


                    int bookindex = int.Parse(Console.ReadLine());

                    //choiceInput = index;
                    pendingList.Push(listedBooks[bookindex]);
                    listedBooks.RemoveAt(bookindex);

                    Console.Clear();
                    //throw exception if index is out of bounds                  

                    break;

                    case 2:

                    while (pendingList.Count > 0)
                    {
                        pendingList.Peek();
                        Console.WriteLine(pendingList.Pop());

                    }



                    break;

                    case 3:
                    whilellopbool = false;
                    break;
                }
            }
        }
    }
}
