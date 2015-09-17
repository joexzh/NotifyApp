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
            Total = consumptionItems.Count;
            consumptionItems.ToList().ForEach(c =>
            {
                var user = c.Key as User;
                if (c.Status == ValueObject.ItemStatus.Done)
                {
                    PaidUsers.Add(user);
                    TotalAmount += (decimal)c.value;
                }
                else
                {
                    UnpaidUsers.Add(user);
                    UnpaidAmount += (decimal)c.value;
                }

            });
        }
        public ICollection<User> UnpaidUsers { get; private set; }
        public ICollection<User> PaidUsers { get; private set; }
        public decimal TotalAmount { get; set; }
        public decimal UnpaidAmount { get; set; }
        public int Total { get; set; }
    }
}
