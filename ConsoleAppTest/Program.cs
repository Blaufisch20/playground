using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Xml.Schema;
namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[]args)
        {

            string testzahl = Console.ReadLine();
            int testzahl1 = int.Parse(testzahl);
            bool tester = false;

            if (testzahl1 < 5 || testzahl1 > 10)
            {
                Console.WriteLine(" die zahl ist niedriger als 5 oder höher als 10");
            }
            else
            {
                Console.WriteLine("die zahl ist zwischen 5 und 10");  
                tester = true;
            }

            if (testzahl1 >= 1 && testzahl1 <= 10)
            {
                Console.WriteLine("die zahl ist zwischen 1 und 10");
            }
            else
            {
                Console.WriteLine("die zahl ist nicht zwischen 1 und 10");
            }


            if (!tester)
            {
                Console.WriteLine("tester ist true");
            }
            else
            {
                Console.WriteLine("tester ist false");
            }
            string tessstzahl = Console.ReadLine();
            int tesst2 = int.Parse(tessstzahl);
 

            if (tesst2 == 2)
            {
                Console.WriteLine("tessstzahl ist gleich 2");

            }
            else
            {
                Console.WriteLine("testzahl ist nicht gleich 2");
            }
        }
    }
}


