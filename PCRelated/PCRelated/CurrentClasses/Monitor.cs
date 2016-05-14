using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class Monitor:RelatedCommon
    {

        public string Resolution { get; set; }
        public string MatrixType { get; set; }
        public uint Frequency { get; set; }

        public Monitor(string type) : base(type)
        {
        }
    }
}
