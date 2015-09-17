using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Text
{
    public class TextSummary
    {
        public TextSummary(ICollection<TextItem> textItems)
        {
            Total = textItems.Count;
            textItems.ToList().ForEach(t =>
            {
                if (t.Status == ValueObject.ItemStatus.Done)
                {
                    DoneCount += 1;
                }
                else
                {
                    UndoneCount += 1;
                }

            });
        }

        public int DoneCount { get; private set; }
        public int UndoneCount { get; private set; }
        public int Total { get; private set; }
    }
}
