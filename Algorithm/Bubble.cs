using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Bubble
    {
        public void bubble()
        {

            Console.WriteLine("Enter the size of an array");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter " + n + " elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element that you want to search");
            int key = int.Parse(Console.ReadLine());
            Utility.bubbleSortInt(a);
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]+" ");
            }

        }
    }
}
