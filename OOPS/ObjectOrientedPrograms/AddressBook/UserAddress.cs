using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    class UserAddress
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {

            Console.WriteLine("Enter 1 to See the adderss book");
            Console.WriteLine("Enter 2 to Add new details");
            Console.WriteLine("Enter 3 to delete from the list");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Display d = new Display();
                    d.displayList();
                    break;
                case 2:
                    AddingAddress a = new AddingAddress();
                    a.address();
                    break;
                case 3:
                    DataDeletion b = new DataDeletion();
                    b.deleteData();
                    break;
            }
        }
    }
}