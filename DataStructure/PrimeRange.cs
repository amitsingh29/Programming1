using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class PrimeRange
    {
        public void range()
        {
            
            for (int j=2;j<1000;j++)
            {
                Boolean primeNumber = Utility.prime(j);
                if (primeNumber)
                {
                    Console.WriteLine(j+" is Prime");
                }
                    
            }
            
               
        }




    }
}