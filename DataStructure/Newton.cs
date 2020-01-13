using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Newton
    {
        public double NewtonMethod()
        {
            Console.WriteLine("Enter a number");
            double c = double.Parse(Console.ReadLine());
            double t = c;
            if(c>=0)
            {
                double epsilon = 1 * Math.Pow(Math.E, -15);
                if (Math.Abs(t - c / t) > epsilon * t)
                {
                    t = (c / t) + (t) / 2;
                }
               
            }
            return t;

        }
    }
}
