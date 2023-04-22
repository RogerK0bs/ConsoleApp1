#define Test
using System;
using System.Linq;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #if Test
            string name;
            String name_2;
            name=Console.ReadLine();
            System.Console.WriteLine("Привет " + name);
            name_2 =Console.ReadLine();
            Console.WriteLine("#2 Hello "+ name_2);
            #endif
            Console.ReadKey();
        }
    }
}
