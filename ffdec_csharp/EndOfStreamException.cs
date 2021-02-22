using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ffdec_csharp
{
    public class EndOfStreamException : IOException
    {
        public EndOfStreamException()
        {
            new IOException("Premeture end of the stream reached");
        }
    }
}
