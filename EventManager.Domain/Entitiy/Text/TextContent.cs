using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager.Domain.Entitiy.Text
{
    public class TextContent : EventContent<TextItem>, IEventContent<TextItem>
    {
        public TextContent()
        {

        }

        public override IContentSummary ContentSummary
        {
            get
            {
                return new TextSummary(this.ContentItems);
            }
        }

    }
}
