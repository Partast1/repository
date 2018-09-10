using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liste over planeter, alle værdierne angives her. Alle properties bliver sendt over via constructoren i class'en

            //TEST TEST
            List<Planet> planets = new List<Planet>();
            Planet Mercury = new Planet("Mercury", 0.330, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88.0, 47.4, 167, 0, false);
            Planet Earth = new Planet("Earth", 5.97, 12.754, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet Mars = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet Jupiter = new Planet("Jupiter", 1898, 142.534, 1325, 23.1, 9.9, 9.9, 778.9, 4331, 13.1, -110, 67, true);
            Planet Saturn = new Planet("Saturn", 596, 120.514, 687, 9.1, 10.7, 10.7, 1433.9, 10.747, 9.7, -140, 62, true);
            Planet Uranus = new Planet("Uranus", 86.5, 51.14, 2137, 8.4, -17.2, 17.2, 2833.9, 30.247, 6.4, -195, 27, true);
            Planet Neptune = new Planet("Neptune", 102, 52.14, 1637, 11.4, 16.2, 16.2, 4483.9, 59.2, 5.4, -200, 14, true);
            Planet Pluto = new Planet("Pluto", 0.015, 2370, 2095, 0.7, -150.2, 150.2, 5981.6, 90.2, 4.7, -225, 5, true);
            Planet Venus = new Planet("Venus", 4.87, 12.104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            //Her tilføjes alle planeterne til listen
            planets.Add(Mercury);
            planets.Add(Earth);
            planets.Add(Mars);
            planets.Add(Jupiter);
            planets.Add(Saturn);
            planets.Add(Uranus);
            planets.Add(Neptune);
            planets.Add(Pluto);
            //Insert bruges til at sætte et list item ind et specielt sted i listen, her er det på index 1
            planets.Insert(1, Venus);

            planets.RemoveAt(8);
            planets.Insert(8, Pluto);
            Console.WriteLine("Der er {0} planeter i listen",planets.Count());

            //temp liste
            List<Planet> planetstemp = new List<Planet>();
           
            Planet MarsTemp = new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687.0, 24.1, -65, 2, false);
            Planet JupiterTemp = new Planet("Jupiter", 1898, 142.534, 1325, 23.1, 9.9, 9.9, 778.9, 4331, 13.1, -110, 67, true);
            Planet SaturnTemp = new Planet("Saturn", 596, 120.514, 687, 9.1, 10.7, 10.7, 1433.9, 10.747, 9.7, -140, 62, true);
            Planet UranusTemp = new Planet("Uranus", 86.5, 51.14, 2137, 8.4, -17.2, 17.2, 2833.9, 30.247, 6.4, -195, 27, true);
            Planet NeptuneTemp = new Planet("Neptune", 102, 52.14, 1637, 11.4, 16.2, 16.2, 4483.9, 59.2, 5.4, -200, 14, true);
            Planet PlutoTemp = new Planet("Pluto", 0.015, 2370, 2095, 0.7, -150.2, 150.2, 5981.6, 90.2, 4.7, -225, 5, true);
            planetstemp.Add(MarsTemp);
            planetstemp.Add(JupiterTemp);
            planetstemp.Add(SaturnTemp);
            planetstemp.Add(UranusTemp);
            planetstemp.Add(NeptuneTemp);
            planetstemp.Add(PlutoTemp);

            List<Planet> planetsDia = new List<Planet>();

            Planet VenusDia = new Planet("Venus", 4.87, 12.104, 5243, 8.9, -5832.5, 2802.0, 108.2, 224.7, 35.0, 464, 0, false);
            Planet EarthDia = new Planet("Earth", 5.97, 12.754, 5514, 9.8, 23.9, 24.0, 149.6, 365.2, 29.8, 15, 1, false);
            Planet NeptuneDia = new Planet("Neptune", 102, 52.14, 1637, 11.4, 16.2, 16.2, 4483.9, 59.2, 5.4, -200, 14, true);
            planetsDia.Add(VenusDia);
            planetsDia.Add(EarthDia);
            planetsDia.Add(NeptuneDia);
            //Listen's navn.Clear kan brugs til at slette listen
            planetsDia.Clear();

            //Venus Earth neptune


            //foreach statementen bruges til at gå listen igennem og udskrive alle værdierne
            foreach (Planet item in planets)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(item.PlanetName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item.Mass);
                Console.WriteLine(item.Diameter);
                Console.WriteLine(item.Density);
                Console.WriteLine(item.RotatePeriod);
                Console.WriteLine(item.LengthDay);
                Console.WriteLine(item.DistenceSun);
                Console.WriteLine(item.OrbitalPeriod);
                Console.WriteLine(item.OrbitalVelocity);
                Console.WriteLine(item.MeanTemp);
                Console.WriteLine(item.NumberOfMoons);
                Console.WriteLine(item.RingSystem);
                Console.WriteLine("");
            }
            Console.WriteLine("Disse planeter har en Mean temp under 0");
            foreach (Planet items in planetstemp)
            {
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(items.PlanetName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(items.Mass);
                Console.WriteLine(items.Diameter);
                Console.WriteLine(items.Density);
                Console.WriteLine(items.RotatePeriod);
                Console.WriteLine(items.LengthDay);
                Console.WriteLine(items.DistenceSun);
                Console.WriteLine(items.OrbitalPeriod);
                Console.WriteLine(items.OrbitalVelocity);
                Console.WriteLine(items.MeanTemp);
                Console.WriteLine(items.NumberOfMoons);
                Console.WriteLine(items.RingSystem);
                Console.WriteLine("");

            }
            Console.WriteLine("Disse planeter har en diameter mellem 10k og 50k");
            foreach (Planet itemDia in planetsDia)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(itemDia.PlanetName);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(itemDia.Mass);
                Console.WriteLine(itemDia.Diameter);
                Console.WriteLine(itemDia.Density);
                Console.WriteLine(itemDia.RotatePeriod);
                Console.WriteLine(itemDia.LengthDay);
                Console.WriteLine(itemDia.DistenceSun);
                Console.WriteLine(itemDia.OrbitalPeriod);
                Console.WriteLine(itemDia.OrbitalVelocity);
                Console.WriteLine(itemDia.MeanTemp);
                Console.WriteLine(itemDia.NumberOfMoons);
                Console.WriteLine(itemDia.RingSystem);
                Console.WriteLine("");
            }


            //planets.Add(Venus);
            Console.Read();

            //string input = Console.ReadLine();
            //switch(input.ToLower())
            //{
            //    case ""
            //}


        }
    }
}
