using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class HarMonic
    {
        public void harmonic()
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            if(n!=0)
            {
                double hN = 1;
                for(double i=2;i<=n;i++)
                {
                    hN = hN +(float) 1 / i;
             
                }
                Console.WriteLine("harmonic series is "+hN);
            }
        }
    }
}
