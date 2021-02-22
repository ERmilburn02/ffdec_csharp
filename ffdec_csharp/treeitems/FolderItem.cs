using System;
using System.Collections.Generic;
using System.Text;
using ffdec_csharp;

namespace ffdec_csharp.treeitems
{
    public class FolderItem : TreeItem
    {
        public SWF swf;

        private string str;

        private string name;

        public List<TreeItem> subItems;

        public FolderItem(string str, string name, SWF swf, List<TreeItem> subItems)
        {
            this.swf = swf;
            this.str = str;
            this.name = name;
            this.subItems = subItems;
        }

        public string getName()
        {
            return name;
        }

        public SWF getSWf()
        {
            return swf;
        }

        public bool isModified()
        {
            if (subItems == null)
            {
                return false;
            }

            foreach (TreeItem ti in subItems)
            {
                if (ti.isModified())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
