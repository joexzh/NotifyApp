using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    class ConsumptionContent : EventContent
    {
        public ConsumptionContent()
        {
            this.ConsumptionItems = new List<ConsumptionItem>();
        }

        public virtual ICollection<ConsumptionItem> ConsumptionItems { get; private set; }

    }
}
