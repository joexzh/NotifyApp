using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy
{
    public class TextContent : EventContent
    {
        public TextContent(string text = null)
        {
            this.TextList = new List<string>();
            if (!string.IsNullOrEmpty(text))
            {
                TextList.Add(text);
            }
        }

        public virtual ICollection<string> TextList { get; private set; }

        public void AddItem(string text)
        {
            TextList.Add(text);
        }

        public void RemoveItem(string item)
        {
            TextList.Remove(item);
        }
    }
}
