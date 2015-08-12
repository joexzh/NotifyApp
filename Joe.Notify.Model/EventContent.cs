using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joe.Notify.Model
{
    public class EventContent
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

        public string Text
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual Consumption Consumption
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Vote
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual Chosen Chosen
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
