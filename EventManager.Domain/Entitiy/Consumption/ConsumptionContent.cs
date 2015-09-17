using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Consumption
{
    class ConsumptionContent : EventContent<ConsumptionItem>, IEventContent<ConsumptionItem>
    {
        public ConsumptionContent()
        {

        }

        public override object Remark
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override object Summary
        {
            get
            {
                return new ConsumptionSummary(this.ContentItems);
            }
        }
    }
}
