using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    class JsonWriteFile
    {
        /// <summary>
        /// Writes the specified read.
        /// </summary>
        /// <param name="read">The read.</param>
        public static void Write(JsonReadFile read)
        {
           
            String path = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\AddressBook\Addressbook.json");
            
            var write = JsonConvert.SerializeObject(read);
            StreamWriter stream = new StreamWriter(path);
            
            stream.Flush();
            
            stream.Write(write);
            
            stream.Close();
        }
    }
}
