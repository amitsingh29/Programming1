using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class InventoryDataManagement
    {
        /// <summary>
        /// Detailses this instance.
        /// </summary>
        public void details()
        {
            Inventory inventory = JsonConvert.DeserializeObject<Inventory>(File.ReadAllText(@"C:\Users\ye10397\Desktop\Amit\Programming1\OOPS\ObjectOrientedPrograms\InventoryManagement\InventoryDetails.json"));
            print(inventory.Rice);
            print(inventory.Pulse);
            print(inventory.Wheat);
        }

        public void print(List<Inventory.Item> item) {
            foreach (Inventory.Item i in item) {
                Console.WriteLine("Name: " + i.name + "\nWeight: " + i.weight + "\nPrice: " + i.price);
            }
        }
    }
}
