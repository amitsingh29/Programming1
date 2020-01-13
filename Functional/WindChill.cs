using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class WindChill
    {
        public void windChill()
        {
            Console.WriteLine("Temperature in(farenheit)");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Wind speed in(miles per hour)");
            int v = int.Parse(Console.ReadLine());
            if(t>50 || v>120 || v<3)
            {
                Console.WriteLine("Invalid fowmula");
            }
            else
            {
               double w = 35.74+0.6215*t+(0.4275 * t-35.75)*Math.Pow(v,0.16);
                Console.WriteLine(w);
            }
        }
        
    }
}
