//-----------------------------------------------------------------------
// <copyright file="Fruit.cs" company="BridgeLabz">
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
    /// Fruit class
    /// </summary>
    /// <seealso cref="DesignPattern.BehavioralDesignPattern.VisitorDesignPattern.ItemElement" />
    public class Fruit : ItemElement
    {
        /// <summary>
        /// The price perkilogram
        /// </summary>
        private int pricePerKilogram;

        /// <summary>
        /// The weight
        /// </summary>
        private int weight;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Fruit"/> class.
        /// </summary>
        /// <param name="perKilogram">The per kilogram.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        public Fruit(int perKilogram, int weight, string name)
        {
            this.pricePerKilogram = perKilogram;
            this.weight = weight;
            this.name = name;
        }

        /// <summary>
        /// Gets the price per kilogram.
        /// </summary>
        /// <returns></returns>
        public int GetPricePerKilogram()
        {
            return this.pricePerKilogram;
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <returns></returns>
        public int GetWeight()
        {
            return this.weight;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor  visitor)
        {
            return visitor.Visit(this);
        }
    }

    /// <summary>
    /// ItemElement
    /// </summary>
    public class ItemElement
    {
        /// <summary>
        /// Accepts the specified cart.
        /// </summary>
        /// <param name="cart">The cart.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal int Accept(ShoppingCartVisitor cart)
        {
            throw new NotImplementedException();
        }
    }
}
