using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{   
            public class SwitchSearchSort
        {

            public static void optionMenu()
            {
             Console.WriteLine("please enter your selection \n 1.binary Search \n 2.Bubble sort \n 3.Insertion  Sort");
             int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("please select options 1.binary search string \n 2.binary search integer");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    String[] b = { "amit", "ayush", "mayank", "ramneet", "saad" };
                    String toSearch = "mayank";
                    int n = Utility.binarySearchString(b, toSearch);
                    Console.WriteLine("string is found at position: {0}", n);

                }
                else if (num == 2)
                {
                    int[] arr = { 23, 45, 53, 74, 91, 108 };
                    int key = 74;
                    int n = Utility.binarySearchInteger(arr, key);
                    Console.WriteLine("Integer is found at position: {0}", n);
                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }

            }
            else if (input == 2)
            {
                Console.WriteLine("please select options 1.BubbleSort string \n 2.BubbleSort integer");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    string[] name = { "mayank", "saad", "ramneet", "ayush", "amit" };
                    for (int j = 0; j < name.Length; j++)
                    {
                        Console.WriteLine("before sorting" + name[j]);


                    }
                    string[] str1 = Utility.bubbleSortString(name);
                    for (int i = 0; i < str1.Length; i++)
                    {
                        Console.Write(str1[i] + "");

                    }


                }
                else if (num == 2)
                {
                    int[] arr = { 4, 8, 12, 2, 5, 6, 7 };
                    int[] sort = Utility.bubbleSortInt(arr);

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(sort[i] + "");

                    }


                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }
            }


            else if (input == 3)
            {
                Console.WriteLine("please select options 1.InsertionSort string \n 2.InsertionSort integer");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 1)
                {
                    string[] name = { "rakesh", "avinash", "mayank", "shubham", "anmol", "bharat" };
                    for (int j = 0; j < name.Length; j++)
                    {
                        Console.WriteLine("before sorting" + name[j]);
                    }
                    string[] str1 = Utility.insertionSortString(name);
                    for (int i = 0; i < str1.Length; i++)
                    {
                        Console.Write(str1[i] + "");

                    }


                }




                else if (num == 2)
                {
                    int[] arr = { 4, 8, 12, 2, 5, 6, 7 };
                    int[] n = Utility.insertionSortInteger(arr);

                    for (int i = 0; i < n.Length; i++)
                    {
                        Console.Write(n[i] + "");

                    }
                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }

            }
                         
            else
              {
                    Console.WriteLine("please enter valid input");    
              }
         
             }
            } 

	
	
	

            }
