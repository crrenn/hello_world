using System;
using System.Text.RegularExpressions;

namespace Vehicles {
    public class Vehicle{


        public Vehicle(string registration, string dateCreated){
            this.Created = DateTime.Parse(dateCreated);
            this.Registration = registration;
        }
        public DateTime Created { get; private set;}

   //     public string Registration {get; set;}
        private string registration;

          public string Registration {
              get {
                  return registration;
              }
              set{
                  if (!Regex.IsMatch(value, "[0-9]+")){
                      throw new ArgumentException($"{value} is not good, gimme something right");
                  }
                      this.registration = value;
              }
          }

        public int Age{
            get {
               return DateTime.Now.Year - Created.Year;
            }
        }

    }
}