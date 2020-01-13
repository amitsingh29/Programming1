using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    

		public class Stack<T>
		{
			
			

			 T [] stack = new T[10];
			
			 int top = -1;

			
			public void Push(T data)
			{
				
				if (top == 10)
				{
				Console.WriteLine("Stack is full");
				}
			
				stack[top] = data;
				top++;
			}

			
			public T Pop()
			{
			
				if (isEmpty())
				{
					Console.WriteLine("Can't Pop stack is empty");
				return default(T) ;
				}
			
				else
				{
					T data = (T)stack[top];
					top--;
					return data;
			}
			
		}

			
			public T Peek()
			{
				return (T)stack[top];
			}



		public Boolean isEmpty()
		{
			return top == 0;
		}


		public int size()
			{
				return top;
			}

		}
	}
