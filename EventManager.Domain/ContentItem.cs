using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain
{
    public abstract class ContentItem : IContentItem
    {
        public ContentItem()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Status = ValueObject.ItemStatus.Undone;
            this.CreateDate = DateTime.Now;
        }
        public virtual DateTime? CreateDate { get; protected set; }
        public virtual DateTime? ModifiedDate { get; protected set; }
        public virtual ValueObject.ItemStatus Status { get; protected set; }
        public virtual string Id { get; protected set; }

        public void SetModifiedDate()
        {
            this.ModifiedDate = DateTime.Now;
        }
    }
}
