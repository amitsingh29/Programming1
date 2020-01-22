

namespace DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SocketAdapterImpl : Socket
    {
            public Volt Get120V()
            {
                return GetVolt();
            }
            public Volt Get240Volt()
            {
                Volt v = GetVolt();
                return convertVolt(v,10);
            }
            public Volt Get3Volt()
            {
                Volt v = GetVolt();
                return convertVolt(v,40);
            }
            private Volt convertVolt(Volt v, int i)
            {
                return new Volt(v.GetVolts() / i);
            } 
        
    }
}
