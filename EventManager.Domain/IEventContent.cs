using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public interface IEventContent<TItem> : IAggregateRoot
        where TItem : IContentItem
    {
        ICollection<TItem> ContentItems { get; }
        void AddItem(TItem item);
        void RemoveItem(TItem item);
        IContentSummary ContentSummary { get; }
    }
}
