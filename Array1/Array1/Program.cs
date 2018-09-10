using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] ArrayOne = new int[9];
            for (int i = 0; i < 9; i++)
            {
                ArrayOne[i] = i + 1 ;
            }
            for(int j = 0; j < 9; j++ )
            {
               Console.WriteLine("Array {0} index = {1}", j, ArrayOne[j]);
            }

            for (int i = 5; i < 6; i++)
            {
                ArrayOne[i] = i * 2;
                Console.WriteLine("Index 5 = {0}", ArrayOne[i]);
            }
          
            
            Console.ReadKey();
        }
    }
}
