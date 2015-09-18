using EventManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public abstract class EventContent<TItem> : IEventContent<TItem>
        where TItem : IContentItem
    {
        public EventContent()
        {
            this.Id = Guid.NewGuid().ToString();
            this.ContentItems = new List<TItem>();
        }

        public virtual ICollection<TItem> ContentItems { get; protected set; }

        public virtual string Id { get; protected set; }
        
        public virtual IContentSummary ContentSummary { get; }

        public virtual void AddItem(TItem item)
        {
            this.ContentItems.Add(item);
        }

        public virtual void RemoveItem(TItem item)
        {
            this.ContentItems.Remove(item);
        }
    }
}
