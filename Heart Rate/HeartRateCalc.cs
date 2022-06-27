using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateLab
{
    class HeartRateCalc
    {
        //Calculate maximum heart rate
        public int calcMaxHeartRate(int age)
        {
            return 220 - age;
        }
        //Calculate min and ma target heart rate
        public void calcTargetHeartRates(int age, out int min, out int max)
        {
            //Min target is 50% of the max
            min = (int)(calcMaxHeartRate(age) * 0.5);

            //Max target is 85% of the max
            max = (int)(calcMaxHeartRate(age) * 0.85);
        }
    }
}
