﻿using System;
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
            this.ContentItems = new List<TextItem>();
        }


        public override object Remark
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override object Summary
        {
            get { return new TextSummary(this.ContentItems); }
        }

    }
}
