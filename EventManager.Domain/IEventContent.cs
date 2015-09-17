using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public interface IEventContent<IItem> : IAggregateRoot
        where IItem : IContentItem
    {
        object Remark { get; }
        object Summary { get; }
        ICollection<IItem> ContentItems { get; }
    }
}
