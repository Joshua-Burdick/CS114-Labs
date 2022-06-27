using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeartRateCalc hr = new HeartRateCalc();
            Person[] persons = new Person[9];
            try
            {
                persons[0] = new Person("Tina", "Crumpet", 2002);
                persons[1] = new Person("Visnu", "Payup", 1992);
                persons[2] = new Person("Carmine", "Dioxide", 1982);
                persons[3] = new Person("Hubert", "Humvee", 1972);
                persons[4] = new Person("Hugo", "First", 1962);
                persons[5] = new Person("Horatio", "Algebra", 1952);
                persons[6] = new Person("Hugh", "Louis", 1942);
                persons[7] = new Person("Xavier", "Hold", 1932);
                persons[8] = new Person("Philip", "Harmonic", 1922);

                Console.WriteLine(String.Format("{0,-20}{1,-5}{2,-17}{3,0}", "Name", "Age", "Target HR Zone", "Average Maximum"));
                Console.WriteLine(String.Format("{0,39}{1,15}", "50-85% (bpm)", "Rate, 100%"));

                foreach (Person person in persons)
                {
                    int minHR,
                        maxHR;
                    hr.calcTargetHeartRates(person.Age(), out minHR, out maxHR);
                    Console.WriteLine(String.Format("{0,-20}{1,-7}{2,4}-{3}{4,16}", person.FirstName + ' ' + person.LastName, person.Age(), minHR, maxHR, hr.calcMaxHeartRate(person.Age())));
                }
                //persons[1] = new Person("Randy", "Lewis", 1919);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine();

            //Keep console open until user quits
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}