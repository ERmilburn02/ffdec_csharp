using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp
{
    public abstract class ParseException : Exception
    {
        public long line;

        public string text;

        public ParseException(string text, long line)
        {
            this.line = line;
            this.text = text;
            new Exception("ParseException:" + text + " on line " + line);
        }
    }
}
