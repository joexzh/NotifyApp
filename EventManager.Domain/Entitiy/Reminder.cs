using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    public class Reminder : IAggregateRoot
    {
        public Reminder(DateTime triggerTime, string text)
        {
            this.Id = Guid.NewGuid().ToString();
            this.TriggerTime = triggerTime;
            this.IsEnabled = true;
            this.Text = text;
        }

        public DateTime TriggerTime { get; set; }
        public string Text { get; set; }
        public bool IsEnabled { get; set; }
        public string Id { get; private set; }
    }
}
