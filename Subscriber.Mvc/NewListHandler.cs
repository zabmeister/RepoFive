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
            //NOTE: note sure how to do this in MVC
            System.Console.WriteLine("Message received: {0}", message.Source);
        }
    }
}
