using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Domain.ValueObject;

namespace EventManager.Domain.Entitiy.Text
{
    public class TextItem : IContentItem
    {
        public TextItem(User user)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Author = user;
            this.CreateDate = DateTime.Now;
        }
        public User Author { get; private set; }

        public DateTime? CreateDate { get; private set; }

        public string Id { get; private set; }

        public object Key { get; set; }

        public DateTime? ModifyDate { get; private set; }

        public ItemStatus Status
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object value
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
