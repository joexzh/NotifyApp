using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Lib
{
    public class EventContentFactory
    {
        private EventType type;

        public EventContentFactory(EventType type)
        {
            this.type = type;
        }


    }
}
