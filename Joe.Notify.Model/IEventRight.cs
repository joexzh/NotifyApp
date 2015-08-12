using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joe.Notify.Model
{
    public interface IEventRight
    {
        int Id
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        ICollection<User> Users
        {
            get;
            set;
        }

        void Operation();
    }
}
