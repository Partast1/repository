using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            

            int[] userNumbers = new int[8];

            for (int i = 0; i < userNumbers.Length -1; i++)
            {
                int userRandom = r.Next(1, 21);

                userNumbers[i] = userRandom;
                Console.Write(userNumbers[i]);
            }

            int[] lottoNumb = new int[8];

            for (int j = 0; j < lottoNumb.Length -1; j++)
            {
                int lottoRandom = r.Next(1, 21);

                lottoNumb[j] = lottoRandom;
                Console.WriteLine(lottoNumb[j]);


            }
            
        }
    }
}
