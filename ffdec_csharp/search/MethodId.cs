using System;
using System.Collections.Generic;
using System.Text;

namespace ffdec_csharp.search
{
    public class MethodId
    {
        private int traitId;

        private int classIndex;

        private int methodIndex;

        public MethodId(int traitId, int classIndex, int methodIndex)
        {
            this.traitId = traitId;
            this.classIndex = classIndex;
            this.methodIndex = methodIndex;
        }

        public int getClassIndex()
        {
            return classIndex;
        }

        public int getMethodIndex()
        {
            return methodIndex;
        }

        public int getTraitId()
        {
            return traitId;
        }
    }
}
