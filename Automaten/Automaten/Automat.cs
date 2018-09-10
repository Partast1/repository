using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automaten
{
    public class Automat
    {


        #region Snack
        public void Snackautomat()
        {
            bool whilebool = true;
            Currency MoneyObj = new Currency();
            Product ProObj = new Product();

            #region listtown

            //Created a new list.
            List<Product> proListe = new List<Product>();

            //creates new objects to put into the list
            Product doritos = new Product("doritos", 18, 10);
            Product liquorice = new Product("liquorice", 23, 2);
            Product oreo = new Product("oreo", 21, 5);
            Product hCandy = new Product("king of Denmark", 19, 5);
            Product sCola = new Product("small Coca Cola", 15, 7);
            Product lCola = new Product("large Coca Cola", 28, 5);
            Product icetea = new Product("nestea", 14, 3);
            Product cocio = new Product("Cocio", 17, 3);

            //Addes all the item to product list.
            proListe.Add(doritos);
            proListe.Add(liquorice);
            proListe.Add(oreo);
            proListe.Add(hCandy);
            proListe.Add(sCola);
            proListe.Add(lCola);
            proListe.Add(icetea);
            proListe.Add(cocio);

            //Cartlist for prepurchased products
            List<Product> cartList = new List<Product>();
            Product cartdoritos = new Product("doritos", 18, 0);
            Product cartliquorice = new Product("liquorice", 23, 0);
            Product cartoreo = new Product("oreo", 21, 0);
            Product carthCandy = new Product("king of Denmark", 19, 0);
            Product cartsCola = new Product("small Coca Cola", 15, 0);
            Product cartlCola = new Product("large Coca Cola", 28, 0);
            Product carticetea = new Product("nestea", 14, 0);
            Product cartcocio = new Product("Cocio", 17, 0);

            //Addes all the item to cart list.
            cartList.Add(cartdoritos);
            cartList.Add(cartliquorice);
            cartList.Add(cartoreo);
            cartList.Add(carthCandy);
            cartList.Add(cartsCola);
            cartList.Add(cartlCola);
            cartList.Add(carticetea);
            cartList.Add(cartcocio);
            #endregion

            #region While
            //Whileloop to show, insert money & payout money/products
            while (whilebool == true)
            {
                //Displays list over pricing, products & quantity of products
                Console.WriteLine("Shopping cart:");
                Console.WriteLine("{0} chips Price: {1} Quantity: {2}", doritos.ProName, doritos.ProPrice, doritos.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", liquorice.ProName, liquorice.ProPrice, liquorice.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", oreo.ProName, oreo.ProPrice, oreo.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", hCandy.ProName, hCandy.ProPrice, hCandy.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", sCola.ProName, sCola.ProPrice, sCola.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", lCola.ProName, lCola.ProPrice, lCola.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", icetea.ProName, icetea.ProPrice, icetea.ProQuantity);
                Console.WriteLine("{0} Price: {1} Quantity: {2}", cocio.ProName, cocio.ProPrice, cocio.ProQuantity);

                Console.WriteLine();
                Console.WriteLine("You have: {0}$", MoneyObj.Money);
                Console.WriteLine();
                
                //Selection of function

                Console.WriteLine("1. Insert money - 2. Select Products - 3. CheckOut.");
                int inputSelection = int.Parse(Console.ReadLine());

                switch (inputSelection)
                {
                    //Insert money function
                    case 1:
                    Console.WriteLine("Choose amount of money to put in");
                    MoneyObj.AddCurrency();
                    Thread.Sleep(1000);
                    Console.WriteLine("{0} have been added", MoneyObj.Money);
                    Console.Clear();
                    break;

                    //Select product function
                    #region Case Two
                    case 2:
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
                            cartList[selectinput].ProQuantity++;

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
                    #endregion

                    //Checkout function
                    case 3:
                    Console.Clear();
                    Console.WriteLine("Calculating...");
                    Thread.Sleep(2500);
                    Console.Clear();

                    //Foreach loop displays Cartlist (items bought)
                    foreach (Product cartItem in cartList)
                    {
                        Console.WriteLine("Product: {0} - Products left: {1}", cartItem.ProName, cartItem.ProQuantity);

                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your change is {0}", MoneyObj.Money);
                    Console.ForegroundColor = ConsoleColor.White;
                    whilebool = false;
                    break;
                }

            }
            #endregion

            Console.Read();


        }
        #endregion

       

    }
}
