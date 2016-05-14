using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    abstract class RelatedCommon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Interfaces { get; set; }

        public RelatedCommon(string type)
        {
            Type = type;
        }
    }
}
