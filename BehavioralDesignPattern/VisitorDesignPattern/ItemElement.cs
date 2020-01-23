//-----------------------------------------------------------------------
// <copyright file="ItemElement.cs" company="BridgeLabz">
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
    /// ItemElement class
    /// </summary>
    public interface ItemElement
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns></returns>
        public int Accept(ShoppingCartVisitor visitor);
    }
}
