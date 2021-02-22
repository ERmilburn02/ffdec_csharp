using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_graph_csharp
{
    public interface Callable
    {
        public object call(string methodName, List<object> args);

        public object call(List<object> args);
    }
}
