using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public abstract class AbstractPublisher<T>
    {
        private List<ISubscriber<T>> subscribers;
        public AbstractPublisher()
        {
            this.subscribers = new List<ISubscriber<T>>();
        }
        public void AddSubscriber(ISubscriber<T> subscriber)
        {
            this.subscribers.Add(subscriber);
        }
        public void Publish(ISubscriber<T> subscriber, T item)
        {
            subscriber.Notify(item);
            //this.subscribers.ForEach(s => s.Notify(item));
            
        }
    }
}
