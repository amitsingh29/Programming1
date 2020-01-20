using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    class Pc : CFactory
    {
        /// <summary>
        /// Functionalities the specified ram.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="processor">The processor.</param>
        /// <param name="os">The os.</param>
        public void functionality(string ram, string processor, string os)
        {
            Console.WriteLine("Fnctionality of PC :" + ram.ToString() + " Gb " + processor.ToString() + " GB " + os.ToString());
        }

        public void functionality()
        {
            throw new NotImplementedException();
        }
    }
}
