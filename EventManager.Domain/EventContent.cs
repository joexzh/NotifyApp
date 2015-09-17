using EventManager.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public abstract class EventContent<IItem> : IEventContent<IItem>
        where IItem : IContentItem
    {
        public EventContent()
        {
            this.Id = Guid.NewGuid().ToString();
            this.ContentItems = new List<IItem>();
        }

        public ICollection<IItem> ContentItems { get; private set; }
        public string Id { get; private set; }
        public abstract object Remark { get; set; }
        public abstract object Summary { get; }
    }
}
