using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class LeapYear
    {
        public void leap()
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if(year>999 && year<10000)
            {
                if(year%4==0 && year%100!=0 || year%400==0)
                {
                    Console.WriteLine(year+" is a leap year");

                }
                else
                {
                    Console.WriteLine(year+" is not a leap year");
                }
            }
        }
    }
}
