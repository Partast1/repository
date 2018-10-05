using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Snack
    {
        static void Snacks(string[] args)
        {
            bool SnackBool = true;
            Currency MoneyObj = new Currency();


            List<Product> proListe = new List<Product>();

            //creates new objects to put into the list
            Product doritos = new Product("doritos", 18, 10);
            Product liquorice = new Product("liquorice", 23, 2);
            Product oreo = new Product("oreo", 21, 5);
            Product hCandy = new Product("king of Denmark", 19, 5);

            //Addes all the item to product list.
            proListe.Add(doritos);
            proListe.Add(liquorice);
            proListe.Add(oreo);
            proListe.Add(hCandy);

            while (SnackBool == true)
            {
                Console.WriteLine("1. Select soda - 2.back");
                int inputSelection = int.Parse(Console.ReadLine());

                switch (inputSelection)
                {
                    //Insert money function
                    case 1:
                        Console.Clear();
                        int index = 0;
                        Console.WriteLine("You have: {0}$", MoneyObj.Money);
                        Console.WriteLine();

                        //Foreach loop is used to display ever item in productlist
                        foreach (Product item in proListe)
                        {

                            Console.WriteLine("{0} Product: {1} - Price of Product: {2}$ - Products left: {3}", index, item.ProName, item.ProPrice, item.ProQuantity);
                            index++;
                        }
                        //Index is used as an indicator for product selection
                        int selectinput = int.Parse(Console.ReadLine());

                        //If statement used to determine if there is sufficient funds
                        if (proListe[selectinput].ProPrice < MoneyObj.Money)
                        {
                            Console.Clear();

                            //If statement makes sure there still is products left
                            if (proListe[selectinput].ProQuantity > 0)
                            {
                                MoneyObj.SubtractCurrency(proListe[selectinput].ProPrice);
                                //Products are removed from Product list and put into Cart list
                                proListe[selectinput].ProQuantity--;



                            }
                            else
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Out of stock");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                            }


                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Not enough money");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
                        }
                        break;

                    //Select product function

                    case 2:
                        SnackBool = false;
                        break;
                }
            }
        }
      
    }
}
