using System;
using System.Collections.Generic;
using System.Text;

namespace WeekOne
{
    class Gambler
    {
        public void gamble()
        {
            Console.WriteLine("Enter the stake");
            int stake = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the goal");
            int goal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of times");
            int n = int.Parse(Console.ReadLine());
            int win = 0, loss = 0;
            Random r = new Random();
            double ran = r.Next(0, 1);
            for (int i=1;i<=n;i++)
            {
                if (ran<0.5)
                {
                    win++;
                    stake = stake + 1;
                    if (stake == goal)
                    {
                        Console.WriteLine("You won the match");
                        break;
                    }
                }
                else
                {
                    loss--;
                    stake = stake - 1;
                    if(stake==0)
                    {
                        Console.WriteLine("You lost the game");
                        break;
                    }
                }
            }
            double winPer = win / n * 100;
            double lossPer = loss / n * 100;
            Console.WriteLine("Win per is "+winPer);
            Console.WriteLine("Loss per is "+lossPer);

        }
        
    }
}
