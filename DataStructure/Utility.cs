using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WeekOne
{
         class Utility
         {
       
        public static Boolean anagram(String s1, String s2)
        {
            s1 = s1.Replace(" ", "");
            s2 = s2.Replace(" ","");

            s1 = s1.ToLower();
            s2 = s2.ToLower();
            char[] ch = s1.ToCharArray();
            char[] ch1 = s2.ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);

            String str = new String(ch);
            String str1 = new String(ch1);
            if (str == str1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
         public static Boolean intAnagram(int k,int f)
        {

            int rev = 0;
            int t = k;
            while(k>0)
            {
                int r = k % 10;
                rev = rev * 10 + r;
                r = r / 10;
            }
            if(rev==t)
            {
                Console.WriteLine(t);
            }
            if(rev==f)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool prime(int n)
        {
            int temp = 0;
            for(int i=2;i<=n-1;i++)
            {
                if(n%i==0)
                {
                    temp = temp + 1;
                }
            }
            if(temp==0)
            {
                return true;
            }
            else
            {
                return false;
            }
         

        }



    

        public static Boolean palindrome(int n)
        {
            int temp = n;
            int rev = 0;
            while (n > 0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if (rev == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public static int binarySearch(int[] a)
        {
            int n = a.Length;
            int left = 0, right = a.Length - 1;
            int mid = left + right;
            for (int i = 0; i < n; i++)
            {
                int key = a[i];
                if (key == mid)
                {
                    Console.WriteLine("Element is present at " + a[mid]);
                    return 1;
                }
                else if (key < mid)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;

                }
            }
            return -1;
        }
       



        public static int[] bubbleSortInt(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            return a;

        }

        public static string[] bubbleSortString(string [] str)
        {
            string temp;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 1; j < (str.Length-i); j++)
                {
                  
                    if (str[j - 1].CompareTo(str[j])>0)
                    { 
                         temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                }
            }
            return str;
        }


        public static int binarySearchString(String[] names, String key)
        {
            int first = 0;
            int last = names.Length;

            while (first < last)
            {
                int mid = (first + last) / 2;
                if (key.CompareTo(names[mid]) < 0)
                {
                    last = mid;
                }
                else if (key.CompareTo(names[mid]) > 0)
                {
                    first = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }




        public static int binarySearchInteger(int[] a, int key)
        {

            int left = 0, right = a.Length - 1;
            int mid = left + right / 2;
            while (left < right)
            {


                if (key == mid)
                {
                    Console.WriteLine("Element is at index " + a[mid]);
                    return 1;
                }
                else if (key > mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        public static  string[] insertionSortString(String[] name)
        {
            int i, j;
            String key;
            for (j = 1; j < name.Length; j++)
            {
                key = name[j];
                i = j - 1;
                while (i >= 0)
                {
                    if(key.CompareTo(name[i])>0)
                    {
                        break;
                    }
                    name[i + 1] = name[i];
                    i--;

                }
                name[i + 1] = key;
            }
            return name;

        }

        public static int [] insertionSortInteger(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

       
        
        public static double celToFarenheitConversion(double c)
        {
            double farenheit = (c * 9 / 5) + 32;

            return farenheit;

        }



        
        public static double farenheitToCelConversion(double f)
        {
            double celcius = (f - 32) * 5 / 9;

            return celcius;

        }




        public static double monthlyPayment(int P, int R, int Y)
        {
            int n = 12 * Y;
            int r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            return payment;
        }


       
        public static void sqrt(int c)
        {
            if (c >= 0)
            {
                int t = c;


                {
                    while (Math.Abs(t - c / t) > (Math.Pow(Math.E, -15) * t))

                        t = ((c / t) + t) / 2;


                }
            }
        }

      
        public static int[] toBinary(int num)
        {
            int[] binaryNo = new int[8];
            int i = 0;
            while (num > 0)
            {
                binaryNo[i] = num % 2;
                num = num / 2;
                i++;


            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNo[j] + " ");
            }
            return binaryNo;
        }
       



        public static int dayOfWeek(int m, int d, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            return d0;
        }


       

       


    }
}

