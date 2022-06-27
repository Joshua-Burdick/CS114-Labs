using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalariedEmployee : Employee
    {
        public double WeeklySalary { get; set; }

        public SalariedEmployee(string first, string last, string ssn, double salary) : base(first, last, ssn)
        {
            WeeklySalary = salary;
        }

        public override double earnings()
        {
            return WeeklySalary;
        }

        public override string ToString()
        {
            return "Salaried Employee: " + base.ToString() + $"\nWeekly Salary: {WeeklySalary:C2}";
        }
    }
}
