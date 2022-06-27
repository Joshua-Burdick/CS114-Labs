using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary number (0 or 1s): ");
            string binary = Console.ReadLine();

            if(String.IsNullOrEmpty(binary))
            {
                Console.WriteLine("* You must enter a binary number");
                //Keep the console open after executing until the user quits
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                return;
            }

            // Validate input
            foreach(char i in binary)
            {
                if(char.IsLetter(i))
                {
                    Console.WriteLine($"* Your input {binary} is not binary");
                    //Keep the console open after executing until the user quits
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine($"Decimal for {binary} is {BinToDec(binary)}");

            //Keep the console open after executing until the user quits
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static double BinToDec(string binary)
        {
            double converted = 0;
            int power = binary.Length - 1;

            foreach(char c in binary)
            {
                converted += ((int)c - 48) * Math.Pow(2, power); //convert, find the power based on iteration from 0 starting at the rightmost digit
                power--;
            }

            return converted;
        }
    }
}
