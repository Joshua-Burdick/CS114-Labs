using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; }

        public double CommissionRate { get; set; }

        public CommissionEmployee(string first, string last, string ssn, double sales, double rate) : base(first, last, ssn)
        {
            GrossSales = sales;
            CommissionRate = rate;
        }

        public override double earnings()
        {
            return CommissionRate * GrossSales;
        }

        public override string ToString()
        {
            return "Commission Employee: " + base.ToString() + $"\nGross Sales: {GrossSales:C2}, Commission Rate: {CommissionRate:C2}";
        }
    }
}
