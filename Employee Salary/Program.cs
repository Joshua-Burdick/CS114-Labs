using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 152.4562701;
            string message = String.Format("The number is {0:N4}", number);
            Console.WriteLine(message);
            Employee[] employees = new Employee[] {
                new SalariedEmployee("John", "Smith", "111-11-1111", 800.00),
                new HourlyEmployee("Karen", "Price", "222-22-2222", 16.75, 40),
                new CommissionEmployee("Sue", "Jones", "333-33-3333", 10000, .06),
                new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444", 5000, .04, 300),
                new PieceWorker("Rick", "Bridges", "555-55-5555", 2.25, 400)
            };

            foreach (Employee emp in employees)
            {
                if (emp == null) continue;

                Console.WriteLine(emp);
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
