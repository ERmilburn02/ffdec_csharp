using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_helpers_csharp.stat
{
    public class StatisticData
    {
        public int count;

        public long value;

        public long min = long.MaxValue;

        public long max = long.MinValue;
    }
}
