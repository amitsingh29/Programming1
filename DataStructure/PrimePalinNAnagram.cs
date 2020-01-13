using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class PrimePalinNAnagram
    {
        public static void check()
        {
            for(int j=0;j<1000;j++)
            {
                Boolean isprime = Utility.prime(j);
                if(isprime)
                {
                    Console.WriteLine(j);
                    Boolean isPalin = Utility.palindrome(j);
                   
                }

            }
        }
    }
}
