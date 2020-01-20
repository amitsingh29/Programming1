using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesignPattern
{
    class ProtoMain
    {
        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void check()
        {
            Developer d = new Developer();
            d.Name = "Amit";
            d.Age = 24;
            d.Technology = "DotNet";

            Developer copy = (Developer)d.clone();
            copy.Name = "Sumit";
            Console.WriteLine(d.empDetails());
            Console.WriteLine(copy.empDetails());

            Debugger debugger = new Debugger();
            debugger.Name = "Mayank";
            debugger.Age = 24;
            debugger.TotalExperience = 2;

            Debugger copy1 = (Debugger)debugger.clone();
            copy1.Name = "Zeeshan";
            Console.WriteLine(debugger.empDetails());
            Console.WriteLine(copy1.empDetails());

            AutomationTester tester = new AutomationTester();
            tester.Name = "Saad";
            tester.Age = 23;
            tester.JobLocation = "Germany";

            AutomationTester copy2 =(AutomationTester)tester.clone();
            copy2.Name = "Fahad";
            Console.WriteLine(tester.empDetails());
            Console.WriteLine(copy2.empDetails());


        }
    }
}
