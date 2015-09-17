using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Vote
{
    public class VoteSummary
    {
        public VoteSummary(ICollection<VoteItem> voteItems)
        {
            this.VoteItems = voteItems;
            this.Total = voteItems.Count;
            this.VoteCount = voteItems.Sum(v => (int)v.Value);
        }

        public ICollection<VoteItem> VoteItems { get; private set; }
        public int VoteCount { get; set; }
        public int Total { get; set; }
    }
}
