using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Publisher
{
    public class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, IWantCustomInitialization
    {
        public void Init()
        {
            NServiceBus.Configure.With()
                                 .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("Messages"));

                    
        }
    }
}
