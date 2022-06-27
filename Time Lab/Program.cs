using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time();
            Console.Write("Time created with constructor that has no arguments.\n" +
                $"Universal time is {time1.toUniversalString()}\n" +
                $"Standard time is {time1.ToString()}\n\n");

            Time time2 = new Time(3, 20, 20);
            Console.Write("Time created with constructor that has 3 arguments.\n" +
                $"Universal time is {time2.toUniversalString()}\n" +
                $"Standard time is {time2.ToString()}\n\n");

            Time time3 = new Time(13, 45);
            Console.Write("Time created with constructor that has 2 arguments.\n" +
                $"Universal time is {time3.toUniversalString()}\n" +
                $"Standard time is {time3.ToString()}\n\n");

            Time time4 = new Time(15);
            Console.Write("Time created with constructor that has 1 arguments.\n" +
                $"Universal time is {time4.toUniversalString()}\n" +
                $"Standard time is {time4.ToString()}\n\n");


            Console.WriteLine("Time created with constructor that has invalid values.");
            try
            {
                Time time5 = new Time(25);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // Keep console open until user closes it
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }
    }
}
