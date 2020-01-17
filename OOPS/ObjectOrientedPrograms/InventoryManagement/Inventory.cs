using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
   
    public class Inventory
    {
        public List<Item> Rice { get; set; }
        public List<Item> Pulse { get; set; }
        public List<Item> Wheat { get; set; }

        public class Item
        {
            public string name { get; set; }
            public int weight { get; set; }
            public int price { get; set; }
        }
    }
}
