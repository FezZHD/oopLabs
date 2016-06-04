using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class DeleteList
    {
        public void Delete(List<RelatedCommon> list, int relatedIndex)
        {
            list.RemoveAt(relatedIndex);
        }
    }
}
