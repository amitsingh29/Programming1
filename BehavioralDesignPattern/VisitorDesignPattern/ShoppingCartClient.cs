//-----------------------------------------------------------------------
// <copyright file="ShoppingCartClient.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    ///  ShoppingCartClient class
    /// </summary>
    public class ShoppingCartClient
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            ItemElement[] items = new ItemElement[] { new Book(20, "ABC1234"), new Book(100, "DEF5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple") };
            int total = calculatePrice(items);
            Console.WriteLine("Total Price: " + total);
        }

        /// <summary>
        /// Calculates the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        public int calculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor cart = new ShoppingCartVisitorImplementation();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(cart);
            }

            return sum;
        }
    }
}
