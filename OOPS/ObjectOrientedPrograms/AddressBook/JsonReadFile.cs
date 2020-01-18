using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using ObjectOrientedPrograms.AddressBook;

namespace ObjectOrientedPrograms
{
    class JsonReadFile
    {
        public List<AddressBookModel> AddressRead { get; internal set; }
        public object AddressList { get; internal set; }

        /// <summary>
        /// Reads this instance.
        /// </summary>
        /// <returns></returns>
        public static JsonReadFile Read()
        {
            
            String path = (@"C:\Users\ye10397\Desktop\Amit\Programming1\OOPS\ObjectOrientedPrograms\AddressBook\Address.json");
            StreamReader s = new StreamReader(path);
            var json = s.ReadToEnd();
            var d = JsonConvert.DeserializeObject<JsonReadFile>(json);
            s.Close();
            return d;
        }

        internal void Address(AddressBookModel a)
        {
            throw new NotImplementedException();
        }
    }
}
