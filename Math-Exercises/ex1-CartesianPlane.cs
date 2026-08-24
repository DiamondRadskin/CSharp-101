/*
 * 2026-08-17
 * 
 * Simple exercise for determining quadrant for given coordinates on Cartetian Plane
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Exercises
{
    internal class CartetianPlane
    {
        public void exercise()
        {
            int xAxis = 10;
            int yAxis = 10;

            if (xAxis > 0 && yAxis > 0)
            {
                Console.WriteLine($"QUADRANT 1: X-Axis = {xAxis}, Y-Axis {yAxis}");
            }
            else if (xAxis < 0 && yAxis > 0)
            {
                Console.WriteLine($"QUADRANT 2: X-Axis = {xAxis}, Y-Axis {yAxis}");
            }
            else if (xAxis < 0 && yAxis < 0)
            {
                Console.WriteLine($"QUADRANT 3: X-Axis = {xAxis}, Y-Axis {yAxis}");
            }
            else if (xAxis > 0 && yAxis < 0)
            {
                Console.WriteLine($"QUADRANT 4: X-Axis = {xAxis}, Y-Axis {yAxis}");
            }
            else
            {
                Console.WriteLine("ERROR! UNDENTIFIED COORDINATES!");
            }





        }

    }
}
