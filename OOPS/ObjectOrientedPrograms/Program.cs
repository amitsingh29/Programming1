
using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.WriteLine("Enter 1 for Inventory Data Management ");
            Console.WriteLine("Enter 2 for Regex");
            Console.WriteLine("Enter 3 for Deck Of Cards");
            Console.WriteLine("Enter 4 for Deck Of Cards Queue");
            Console.WriteLine("Enter 5 for Stock Report");
            Console.WriteLine("Enter 6 for Address Book");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    InventoryDataManagement dataManagement = new InventoryDataManagement();
                    dataManagement.details();
                    break;
                case 2:
                    RegularExpression regularExpression = new RegularExpression();
                    regularExpression.stringReplace();
                    break;
                case 3:
                    DeckRandom deck = new DeckRandom();
                    deck.initialize();
                    break;
                case 4:
                    StockPortfolio stock = new StockPortfolio();
                    stock.check();
                    break;
                case 5:
                    
                    break;
                case 6:
                    QueueDeckOfCards queueDeck = new QueueDeckOfCards();
                    queueDeck.CardInQueue();

                    break;

            }   
        }
    }
}
