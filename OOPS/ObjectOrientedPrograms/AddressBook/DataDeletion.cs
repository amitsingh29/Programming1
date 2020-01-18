using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class DataDeletion
    {
        /// <summary>
        /// Deletes the data.
        /// </summary>
        public void deleteData()
        {
            Console.WriteLine("Enter the name , whose address you want to delet");
           
            String n = Console.ReadLine();
           
            var d = JsonReadFile.Read();
            foreach (var i in d.AddressRead)
            {
                
                if (i.Name.Equals(n))
                {
                   
                    d.AddressList(i);
                    break;
                }
            }
           
            JsonWriteFile.Write(d);
           
            Console.WriteLine("............Data......deleted............ ");
          
        }
    }
}
