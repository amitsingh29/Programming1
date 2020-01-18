using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.DeckOfCardsQueue
{
    class QueueDeckOfCards
    {
        /// <summary>
        /// Cards the in queue.
        /// </summary>
        public static void CardInQueue()
        {
            string[,] CardOfPlayer = PassingCards();

            Queue<Queue<string>> sortedcard = SortingCards(CardOfPlayer);
            string[] playername = { "** Player 1 **", "** Player 2 **", "** Player 3 **", "** Player 4 **" };
            int index = 0;
            while (sortedcard.Count != 0)
            {
                Queue<string> temp = sortedcard.Dequeue();
                Console.WriteLine(playername[index] + ":");
                while (temp.Count != 0)
                {
                    Console.Write(temp.Dequeue() + " \t ");
                }

                Console.WriteLine();
                index++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string[,] PassingCards()
        {
           
            string[,] arr = new string[4, 13];
            
            ShowCard(arr);
            
            Shuffle(arr);
           
            string[,] playercard = new string[4, 9];
           
            for (int i = 0; i < playercard.GetLength(0); i++)
            {
                for (int j = 0; j < playercard.GetLength(1); j++)
                {
                  
                    playercard[i, j] = arr[i, j];
                }
            }

            return playercard;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void ShowCard(string[,] arr)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "King", "Queen", "Ace" };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {      
                    arr[i, j] = suits[i] + " " + rank[j];
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        public static void Shuffle(string[,] arr)
        {  
            Random r1 = new Random();
            for (int i = 0; i < 150; i++)
            {
                int x1 = Convert.ToInt32(r1.Next(4));
                int x2 = Convert.ToInt32(r1.Next(13));
                int x3 = Convert.ToInt32(r1.Next(4));
                int x4 = Convert.ToInt32(r1.Next(13));
               
                Swap(arr, x1, x2, x3, x4);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="x3"></param>
        /// <param name="x4"></param>
        public static void Swap(string[,] arr, int x1, int x2, int x3, int x4)
        {
            string temp = arr[x1, x2];
            arr[x1, x2] = arr[x3, x4];
            arr[x3, x4] = temp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playercard"></param>
        /// <returns></returns>
        public static Queue<Queue<string>> SortingCards(string[,] playercard)
        {
            Queue<Queue<string>> sortedcard = new Queue<Queue<string>>();
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int[] arr = new int[9];
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string[] temp = (playercard[i, j] + " ").Split(' ');
                    for (int k = 0; k < 13; k++)
                    {
                        if (temp[1].Equals(rank[k]))
                        {
                            arr[index] = k;
                            index++;
                        }
                    }
                }

                Console.WriteLine();
                index = 0;
                for (int k1 = 0; k1 < arr.Length - 1; k1++)
                {
                    for (int k2 = k1 + 1; k2 < arr.Length; k2++)
                    {
                        if (arr[k1] > arr[k2])
                        {
                            int temp = arr[k1];
                            arr[k1] = arr[k2];
                            arr[k2] = temp;

                            string temp1 = playercard[i, k1];
                            playercard[i, k1] = playercard[i, k2];
                            playercard[i, k2] = temp1;
                        }
                    }
                }
            }

            for (int i = 0; i < playercard.GetLength(0); i++)
            {
                Queue<string> temp = new Queue<string>();
                for (int j = 0; j < playercard.GetLength(1); j++)
                {
                    temp.Enqueue(playercard[i, j]);
                }
                sortedcard.Enqueue(temp);
            }
            return sortedcard;
        }
    }
}
