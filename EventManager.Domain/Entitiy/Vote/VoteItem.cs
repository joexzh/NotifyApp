using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.Domain.Entitiy.Vote
{
    public class VoteItem : ContentItem, IContentItem
    {
        //TODO: should use distribute lock
        private object inCreateLock = new object();

        public VoteItem()
        {
            this.Value = 0;
        }

        public void InCreateCount()
        {
            lock (inCreateLock)
            {
                Value = (int)Value + 1;
            }
        }
    }
}
