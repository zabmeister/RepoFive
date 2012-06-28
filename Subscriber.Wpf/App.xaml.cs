using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using NServiceBus;

namespace Subscriber.Wpf
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            NServiceBus.Configure.With()
             .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("Messages"));
        }
    }
}
