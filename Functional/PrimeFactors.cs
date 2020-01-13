using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class PrimeFactors
    {
        public static void factors()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=2;i*i<=n;i++)
            {
               while(n%i==0)
                {
                    Console.WriteLine(n);
                    n = n / i;
                }
               
            }
            if(n>1)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }

        }
    }

}
