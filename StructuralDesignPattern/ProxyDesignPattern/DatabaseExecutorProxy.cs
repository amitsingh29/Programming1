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

    class DatabaseExecutorProxy : DataBaseExecutor
    {
        Boolean isAdmin;
        DataBaseImpl dataBaseExecuter;
        private string v1;
        private string v2;

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

        public void ExecuteDatabase(string name,string pwd)
        {
           if(name=="Admin" && pwd=="Admin@123")
            {
                isAdmin = true;
                dataBaseExecuter = new DataBaseImpl();
            }
        }

        /// <summary>
        /// Executes the database.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <exception cref="Exception">delete not allowed for non-admin user</exception>
        
        public void ExecuteDatabase(string query)
        {
            if(isAdmin)
            {
                dataBaseExecuter.ExecuteDatabase(query);
            }
            else
            {
                if(query.Equals("Delete"))
                {
                    throw new Exception("delete not allowed for non-admin user's     ");
                }
                else
                {
                    dataBaseExecuter.ExecuteDatabase(query);
                }
            }
        }
       
    }
}
