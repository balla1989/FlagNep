using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 2; h++)
            {
                for (int i = 0; i <10; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                        Console.Write("   ");

                    }
                    Console.WriteLine("\n");

                }
            }
           
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
