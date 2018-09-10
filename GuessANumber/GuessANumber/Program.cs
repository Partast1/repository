using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random RandomSecret = new Random();
            // a random number from 1-100
            int secretNumber = RandomSecret.Next(1, 101);
           
         

         
            // The for loop is designed to allow 4 tries
            for (int i = 0; i < 4; i++)
            {
                //At each try a new user input is required, input is a variable of the type int.
                Console.Write("Gæt et tal ");
                int guess = int.Parse(Console.ReadLine());
                //If the guessed number is either lower or higher than the secretnumber, the for loop resets.
                if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                //If the right number is guessed the loop stops and the game is won.
                else if (guess == secretNumber)
                {
                    Console.WriteLine("YOU WON!!!!");
                    break;
                }
              


            }
            //If the number is not guessed within 4 tries the secret number is revealed 
            Console.WriteLine("Det rigtige tal var {0} du tabte",secretNumber);
            



        }
    }
}
