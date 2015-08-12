using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joe.Notify.Model
{
    public class EventRight : IEventRight
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


        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Operation()
        {
            throw new NotImplementedException();
        }


        public virtual ICollection<User> Users
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
