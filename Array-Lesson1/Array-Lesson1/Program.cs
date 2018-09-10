using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNameArray = { "jens", "hans", "bo", "ulla", "helle" };
            string[] passWordArray = { "123", "1234", "12", "ulla12", "helle123" };
            int j = 0;

            Console.WriteLine("Login system");
          

            while (j < 3)
            {
              
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter username");
                    string userName = Console.ReadLine();

                    Console.WriteLine("Enter password");
                    string passWord = Console.ReadLine();

                    if (userName.ToLower() == userNameArray[i].ToLower() && passWord.ToLower() == passWordArray[i].ToLower())
                    {
                        Console.WriteLine("Login successful");
                        Console.WriteLine("Welcome");
                        i = 5;
                        j = 3;
                    }
                    else
                    {

                        Console.WriteLine("Username or password is incorrect");
                    }
                    j++;
                

                }

            }
        }
    }
}