using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Time
    {
        private int _hour, _minute, _second;
        private DateTime time;

        public int Hour
        {
            get { return _hour; }
            set
            {
                Validate(value, 24, "Hour");
                _hour = value;
            }
        }

        public int Minute
        {
            get { return _minute; }
            set
            {
                Validate(value, 60, "Minute");
                _minute = value;
            }
        }

        public int Second
        {
            get { return _second; }
            set
            {
                Validate(value, 60, "Second");
                _second = value;
            }
        }

        public Time(int hour = 0, int minute = 0, int second = 0)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            time = new DateTime(1, 1, 1, Hour, Minute, Second);
        }

        private void Validate(int var, int limit, string name)
        {
            if(var < 0 | var > limit)
            {
                throw new ArgumentOutOfRangeException($"{name} must be between 0 and {limit}");
            }
        }

        public override string ToString()
        {
            string phase = "AM";

            if(Hour > 12) { phase = "PM"; }

            return time.ToString("hh:mm:ss") + " " + phase;
        }

        public string toUniversalString()
        {
            return time.ToString("HH:mm:ss");
        }
    }
}
