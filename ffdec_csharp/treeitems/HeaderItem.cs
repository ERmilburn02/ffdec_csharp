using System;
using System.Collections.Generic;
using System.Text;
using ffdec_csharp;

namespace ffdec_csharp.treeitems
{
    public class HeaderItem : TreeItem
    {
        private SWF swf;

        private string name;

        public HeaderItem(SWF swf, string name)
        {
            this.swf = swf;
            this.name = name;
        }

        public SWF getSWf()
        {
            return swf;
        }

        public override string ToString()
        {
            return name;
        }

        public bool isModified()
        {
            return false;
        }
    }
}
