using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class SumOfThree
    {
        public void sum()
        {
           
      
            Console.WriteLine("Enter the size of an array");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter "+n+" elements");
            for(int i=0;i<n;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int triplets = 0;
            for(int i=0;i<n-2;i++)
            {
                for(int j=i+1;j<n-1;j++)
                {
                    for(int k=j+1;k<n;k++)
                    {
                    if(a[i]+a[j]+a[k]==0)
                        {
                            triplets++;
                            Console.WriteLine(a[i] + " " + a[j] + " " + a[k]);
                        }
                    }
                }
            }
            Console.WriteLine("no os triplets are " + triplets);
        }
    }
}
