using System;
using System.Collections.Generic;
using Vehicles;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var garage = new List <Vehicle>();
             garage.Add(new Vehicle("ABCD05" , "22.04.1970", "bob"));
             garage.Add(new Vehicle("z34th1" ,"1985-5-20", "tommy"));
             garage.Add(new Vehicle("Jore55" ,"2004-1-13", "arthur"));
             garage.Add(new Vehicle ("wer45" , "1966-01-09", "clarice"));
            
            Console.WriteLine("garage contains :");
            foreach(var vehicle in garage){
                Console.WriteLine("built:" + vehicle.Created);
                Console.WriteLine("\n"+ vehicle.Age);
                Console.WriteLine("\n"+ vehicle.Registration);
            }
            var oldest_vehicle = garage.OrderByDescending(v => v.Age).First();

            Console.WriteLine("\n\n Oldest vehicle is " + oldest_vehicle.Registration);
           Console.WriteLine("\n\n Oldest vehicle name is " + oldest_vehicle.Name);

                       var newest_vehicle = garage.OrderByDescending(v2 => v2.Age).Last();

            Console.WriteLine("\n\n Newest vehicle is " + newest_vehicle.Registration);
           Console.WriteLine("\r Newest vehicle name is " + newest_vehicle.Name);
        }

        
    }
}
