using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class FindNumber
    {
        public void find(int low,int high)
        {
        if(low==high)
            {
                Console.WriteLine("The number is "+low);
                Console.WriteLine("The intermediary no's are "+Convert.ToInt32(low-1)+" "+Convert.ToInt32(low+1));
            }
            Console.WriteLine("Enter the no to be searched");
            int n = int.Parse(Console.ReadLine());
            int mid = low + high / 2;
            if(n==1)
            {
                find(low,mid);

            }
            else
            {
                find(mid + 1, high);
            }
        }
        public void randomNumber()
        {
            Console.WriteLine("Enter a number");
            int N = int.Parse(Console.ReadLine());
            find(0,N-1);

        }
    }
}
