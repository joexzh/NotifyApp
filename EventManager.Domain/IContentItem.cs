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
        DateTime? CreateDate { get; }
        DateTime? ModifiedDate { get; }
        ItemStatus Status { get; }
        void SetModifiedDate();
    }
}
