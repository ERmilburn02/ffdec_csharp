using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.tags._base
{
    public interface PasswordTag
    {
        public void setPassword(string password);

        public bool hasPassword(string password);
    }
}
