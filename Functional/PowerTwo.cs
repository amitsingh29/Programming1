using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class PowerTwo
    {
public void power()
        {
            Console.WriteLine("Enter a number upto you want power of 2");
            int N= int.Parse(Console.ReadLine());
            if(N>=0 && N<31)
            {
                for(int i=1;i<=N;i++)
                {
                   double pow=Math.Pow(2,i);
                    Console.WriteLine(pow);
                }
            }
        }
    }
}
