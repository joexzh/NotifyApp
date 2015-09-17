using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joe.Notify.Model
{
    public interface IEventOperation
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

        void Operate();
    }
}
