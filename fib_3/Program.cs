using System;
using System.Collections;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i =0;
            int j = 0;
            // for(int counter=0; counter <100; counter++){
            //     i = i+1;
            //     j = j-1;

            // }
            var counter = Enumerable.Range(1, 1000).Where(n=>!IsPrime(n));
            Console.WriteLine(i);
         //   Console.WriteLine("\nPlease enter in a number\n\n");
       //     var input = Console.ReadLine();
       foreach(var number in counter){
           Console.WriteLine(number);
       }
//            var forshow = IsPrime(counter[i]);
  //          Console.WriteLine(forshow);
        }

        private static bool IsPrime(int number){
            var value = 0;
            if (number%2== 0 && number%3==0 && number%5 ==0){
                return false;
            }
            else{
                return true;
            }
            
        }
    }
}
