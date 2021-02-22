using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.dumpview
{
    public enum DumpInfoSpecialType
    {
        NONE, ZLIB_DATA,
        TAG,
        ACTION_BYTES,
        ABC_BYTES, ABC_METHOD_BODY, ABD_CODE
    }
}
