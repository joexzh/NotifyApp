using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Vote
{
    public class VoteContent : EventContent<VoteItem>, IEventContent<VoteItem>
    {
        public VoteContent()
        {
            this.ContentItems = new List<VoteItem>();
        }

        public override object Remark
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

        public override object Summary
        {
            get { throw new NotImplementedException(); }
        }
    }
}
