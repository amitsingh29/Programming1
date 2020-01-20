using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryPattern
{
    class Laptop : CFactory
    {
        public void functionality(string ram, string processor, string os)
        {
            Console.WriteLine("Fnctionality of laptop :"+ram.ToString()+" Gb "+processor.ToString()+" GB "+os.ToString());
        }

        public void functionality()
        {
            throw new NotImplementedException();
        }
    }
}
