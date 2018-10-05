using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automaten
{
    class Program
    {
        static void Main(string[] args)
        {
            bool whileboolPro = true;
            Softdrinks sele = new Softdrinks();

            Currency MoneyObj = new Currency();
            //get currency to softdrinks and Snack

            while (whileboolPro == true)
            {
                Console.WriteLine("Welcome to the vending machine");
                Console.WriteLine();
                Console.WriteLine("Amount of money {0}", MoneyObj.Money);
                Console.WriteLine();
                Console.WriteLine("Press: 1. input money. - 2. Snack machine. - 3. Softdrink machine. - 4. Exit.");
                int machineSelect = int.Parse(Console.ReadLine());





                switch (machineSelect)
                {
                    case 1:
                        Console.WriteLine("Choose amount of money to put in");
                        MoneyObj.AddCurrency();
                        
                        Thread.Sleep(1000);
                        Console.WriteLine("{0} have been added", MoneyObj.Money);
                        
                        Console.Clear();
                        break;

                    case 2:

                        break;
                    case 3:
                        sele.SoftMethod(MoneyObj.Money);
                        break;

                    case 4:
                        //Checkout function

                        Console.Clear();
                        Console.WriteLine("Calculating...");
                        Thread.Sleep(2500);
                        Console.Clear();

                        //Foreach loop displays Cartlist (items bought)
                     
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your change is {0}", MoneyObj.Money);
                        Console.ForegroundColor = ConsoleColor.White;
                        whileboolPro = false;


                        break;

                }
            }
            Automat auto = new Automat();
            auto.Snackautomat();


        }
        public void Cartlist(int cartindex)
        {
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
            foreach (Product cartItem in cartList)
            {
                Console.WriteLine("Product: {0} - Products left: {1}", cartItem.ProName, cartItem.ProQuantity);
                cartList[cartindex].ProQuantity++;
            }


        }
    }
}
