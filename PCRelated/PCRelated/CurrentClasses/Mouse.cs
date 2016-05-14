using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class Mouse:RelatedCommon
    {
        public uint KeysCount { get; set; }
        public uint PortFrequency { get; set; }
        public string Light { get; set; }
        public uint Dpi { get; set; }

        public Mouse(string type) : base(type)
        {
        }
    }
}
