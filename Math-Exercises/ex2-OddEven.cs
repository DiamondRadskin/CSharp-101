/*
 * 2026-08-19
 *
 * Exercise on determining if numbers are even or odd from an array.
 * 
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math_Exercises
{
    internal class OddEven
    {
        public void exercise()
        {
            int[] refNumbers = {14, -2, 31, 4, 5, 46, 7, 18, 9, 10, 46, 98, 23, 54, 56};
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();


            
            
            for(int i = 1; i < refNumbers.Length; i++)
            {
                if (refNumbers[i] % 2 == 0)
                {
                    evenNumbers.Add(refNumbers[i]);
                }
                else
                {
                    oddNumbers.Add(refNumbers[i]);
                }
            }
            Console.WriteLine(string.Join(" - ", evenNumbers));
            Console.WriteLine(string.Join(" - ", oddNumbers));

        }
    }
}
