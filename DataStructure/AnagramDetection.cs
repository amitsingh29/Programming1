using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class AnagramDetection
    {
        public void anag()
        {
            Console.WriteLine("Enter I String");
            String s1 = Console.ReadLine();
            Console.WriteLine("Enter II String");
            String s2 = Console.ReadLine();
            Utility.anagram(s1,s2);
        }
        

    }
}
