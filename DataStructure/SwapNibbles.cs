using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class SwapNibbles
    {
        public void swap()
        {
            Console.WriteLine("Enter an integer");
            int no = Convert.ToInt32(Console.ReadLine());
            int binary =Convert.ToInt32(Utility.toBinary(no));
            int[] bin = new int[binary];


            int swap;
            for(int i=0;i<bin.Length/2;i++)
            {
                for (int j = bin.Length - 1; j >=bin.Length/2; j--)
                {
                    swap = bin[i];
                    bin[i]=bin[j];
                    bin[j] = swap;
                }
            }

            


        }
    }
}
