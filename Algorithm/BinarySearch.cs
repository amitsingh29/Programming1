using System;

using System.Text;

namespace WeekOne
{
    class BinarySearch
    {
        
        static void BinarySearchElement()
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
            int res = Utility.binarySearchInteger(a,key);
            if (res == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element is present at "+" index "+res);
        }
    }
}