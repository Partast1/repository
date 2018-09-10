using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            //A new instance of the class 'Square' is initialized
            Square firkant = new Square();
           

            Console.WriteLine("indtast tal");
           
            int input = int.Parse(Console.ReadLine());

            int Arealsum = firkant.Arealet(input);
            int Kvadratsum = firkant.Omkreds(input);
            Console.WriteLine("Arealet af firkanten er {0}", Arealsum);
            Console.WriteLine("Kvadrat af firkanten er {0}", Kvadratsum);
            Console.ReadKey();
            



        }
    }
}
