using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Queue<T>
    {
		T[] queue = new T[10];
        int front = -1;
		int rear = -1;
		public void enqueue(T data)
		{

			if (rear == queue.Length-1)
			{
				Console.WriteLine("queue is full");
			}

			queue[rear] = data;
			rear++;
		}

		public T dequeue()
		{

			if (isEmpty())
			{
				Console.WriteLine("Can't Pop stack is empty");
				return default(T);
			}

			else
			{
				T data = queue[front];
				front--;
				return data;
			}

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