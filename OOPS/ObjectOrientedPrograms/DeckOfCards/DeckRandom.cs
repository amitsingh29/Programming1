using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class DeckRandom
    {
        public string[] suit = { "clubs", "diamonds", "hearts", "spades" };
        public string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
        public string[] total = new string[53];

        public int k = 0;

       /// <summary>
       /// 
       /// </summary>
        public void initialize()
        {

            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < rank.Length; j++)
                {
                    total[k] = rank[j] + " of " + suit[i];
                    k++;
                }
            }
            Random r = new Random();
            for (int m = 0; m < total.Length; m++)
            {
                int random = r.Next(52 - m);
                string temp = total[m];
                total[m] = total[random];
                total[random] = temp;
            }


            int totalCards = total.Length - 1;
            string[,] array = new string[4, 9];
            int q = 0;
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 9; b++)
                {
                    array[a, b] = total[q];
                    q++;
                }

            }


            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("-------------------Player" + c + "----------------------");
                for (int d = 0; d < 9; d++)
                {
                    Console.Write(array[c, d]);
                    Console.WriteLine();
                }

            }
        }
    }
}
