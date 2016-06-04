using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class AddList
    {
        public void Add(List<RelatedCommon> list, RelatedCommon related)
        {
            list.Add(related);
        }
    }
}
