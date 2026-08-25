using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Exercises
{
    internal class Exercise04
    {
        public void exercise()
        {
            Dictionary<int, double[]> voltageCurrent = new Dictionary<int, double[]>
            {
                
                {1, [9.4, 32.8]},
                {2, [10.6, 15.2]},
                {3, [19.3, 23.5]},
                {4, [1.4, 2.8]},
                {5, [3.6, 2.2]},
                {6, [2.3, 4.4]},
                {7, [5.4, 1.7]},
                {8, [6.1, 4.3]},
                {9, [19.3, 23.5]},
                {10,[15.4, 21.8]}
            };

            Dictionary<int, string> highWatts = new();
            Dictionary<int, string> lowWatts = new();
            const double idealWatts = 50.0;

            foreach (var kvp in voltageCurrent)
            {
                double voltage = kvp.Value[0];
                double current = kvp.Value[1];

                double power = computePower(voltage, current);

                string powerS = power.ToString("F2");

                if (power > idealWatts)
                {
                    highWatts[kvp.Key] = powerS;
                }
                else if (power < idealWatts)
                {
                    lowWatts[kvp.Key] = powerS;
                }
            }
            Console.WriteLine(string.Join(" - ", highWatts));
            Console.WriteLine(string.Join(" - ", lowWatts));
            
            
            
            
        }

        public double computePower(double voltage, double current)
        {
            double power = voltage * current;

            return power;
        }
    }
}
        