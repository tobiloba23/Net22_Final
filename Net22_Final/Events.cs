using System;
using System.Collections.Generic;
using System.Text;

namespace Net22_Final
{
    public class EventArgsObject : EventArgs
    {
        public string SubscriberName { get; set; }

        public EventArgsObject(string subscriber)
        {
            SubscriberName = subscriber;
        }
    }

    public class Service
    {
        //public delegate void onSubscribe(object sender, EventArgsObject args);

        public event EventHandler<EventArgsObject> subscriptionList;
        public string Product { get; set; }

        public Service(string name)
        {
            Product = name;
        }

        public virtual void send(string product, string subscriber)
        {
            subscriptionList?.Invoke(this, new EventArgsObject(subscriber));
            Console.WriteLine($"{product} sent to {subscriber}!");
        }
    }

    public class Subsccriber
    {
        public string Name { get; set; }

        public Subsccriber(string name)
        {
            Name = name;
        }

        public void onRequest(object sender, EventArgsObject args)
        {
            Console.WriteLine($"{args.SubscriberName} requesting!");
        }
    }
}
