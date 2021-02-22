using System;
using System.Collections.Generic;
using System.Text;
using ffdec_csharp;

namespace ffdec_csharp.treeitems
{
    public interface TreeItem
    {
        public SWF getSWf();

        public bool isModified();
    }
}
