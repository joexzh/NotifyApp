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
        public TextItem(User user)
            : base()
        {
            this.Author = user;
        }
        public User Author { get; private set; }
        public object Key { get; set; }
        public DateTime? ModifyDate { get; private set; }
        public object value { get; set; }
    }
}
