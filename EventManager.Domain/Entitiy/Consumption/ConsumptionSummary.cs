using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionSummary
    {
        public ConsumptionSummary(ICollection<ConsumptionItem> consumptionItems)
        {
            consumptionItems.ToList().ForEach(c =>
            {
                var user = c.Key as User;
                if (c.Status == ValueObject.ItemStatus.Done)
                {
                    PaidUsers.Add(user);
                }
                else
                    UnpaidUsers.Add(user);
            });
        }
        public ICollection<User> UnpaidUsers { get; private set; }
        public ICollection<User> PaidUsers { get; private set; }
    }
}
