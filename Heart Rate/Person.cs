using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateLab
{
    class Person
    {
        private int _birthyear;
        private int currentyear;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear
        {
            get { return _birthyear; }
            set
            {
                if (value > DateTime.Today.Year)
                {
                    throw new ArgumentOutOfRangeException("Cannot be born in the future.");
                }
                if (DateTime.Today.Year - value > 100)
                {
                    throw new ArgumentOutOfRangeException("Cannot be more than 100 years old");
                }

                _birthyear = value;
            }
        }

        public Person(string firstname, string lastname, int birthyear) {
            currentyear = DateTime.Today.Year;
            FirstName = firstname;
            LastName = lastname;
            BirthYear = birthyear;
        }

        public int Age()
        {
            return currentyear - BirthYear;
        }
    }
}
