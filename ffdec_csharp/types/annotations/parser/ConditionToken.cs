using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.types.annotations.parser
{
    public class ConditionToken
    {
        public string value;

        public ConditionTokenType type;

        public ConditionToken(ConditionTokenType type, string value)
        {
            this.value = value;
            this.type = type;
        }

        public override string ToString()
        {
            return type.ToString() + (value != null ? "[" + value + "]" : "");
        }
    }
}
