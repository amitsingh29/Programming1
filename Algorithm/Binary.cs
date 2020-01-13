using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Binary
    {
        public void isBinary()
        {
            Console.WriteLine("Insert a decimal number");
            int dec = int.Parse(Console.ReadLine());

            int  bin =Convert.ToInt32(Utility.toBinary(dec));

        }
    }
}
