using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porto
{
    class Program
    {
        private static double postLengthPackage;
        private static double postLengthLetter;

        static void Main(string[] args)
        {
            byte postTypeByte = 0;
            bool postTypeBool = true;
            bool letterLengthBool = true;
            bool packageLengthBool = true;
            bool volumeBool = true;
            double priceOfMailService = 0;
            double weightPrice = 0;


            Console.WriteLine("Welcome to the big postoffice-Scam");
            #region Posttype
            while (postTypeBool)
            {
                Console.WriteLine("Please select letter or package");
                string postType = Console.ReadLine();
               

                switch (postType.ToLower())
                {
                    case "package":
                        postTypeByte = 1;
                        postTypeBool = false;
                        
                        break;


                    case "letter":
                        postTypeByte = 2;
                        postTypeBool = false;

                        break;
                }
            }
            #endregion
            //postTypeByte == 1 is for packages
            if (postTypeByte == 1)
            {   
            #region While-LengthPackage
                while (packageLengthBool)
                {
                    Console.WriteLine("Please input the length of the package in CM - max 150");
                    double.TryParse(Console.ReadLine(), out double postLengthPackage);
                    if (postLengthPackage == 0)
                    {
                        Console.WriteLine("Please input a number");
                        packageLengthBool = true;
                    }
                    else if (postLengthPackage < 150)
                    {

                        packageLengthBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Max length is 150 CM");
                    }


                }
#endregion

            }
            else
            {
                #region While-LengthLetter
                while (letterLengthBool)
                {
                    Console.WriteLine("Please input the length of the letter in CM - Max 60");
                    double.TryParse(Console.ReadLine(), out double postLengthLetter);
                    if (postLengthLetter == 0)
                    {
                        Console.WriteLine("Please input a number");
                        letterLengthBool = true;
                    }
                    else if (postLengthLetter < 60)
                    {

                        letterLengthBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Max length is 60 CM");
                    }


                }
                #endregion
            }
            #region postTypePackTotal
            if (postTypeByte == 1)
            {
                while (volumeBool)
                {
                    Console.WriteLine("Please input the height");
                    double postHeight = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please input the width");
                    double postWidth = double.Parse(Console.ReadLine());

                    double packageDia = postLengthPackage + postHeight + postWidth;
                    if (packageDia < 300)
                    {
                        volumeBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Volume must be beneath 300");
                    }


                }
            }
            #endregion

            #region postTypeLetTotal
            else
            {
                while (volumeBool)
                {
                    Console.WriteLine("Please input the height");
                    double postHeight = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please input the width");
                    double postWidth = double.Parse(Console.ReadLine());

                    double packageDia = postLengthLetter + postHeight + postWidth;

                    if (packageDia < 90)
                    {
                        volumeBool = false;
                    }
                    else
                    {
                        Console.WriteLine("Volume must be beneath 90");
                    }
                }
              
            }
            #endregion


            //brug denne if sætning til at vælge pakke eller brev og lav udregning af vægt
            


                Console.WriteLine("Input in grams the weight");
                Console.WriteLine("50g - 100g - 250g - 500g - 1000g - 2000g - 5000g - 10000g - 20000g");
                int postWeight = int.Parse(Console.ReadLine());
            
            switch (postWeight)
                {
                
                case 50:
                   weightPrice = 0 + 9;
                    break;
                case 100:
                    weightPrice = 0 + 18;
                    break;
                case 250:
                    weightPrice = 0 + 36;
                    break;
                case 500:
                    weightPrice = 0 + 45;
                    break;
                case 1000:
                    weightPrice = 0 + 54;
                    break;
                case 2000:
                    weightPrice = 0 + 54;
                    break;
                case 5000:
                    weightPrice = 0 + 60;
                    break;
                case 10000:
                    weightPrice = 0 + 94;
                    break;
                case 20000:
                    weightPrice = 0 + 150;
                    break;


            }

            Console.WriteLine("Type destination: 1 for Denmark, 2 for abroad");
            byte destinationInt = byte.Parse(Console.ReadLine());
     
            if (destinationInt == 1)
            {
                priceOfMailService = weightPrice;
            }
            else
            {
                priceOfMailService = weightPrice * 1.8;
            }
            Console.WriteLine("{0} DKK", priceOfMailService);




        }
    }
}
