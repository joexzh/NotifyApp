using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    public class VoteContent : EventContent
    {
        public VoteContent()
        {
            this.VotingItems = new List<VotingItem>();
        }

        public virtual ICollection<VotingItem> VotingItems { get; private set; }
    }
}
