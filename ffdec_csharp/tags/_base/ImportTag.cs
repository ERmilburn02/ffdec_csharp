using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.tags._base
{
    public interface ImportTag
    {
        public string getUrl();

        public void setUrl(string url);

        public Dictionary<int, string> getAssets();
    }
}
