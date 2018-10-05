using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Softdrinks
    {
      
        public void SoftMethod(int money)
        {

            bool softbool = true;
            //Created a new list.
            Currency MoneyObj = new Currency();
            Program newProgram = new Program();
            List<Product> proListeSD = new List<Product>();

            //creates new objects to put into the list

            Product sCola = new Product("small Coca Cola", 15, 7);
            Product lCola = new Product("large Coca Cola", 28, 5);
            Product icetea = new Product("nestea", 14, 3);
            Product cocio = new Product("Cocio", 17, 3);

            //Addes all the item to product list.

            proListeSD.Add(sCola);
            proListeSD.Add(lCola);
            proListeSD.Add(icetea);
            proListeSD.Add(cocio);

            Console.WriteLine("{0} Price: {1} Quantity: {2}", sCola.ProName, sCola.ProPrice, sCola.ProQuantity);
            Console.WriteLine("{0} Price: {1} Quantity: {2}", lCola.ProName, lCola.ProPrice, lCola.ProQuantity);
            Console.WriteLine("{0} Price: {1} Quantity: {2}", icetea.ProName, icetea.ProPrice, icetea.ProQuantity);
            Console.WriteLine("{0} Price: {1} Quantity: {2}", cocio.ProName, cocio.ProPrice, cocio.ProQuantity);

            Console.WriteLine();
            Console.WriteLine("You have: {0}$", MoneyObj.Money);
            Console.WriteLine();
            while (softbool == true)
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
                        foreach (Product item in proListeSD)
                        {

                            Console.WriteLine("{0} Product: {1} - Price of Product: {2}$ - Products left: {3}", index, item.ProName, item.ProPrice, item.ProQuantity);
                            index++;
                        }
                        //Index is used as an indicator for product selection
                        int selectinput = int.Parse(Console.ReadLine());

                        //If statement used to determine if there is sufficient funds
                        if (proListeSD[selectinput].ProPrice < MoneyObj.Money)
                        {
                            Console.Clear();

                            //If statement makes sure there still is products left
                            if (proListeSD[selectinput].ProQuantity > 0)
                            {
                                MoneyObj.SubtractCurrency(proListeSD[selectinput].ProPrice);
                                //Products are removed from Product list and put into Cart list
                                proListeSD[selectinput].ProQuantity--;
                               
                                newProgram.Cartlist(selectinput);



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
                        softbool = false;
                        break;
                }
             
            }
        }
    
        
    }
}
