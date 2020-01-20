using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    class Server : CFactory
    {
        /// <summary>
        /// Functionalities the specified ram.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="processor">The processor.</param>
        /// <param name="os">The os.</param>
        public void functionality(string ram, string processor, string os)
        {
            Console.WriteLine("Functionality of server :" + ram.ToString() + " Gb " + processor.ToString() + " Gb " + os.ToString());
        }

        public void functionality()
        {
            throw new NotImplementedException();
        }
    }
}
