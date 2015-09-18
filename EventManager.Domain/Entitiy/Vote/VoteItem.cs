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

        public VoteItem(string name)
        {
            this.Name = name;
            this.Count = 0;
        }

        public void InCreateCount()
        {
            lock (inCreateLock)
            {
                Count++;
            }
        }

        public string Name { get; set; }
        public int Count { get; private set; }
    }
}
