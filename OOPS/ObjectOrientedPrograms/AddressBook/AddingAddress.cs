using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    class AddingAddress
    {
        /// <summary>
        /// Addresses this instance.
        /// </summary>
        public void address()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your State");
            String state = Console.ReadLine();
            Console.WriteLine("Enter your District");
            String dist = Console.ReadLine();
            Console.WriteLine("Enter your Phone no.");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Email");
            String email = Console.ReadLine();
            
            AddressBookModel.CreatObject(name, state, dist, phone, email);
            
            Display d = new Display();
            
            d.displayList();
        }
    }
}
