using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;

namespace Publisher
{
    public class ServerEndpoint : IWantToRunAtStartup
    {
        public IBus Bus { get; set; }

        public void Run()
        {
            Console.WriteLine("Press 'Enter' to publish a message.To exit, Ctrl + C");

            var i = 0;
            while (Console.ReadLine() != null)
            {
                var eventMessage = new NewList { Source = "Source " + i.ToString() };

                Bus.Publish(eventMessage);

                Console.WriteLine("Published event Source: {0}.", eventMessage.Source);

                i++;
            }
        }

        public void Stop()
        {

        }
    }
}
