using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morsekode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert text here for morse code");
            string morseConvert = Console.ReadLine();
            char[] morseArray = morseConvert.ToCharArray();
            StringBuilder morse = new StringBuilder();
            for (int i = 0; i < morseArray.Length; i++)
            {
                #region Longswitch
                switch (morseArray[i])
                {
                    case 'a':
                        Console.Write(".- ");
                        morse.Append(".- ");
                        break;
                    case 'b':
                        Console.Write("-... ");
                        morse.Append("-... ");
                        break;
                    case 'c':
                        Console.Write("-.-. ");
                        morse.Append("-.-. ");
                        break;
                    case 'd':
                        Console.Write("-.. ");
                        morse.Append("-.. ");
                        break;
                    case 'e':
                        Console.Write(". ");
                        morse.Append(". ");
                        break;
                    case 'f':
                        Console.Write("..- ");
                        morse.Append("..- ");
                        break;
                    case 'g':
                        Console.Write("--. ");
                        morse.Append("--. ");
                        break;
                    case 'h':
                        Console.Write(".... ");
                        morse.Append(".... ");
                        break;
                    case 'i':
                        Console.Write(".. ");
                        morse.Append(".. ");
                        break;
                    case 'j':
                        Console.Write(".--- ");
                        morse.Append(".--- ");
                        break;
                    case 'k':
                        Console.Write("-.- ");
                        morse.Append("-.- ");
                        break;
                    case 'l':
                        Console.Write(".-.. ");
                        morse.Append(".-.. ");
                        break;
                    case 'm':
                        Console.Write("-- ");
                        morse.Append(".-");
                        break;
                    case 'n':
                        Console.Write("-. ");
                        morse.Append("-. ");
                        break;
                    case 'o':
                        Console.Write("--- ");
                        morse.Append("--- ");
                        break;
                    case 'p':
                        Console.Write(".--. ");
                        morse.Append(".--. ");
                        break;
                    case 'q':
                        Console.Write("--.- ");
                        morse.Append("--.- ");
                        break;
                    case 'r':
                        Console.Write(".-. ");
                        morse.Append(".-. ");
                        break;
                    case 's':
                        Console.Write("... ");
                        morse.Append("... ");
                        break;
                    case 't':
                        Console.Write("- ");
                        morse.Append("- ");
                        break;
                    case 'u':
                        Console.Write("..- ");
                        morse.Append("..- ");
                        break;
                    case 'v':
                        Console.Write("...- ");
                        morse.Append("...- ");
                        break;
                    case 'w':
                        Console.Write(".-- ");
                        morse.Append(".-- ");
                        break;
                    case 'x':
                        Console.Write("-..- ");
                        morse.Append("-..- ");
                        break;
                    case 'y':
                        Console.Write("-.-- ");
                        morse.Append("-.-- ");
                        break;
                    case 'z':
                        Console.Write("--.. ");
                        morse.Append("--.. ");
                        break;
                    case 'æ':
                        Console.Write(".-.- ");
                        morse.Append(".-.- ");
                        break;
                    case 'ø':
                        Console.Write("---. ");
                        morse.Append("---. ");
                        break;
                    case 'å':
                        Console.Write(".--.- ");
                        morse.Append(".--.- ");
                        break;
                    default:
                        Console.Write(" ");
                        
                        break;
                }
                #endregion

            }
            
            
            Console.WriteLine(morse);



        }
    }
}
