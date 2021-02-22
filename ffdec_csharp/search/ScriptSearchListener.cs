using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.search
{
    public interface ScriptSearchListener
    {
        public void onDecompile(int pos, int total, string name);

        public void onSearch(int pos, int total, string name);
    }
}
