using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; }

        public double Hours { get; set; }

        public HourlyEmployee(string first, string last, string ssn, double hourlyWage, double hoursWorked) : base(first, last, ssn)
        {
            Wage = hourlyWage;
            Hours = hoursWorked;
        }

        public override double earnings()
        {
            return Hours * Wage;
        }

        public override string ToString()
        {
            return "Hourly Employee: " + base.ToString() + $"\nHourly Wage: {Wage:C2}, Hours Worked: {Hours}";
        }
    }
}
