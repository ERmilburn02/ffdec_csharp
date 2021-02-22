using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.ecma
{
    [Serializable]
    public class NotCompileTime
    {
        public static NotCompileTime INSTANCE = new NotCompileTime();

        private NotCompileTime()
        {

        }

        public override string ToString()
        {
            return "not_compile_time";
        }
    }
}
