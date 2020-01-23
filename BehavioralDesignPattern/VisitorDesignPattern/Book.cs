//-----------------------------------------------------------------------
// <copyright file="Book.cs" company="BridgeLabz">
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
    /// Book class
    /// </summary>
    public class Book : ItemElement
    {
        /// <summary>
        /// The price
        /// </summary>
        private int price;

        /// <summary>
        /// The isbn number
        /// </summary>
        private string isbnNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The isbn.</param>
        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public int getPrice()
        {
            return this.price;
        }

        /// <summary>
        /// Gets the isbn number.
        /// </summary>
        /// <returns></returns>
        public string getIsbnNumber()
        {
            return this.isbnNumber;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
