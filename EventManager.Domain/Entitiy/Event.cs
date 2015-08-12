using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Domain.Entitiy;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entity
{
    public class Event : IAggregateRoot
    {
        public Event(User host)
        {
            if (true)
            {

            }

            this.Id = Guid.NewGuid().ToString();
            this.CreateDate = DateTime.Now;
            this.Host = host;
            this.Members.Add(host);
        }

        #region fields

        private string title;

        #endregion

        #region properties

        public string Id { get; private set; }

        public string Title
        {
            get { return title; }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Title should less than 100 words.");
                }
            }
        }

        public virtual ICollection<User> Members { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? UpdateDate { get; private set; }


        public virtual System.Collections.Generic.ICollection<Event> SubEvents
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
            get;
            private set;
        }

        public virtual EventContent Content { get; private set; }

        public DateTime? BeginTime { get; private set; }
        public DateTime? EndTime { get; private set; }

        public EventType Type
        {
            get;
            set;
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
            get;
            private set;
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
        #endregion
    }
}
