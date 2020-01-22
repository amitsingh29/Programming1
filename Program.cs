//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Amit Singh"/>
//-----------------------------------------------------------------------using System;

namespace DesignPattern
{
    using System;
    using DesignPattern.FactoryPattern;
    using DesignPattern.StructuralDesignPattern.ProxyDesignPattern;
    
    /// <summary>
    /// Program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factory Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    FactoryPattern.ComputerFactory factory = new ConcreteComputerFactory();
                    CFactory pc = factory.GetComputer("Pc");
                    pc.Functionality("4", "64", "Windows 10");
                    CFactory server = factory.GetComputer("Server");
                    server.Functionality("500", "10000", "Ubuntu");
                    Console.ReadKey();
                    break;
                case 2:
                    DataBaseExecutor nonAdminExecutor = new DatabaseExecutorProxy("non-admin", "Admin@123");
                    DataBaseExecutor adminExecutor = new DatabaseExecutorProxy("admin", "Admin@123");
                    break;

                case 3:
                    break;
            }
        }
    }
}
