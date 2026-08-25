/*
 * 2026-08-24
 *
 * Exercise on converting given array of doule Fahrenheit values to Celcius.
 * Add to a List computed Celcius vaues greater than the provided high-temp Constant.
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Exercises
{
    internal class Excercise03
    {
        public void exercise()
        {
            double[] farenheits = new double[5] { 87.5, 56.4, 58.7, 34.2, 13.3 };
            List<double> highTempts = new List<double>();
            const int HIGHTEMPT = 3;

            
            

            for (int i = 0; i < farenheits.Length; i++)
            {
                double celcius = convertToCelcius(farenheits[i]);

                if (celcius > HIGHTEMPT)
                {
                    highTempts.Add(celcius);
                }
                
            }
            
            Console.WriteLine(string.Join(" - ", highTempts));   
            
        }

        public double convertToCelcius(double fahrenheit)
        {

           double celcius = (fahrenheit - 32.0) * (5.0 / 9.0);

            return celcius;

        }
    
    }
}
