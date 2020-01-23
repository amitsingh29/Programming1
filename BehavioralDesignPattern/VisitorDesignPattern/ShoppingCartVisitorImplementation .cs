//-----------------------------------------------------------------------
// <copyright file="ShoppingCartVisitorImplementation.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//--------------------------------------------------------------------

namespace DesignPattern.BehavioralDesignPattern.VisitorDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ShoppingCartVisitorImplementation class
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPattern.VisitorDesignPattern.ShoppingCartVisitor" />
    public class ShoppingCartVisitorImplementation : ShoppingCartVisitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCartVisitorImplementation"/> class.
        /// </summary>
        public ShoppingCartVisitorImplementation()
        {
        }

        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        public int Visit(Book book)
        {
            int cost = 0;
            if (book.getPrice() > 50)
            {
                cost = book.getPrice() - 5;
            }
            else
            {
                cost = book.getPrice();
            }

            Console.WriteLine("Book ISBN:: " + book.getIsbnNumber() + " Cost = " + cost);
            return cost;
        }

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        public int Visit(Fruit fruit)
        {
            int cost = fruit.GetPricePerKilogram() * fruit.GetWeight();
            Console.WriteLine(fruit.GetName() + " Cost = " + cost);
            return cost;
        }
    }
}
