using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp
{
    public class SWFHeader
    {
        public int version;

        public long fileSize;

        public SWFCompression compression = SWFCompression.NONE;

        public byte[] lzmaProperties;

        public bool gfx = false;

        public float frameRate;
    }
}
