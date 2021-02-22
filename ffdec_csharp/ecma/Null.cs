using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.ecma
{
    [Serializable]
    public class Null
    {
        public static Null INSTANCE = new Null();

        private Null()
        {

        }

        public override string ToString()
        {
            return "null";
        }
    }
}
