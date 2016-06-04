using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    class List
    {
        public List<RelatedCommon> GetInstance(List<RelatedCommon> list)
        {
            if (list == null)
            {
                list = new List<RelatedCommon>();
            }
            return list;
        }
    }
}
