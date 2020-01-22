
//-----------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface DataBaseExecutor
    {
        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="query">The query.</param>
        public void ExecuteDatabase(string query); 
    }
}
