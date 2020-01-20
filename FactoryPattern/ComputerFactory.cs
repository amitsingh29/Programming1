using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    public abstract class ComputerFactory
     {
        public abstract CFactory GetComputer(string Computer);
     }
}
