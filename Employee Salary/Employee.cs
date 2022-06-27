using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public Employee(string first, string last, string ssn)
        {
            FirstName = first;
            LastName = last;
            SocialSecurityNumber = ssn;
        }

        // abstract method overridden by subclasses
        public abstract double earnings();

        public override string ToString() =>
            $"{FirstName} {LastName}\nSocial Security Number: {SocialSecurityNumber}, Earnings: {earnings():C2}";

    }
}