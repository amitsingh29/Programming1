using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Dequeue<T>
    {
		T[] dequeue = new T[10];
		int front = -1;
		int rear = ;


		public void dequeue(T data)
		{

			if (rear == dequeue.Length - 1)
			{
				Console.WriteLine("queue is full");
			}

			dequeue[rear] = data;
			rear++;
		}



		public bool isEmpty()
		{
			if (front == -1 && rear == -1)
				return true;
			else
				return false;
		}


		public int size()
		{
			return rear;
		}

	}
}
