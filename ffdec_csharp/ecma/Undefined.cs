using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.ecma
{
    [Serializable]
    public class Undefined
    {
        public static Undefined INSTANCE = new Undefined();

        private Undefined()
        {

        }

        public override string ToString()
        {
            return "undefined";
        }
    }
}
