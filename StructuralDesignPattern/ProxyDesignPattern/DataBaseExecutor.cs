using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralDesignPattern.ProxyDesignPattern
{
    public interface DataBaseExecutor
    {
        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="query">The query.</param>
        public void executeDatabase(string query); 
    }
}
