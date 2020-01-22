//-----------------------------------------------------------------------
// <copyright file="DatabaseExecutorProxy.cs" company="BridgeLabz">
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
    /// DatabaseExecutorProxy class
    /// </summary>
    /// <seealso cref="DesignPattern.StructuralDesignPattern.ProxyDesignPattern.DataBaseExecutor" />
    public class DatabaseExecutorProxy : DataBaseExecutor
    {
        /// <summary>
        /// The data base executer
        /// </summary>
        public DataBaseImplementation DataBaseExecuter;

        /// <summary>
        /// The v1
        /// </summary>
        private string v1;

        /// <summary>
        /// The v2
        /// </summary>
        private string v2;

        /// <summary>
        /// The is admin
        /// </summary>
        private bool isAdmin;

        /// <summary>
        /// Initializes a new instance of the <see cref="DatabaseExecutorProxy"/> class.
        /// </summary>
        /// <param name="v1">The v1.</param>
        /// <param name="v2">The v2.</param>
        public DatabaseExecutorProxy(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="pwd">The password.</param>
        public void ExecuteDatabase(string name, string pwd)
        {
           if (name == "Admin" && pwd == "Admin@123")
            {
                isAdmin = true;
                DataBaseExecuter = new DataBaseImplementation();
            }
        }

        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <exception cref="Exception">delete not allowed for non-admin user</exception>
        public void ExecuteDatabase(string query)
        {
            if (isAdmin)
            {
                DataBaseExecuter.ExecuteDatabase(query);
            }
            else
            {
                if (query.Equals("Delete"))
                {
                    throw new Exception("delete not allowed for non-admin user's     ");
                }
                else
                {
                    DataBaseExecuter.ExecuteDatabase(query);
                }
            }
        }  
    }
}
