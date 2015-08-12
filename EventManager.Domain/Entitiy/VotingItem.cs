using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.Domain.Entitiy
{
    public class VotingItem : IAggregateRoot
    {
        private object inCreateLock = new object();

        public VotingItem(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Count { get; private set; }

        public void InCreateCount()
        {
            lock (inCreateLock)
            {
                Count++;
            }
        }
    }
}
