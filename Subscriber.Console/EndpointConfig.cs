using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Subscriber.Console
{
    public class EndPointConfig : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        public void Init()
        {
            NServiceBus.Configure.With()
                                 .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("Messages"));

        }
    }
}
