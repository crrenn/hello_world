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
             garage.Add(new Vehicle("ABCD05" , "22.04.1970"));
             garage.Add(new Vehicle("z34th1" ,"1985-5-20"));
             garage.Add(new Vehicle("Jore55" ,"2004-1-13"));
            
            Console.WriteLine("garage contains :");
            foreach(var vehicle in garage){
                Console.WriteLine("built:" + vehicle.Created);
                Console.WriteLine("\n"+ vehicle.Age);
                Console.WriteLine("\n"+ vehicle.Registration);
            }
            var oldest_vehicle = garage.OrderByDescending(v => v.Age).First();

            Console.WriteLine(oldest_vehicle.Registration);
        }

        
    }
}
