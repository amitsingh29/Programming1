//-----------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" company="BridgeLabz">
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
    /// ShoppingCartVisitor class
    /// </summary>
    public interface ShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <returns></returns>
        public int Visit(Book book);

        /// <summary>
        /// Visits the specified fruit.
        /// </summary>
        /// <param name="fruit">The fruit.</param>
        /// <returns></returns>
        public int Visit(Fruit fruit);
    }
}
