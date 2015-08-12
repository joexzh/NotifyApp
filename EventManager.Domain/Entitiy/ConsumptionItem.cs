using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager.Domain.Entitiy
{
    public class ConsumptionItem : IAggregateRoot
    {
        public ConsumptionItem(User user)
        {
            this.Id = Guid.NewGuid().ToString();
            this.User = user;
        }

        public string Id { get; private set; }
        public User User { get; private set; }
        public decimal Amount { get; set; }
    }
}
