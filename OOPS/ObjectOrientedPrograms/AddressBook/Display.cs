using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.AddressBook
{
    class Display
    {
        /// <summary>
        /// Displays the list.
        /// </summary>
        public void displayList()
        {
           
            var d = JsonReadFile.Read();
            List<AddressBookModel> model = d.AddressRead;
            foreach (AddressBookModel i in model)
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + i.Name);
                Console.WriteLine("State: " + i.State);
                Console.WriteLine("District" + i.Dist);
                Console.WriteLine("Phone no.: " + i.Phone);
                Console.WriteLine("Email: " + i.Email);
            }
        }
    }
}