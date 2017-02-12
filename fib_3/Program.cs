using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i =0;
            int j = 0;
            for(int counter=0; counter <100; counter++){
                i = i+1;
                j = j-1;

            }
            Console.WriteLine(i);
            Console.WriteLine("\n\n"+ j);
        }
    }
}
