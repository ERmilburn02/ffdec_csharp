using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.types
{
    [Serializable]
    public class COLORMAPDATA
    {
        public int[] colorTableRGB;

        public byte[] colorMapPixelData;
    }
}
