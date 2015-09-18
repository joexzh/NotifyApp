using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionContent : EventContent<ConsumptionItem>, IEventContent<ConsumptionItem>
    {
        public ConsumptionContent()
        {

        }

        public override IContentSummary ContentSummary
        {
            get
            {
                return new ConsumptionSummary(this.ContentItems);
            }
        }
    }
}
