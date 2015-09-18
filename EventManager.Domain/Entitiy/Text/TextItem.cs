using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entitiy.Text
{
    public class TextItem : ContentItem, IContentItem
    {
        public TextItem(User author)
        {
            this.Author = author;
        }
        public User Author { get; private set; }
        public string Text { get; set; }
    }
}
