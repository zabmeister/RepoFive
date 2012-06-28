using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;
using Messages;
using System.Collections.ObjectModel;

namespace Subscriber.Wpf
{
    public class NewListViewModel : IHandleMessages<NewList>
    {                
        public ObservableCollection<string> Items { get; private set; }

        public NewListViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        public void Handle(NewList message)
        {
            Items.Add(message.Source);
        }
    }
}
