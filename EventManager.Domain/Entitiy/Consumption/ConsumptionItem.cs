using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionItem : IContentItem
    {
        public ConsumptionItem(User user)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Key = user;

        }

        public string Id { get; private set; }
        public object Key { get; private set; }
        public object value { get; set; }
        public User Author { get; private set; }
        public DateTime? CreateDate { get; private set; }
        public ItemStatus Status { get; private set; }
        public DateTime? ModifyDate { get; private set; }
    }
}
