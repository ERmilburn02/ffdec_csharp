using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.cache
{
    public interface ScriptDecompiledListener<T>
    {
        public void onStart();

        public void onComplete(T result);
    }
}
