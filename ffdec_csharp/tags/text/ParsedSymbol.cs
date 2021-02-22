using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.tags.text
{
    public class ParsedSymbol
    {
        public object[] values;

        public SymbolType type;

        public ParsedSymbol(SymbolType type, object[] values)
        {
            this.type = type;
            this.values = values;
        }

        public override string ToString()
        {
            string v = "";
            bool first = true;
            foreach(object o in values)
            {
                if (!first)
                {
                    v += ", ";
                }
                first = false;
                v += o.ToString();
            }
            return type.ToString() + " " + v;
        }

        public bool isType(SymbolType[] types)
        {
            foreach (SymbolType t in types)
            {
                if (type == t)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
