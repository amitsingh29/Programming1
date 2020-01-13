using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
	class Balanced
	{
		public static Boolean check(char[] s)
		{
			Stack<char> s1 = new Stack<char>();
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == '(')
				{
					s1.Push(s[i]);
				}
				if (s[i] == ')')
				{
					s1.Pop();
				}
			}
			if (s1.isEmpty())
			{
				return true;
			}

			else
			{
				return false;
			}
		}	
			public static void isBalanced(String s)
			{
				// string s=Console.ReadLine();
				//Console.WriteLine("Enter the String");
				char [] ch =s.ToCharArray();
			Boolean balancedCheck =check(ch);
			if(balancedCheck)
			{
				Console.WriteLine("String is balanced");
			}
			else
				Console.WriteLine("String is not balanced");
		}
		}


	}

