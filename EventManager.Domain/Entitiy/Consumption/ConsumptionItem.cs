using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionItem : ContentItem, IContentItem
    {
        public ConsumptionItem(User user)
            : base()
        {
            this.Key = user;
        }

        public object Key { get; private set; }
        public object value { get; set; }
        public User Author { get; private set; }
        public DateTime? ModifyDate { get; private set; }
    }
}
