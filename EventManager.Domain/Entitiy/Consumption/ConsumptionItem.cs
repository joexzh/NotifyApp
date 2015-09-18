using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionItem : ContentItem, IContentItem
    {
        public ConsumptionItem(User consumer)
        {
            this.Consumer = consumer;
        }

        public User Consumer { get; private set; }
        public decimal Cost { get; set; }

    }
}
