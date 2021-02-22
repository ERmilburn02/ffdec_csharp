using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.treeitems
{
    public interface ScriptContainer
    {
        public Dictionary<string, TreeItem> getInnerScripts();
    }
}
