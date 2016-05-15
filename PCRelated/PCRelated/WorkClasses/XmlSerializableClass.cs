using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCRelated.CurrentClasses;

namespace PCRelated.WorkClasses
{
    [Serializable]
    public class XmlSerializableClass
    {
        public List<RelatedCommon> List { get; set; }

        public XmlSerializableClass()
        {
            
        }
    }
}
