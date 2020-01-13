
using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class ReplaceString
    {
        public void replace()
        {
            String s1 = "Hello <<UserName>>,How are you?";
            Console.WriteLine("Enter the String");
            String s2 = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(s1);
            stringBuilder.Replace("<<UserName>>",s2);
            Console.WriteLine(stringBuilder);
        }
    }
}
