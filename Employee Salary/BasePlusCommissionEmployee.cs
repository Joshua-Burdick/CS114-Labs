using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; }

        public BasePlusCommissionEmployee(string first, string last, string ssn, double sales, double rate, double salary) : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary;
        }

        public override double earnings()
        {
            return base.earnings() + BaseSalary;
        }

        public override string ToString()
        {
            return "Base-Salaried Commission Employee " + base.ToString() + $", Base Salary: {BaseSalary:C2}";
        }
    }
}
