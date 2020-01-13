using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Flip
    {
        public void flipc()
        {
            int h = 0, t = 0;
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            if(n!=0)
            {
                for(int i=1;i<=n;i++)
                {
                    Random random = new Random();
                    double r = random.Next(0,1);
                    if(r<0.5)
                    {
                        h++;
                    }
                    else
                    {
                        t++;
                    }
                }
            }
            int hPer = h / n * 100;
            int tPer = t / n * 100;
            Console.WriteLine(hPer+" "+tPer);
        }
    }
}
