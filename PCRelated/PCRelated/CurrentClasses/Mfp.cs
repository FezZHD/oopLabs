using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class Mfp:Printers
    {
        public string CopyResolution { get; set; }
        public uint CopySpeed { get; set; }
        public uint MaxCopySpeed { get; set; }

        public Mfp(string type) : base(type)
        {
        }
    }
}
