using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Vote
{
    public class VoteSummary : IContentSummary
    {
        public VoteSummary(ICollection<VoteItem> voteItems)
        {
            this.Total = voteItems.Count;
            this.VoteCount = voteItems.Sum(v => v.Count);
        }

        public int VoteCount { get; private set; }
        public int Total { get; private set; }
    }
}
