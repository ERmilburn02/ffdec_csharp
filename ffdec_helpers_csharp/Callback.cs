using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_helpers_csharp
{
    public abstract class Callback<T>
    {
        public abstract void call(T arg1);
    }
}
