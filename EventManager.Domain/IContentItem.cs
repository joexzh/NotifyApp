using EventManager.Domain.Entitiy;
using EventManager.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public interface IContentItem : IAggregateRoot
    {
        object Key { get; }
        object value { get; }
        User Author { get; }
        DateTime? CreateDate { get; }
        ItemStatus Status { get; }
    }
}
