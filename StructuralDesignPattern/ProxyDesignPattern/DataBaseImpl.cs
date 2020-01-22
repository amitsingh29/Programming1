//-----------------------------------------------------------------------
// <copyright file="DataBaseImpl class.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DesignPattern.StructuralDesignPattern.ProxyDesignPattern.DataBaseExecutor" />
    public class DataBaseImpl : DataBaseExecutor
    {
        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="query">The query.</param>
        public void ExecuteDatabase(string query)
        {
            Console.WriteLine("going to execute query " + query);
        }
    }
}
