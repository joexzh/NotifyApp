using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Consumption
{
    public class ConsumptionSummary : IContentSummary
    {
        public ConsumptionSummary(ICollection<ConsumptionItem> consumptionItems)
        {
            Total = consumptionItems.Count;
            TotalCost = consumptionItems.Sum(c => c.Cost);
            consumptionItems.ToList().ForEach(c =>
            {
                var user = c.Consumer as User;
                if (c.Status == ValueObject.ItemStatus.Done)
                {
                    PaidUsers.Add(user);
                    PaidCost += c.Cost;
                }
                else
                {
                    UnpaidUsers.Add(user);
                    UnpaidCost += c.Cost;
                }

            });
        }
        public ICollection<User> UnpaidUsers { get; private set; }
        public ICollection<User> PaidUsers { get; private set; }
        public decimal TotalCost { get; private set; }
        public decimal PaidCost { get; private set; }
        public decimal UnpaidCost { get; private set; }
        public int Total { get; private set; }
    }
}
