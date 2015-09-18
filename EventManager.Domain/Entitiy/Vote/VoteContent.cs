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
        }

        public override IContentSummary ContentSummary
        {
            get
            {
                return new VoteSummary(this.ContentItems);
            }
        }
    }
}
