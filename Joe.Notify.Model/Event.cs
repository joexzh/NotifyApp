using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joe.Notify.Model
{
    public class Event
    {
        public int Id
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Title
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual ICollection<User> Members
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime CreateDate
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual System.Collections.Generic.ICollection<Event> Events
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual User Host
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual EventContent Content
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime BeginTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime EndTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EventType Type
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public virtual ICollection<Reminder> Reminders
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public EventStatus Status
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int UserRights
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}
