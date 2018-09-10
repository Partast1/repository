using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods_files
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Creates one Folder
            //Directory.CreateDirectory(@".\Droids");
            ////Creates two subfolders
            //Directory.CreateDirectory(@".\Droids\Astromech");
            //Directory.CreateDirectory(@".\Droids\Protocol");
            ////Creates two text files with some text
            //File.WriteAllText(@".\Droids\Astromech\r2d2.text", "beep beep");
            //File.WriteAllText(@".\Droids\Protocol\C3p0.text", "Sir");
            ////displays all files
            //foreach (string file in Directory.GetFiles(@".\"))
            //{
            //    Console.WriteLine(file);
            //}
            //Console.Read();

            using (var writer = new StreamWriter(
                new FileStream(@".\StarWars.txt", FileMode.Create)))
            {
                writer.Write("Beep boop!");
            }
            using (var reader = new StreamReader (
                new FileStream(@".\StarWars.txt", FileMode.Open)))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
