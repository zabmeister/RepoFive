using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;

namespace Subscriber.Console.EventHandlers
{
    public class NewListHandler : IHandleMessages<NewList>
    {
        public void Handle(NewList message)
        {
            System.Console.WriteLine("Message received: {0}", message.Source);
        }
    }
}
