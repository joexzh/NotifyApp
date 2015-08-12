using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public abstract class EventContent : IEventContent
    {
        public EventContent()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id
        {
            get;
            private set;
        }

    }
}
