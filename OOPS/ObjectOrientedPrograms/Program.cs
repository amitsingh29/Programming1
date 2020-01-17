
using System;

namespace ObjectOrientedPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
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

            }   
        }
    }
}
