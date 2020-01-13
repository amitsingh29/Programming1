using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Quadratic
    {
        public void quad()
        {
            Console.WriteLine("Enter value 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value 3");
            int c = int.Parse(Console.ReadLine());
            int delta = b * b + 4 * a * c;
            double r1, r2;
            if(delta>0)
            {
                r1 = (-b + Math.Sqrt(delta))/2*a;
                Console.WriteLine(r1);
            }
            else
            {
                r2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine(r2);
            }
        }
    }
}
