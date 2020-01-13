using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Calender
    {
        public void calculate()
        {
            Console.WriteLine("Enter the month");
            int mon = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the year");
            int yr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int day = Convert.ToInt32(Console.ReadLine());
            int n=Utility.dayOfWeek(mon, day, yr);
            
            
            switch(n)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
               
            }
            
        }

    }
}
