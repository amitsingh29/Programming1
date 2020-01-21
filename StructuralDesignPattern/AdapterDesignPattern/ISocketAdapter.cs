using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
     public interface ISocketAdapter
    {
        public Volt Get3Volt();
        public Volt Get120Volt();
        public Volt Get240Volt();
    }
}
