
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ObjectOrientedPrograms
{
    class StockPortfolio
    {
        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void check()
        {
            string stocks = File.ReadAllText(@"C:\Users\ye10397\Desktop\Amit\Programming1\OOPS\ObjectOrientedPrograms\StockReport\Stock.json");
            var stockDisp = JsonConvert.DeserializeObject<List<StockReport>>(stocks);
            Console.WriteLine();

            foreach (var item in stockDisp)
            {
                Console.WriteLine("Name of the share: " + item.nameOfStock);
                Console.WriteLine("Number of share: " + item.noOfStock);
                Console.WriteLine("Price of the share: " + item.price);
                Console.WriteLine("Total Price is: " + item.noOfStock * item.price);
                Console.WriteLine();
            }

        }
    }
}
