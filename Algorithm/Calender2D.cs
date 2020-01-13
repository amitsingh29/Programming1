﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Calender2D
    {
		static int [,]  calender = new int[5,7];
		static int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		static void initCal()
		{
			for (int i = 0; i < calender.Length; i++)
			{
				for (int j = 0; j < calender.Length; j++)
				{
					calender[i,j] = -10;
				}
			}
		}

		static void display(int m)
		{
			Console.WriteLine("	Sun	Mon	Tue	Wed	Thu	Fri	Sat ");

			for (int i = 0; i < calender.Length; i++)
			{
				for (int j = 0; j < calender.Length; j++)
				{
					if (calender[i,j] < 0 || calender[i,j] > month[m - 1])
					{
						Console.WriteLine("\t ");
					}
					else if (calender[i,j] > 0)
					{
						Console.WriteLine("\t" + calender[i,j] + " ");
					}
				}
				Console.WriteLine("\t");
			}
		}

		static void putCalender(int d)
		{
			int d1 = 1;
			for (int i = d; i < calender.Length; i++)
			{
				calender[0,i] = d1++;
			}
			for (int i = 1; i < calender.Length; i++)
			{
				for (int j = 0; j < calender.Length; j++)
				{
					calender[i,j] = d1++;
				}
			}

		}

		static void dispCalender(int m, int y)
		{
			int d = dayOfWeek(m, y);
			initCal();
			putCalender(d);
			display(m);

		}

		static int dayOfWeek(int m, int y)
		{
			int d = 1;
			int y0 = y - (14 - m) / 12;
			int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
			int m0 = m + 12 * ((14 - m) / 12) - 2;
			int d0 = (d + x + (31 * m0) / 12) % 7;
			return d0;
		}
		
		}
	}


