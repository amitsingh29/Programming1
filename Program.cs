using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Factory Pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    FactoryPattern.ComputerFactory factory = new ConcreteComputerFactory();
                    CFactory pc = factory.GetComputer("Pc");
                    pc.functionality("4","64","Windows 10");
                    CFactory server = factory.GetComputer("Server");
                    server.functionality("500","10000","Ubuntu");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
