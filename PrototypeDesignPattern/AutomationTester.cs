using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypeDesignPattern
{
    class AutomationTester
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string JobLocation { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// Emps the details.
        /// </summary>
        /// <returns></returns>
        public string empDetails()
        {
            return string.Format("{0}-{1}-{2}", this.Name, this.Age, this.JobLocation);
        }
    }
}
