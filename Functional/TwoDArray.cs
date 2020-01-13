using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
        class TwoDArray
        {
         static void array()
        {
            Console.WriteLine("please enter your choice:\n 1.Integer Array \n 2.Double array \n 3.boolean Array");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number of row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number of column");
            int column = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[,] array = new int[row, column];
                    Console.WriteLine("enter the double elements in your array:");

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; i < column; i++)
                        {
                            array[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("array elements are:");
                    for (int k = 0; k < row; k++)
                    {
                        for (int l = 0; l < column; l++)
                        {
                            Console.Write(array[k, l] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    double[,] array1 = new double[row, column];
                    Console.WriteLine("enter the double elements in your array:");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; i < column; i++)
                        {
                            array1[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("array elements are:");
                    for (int k = 0; k < row; k++)
                    {
                        for (int l = 0; l < column; l++)
                        {
                            Console.Write(array1[k, l] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    bool [,] array2 = new bool[row, column];

                    Console.WriteLine("enter the boolean value in your array:");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; i < column; i++)
                        {
                            array2[i, j] =Convert.ToBoolean(Console.ReadLine());
                        }
                    }
                    Console.WriteLine("array elements are:");
                    for (int k = 0; k < row; k++)
                    {
                        for (int l = 0; l < column; l++)
                        {
                            Console.Write(array2[k, l] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;


                default:
                    Console.WriteLine("invalid input!!!");
                    break;
            }



        }
    }
}

