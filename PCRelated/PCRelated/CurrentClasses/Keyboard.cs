using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class Keyboard:RelatedCommon
    {

        public uint KeysCount { get; set; }
        public uint PortFrequency { get; set; }
        public string Light { get; set; }

        public Keyboard(string type) : base(type)
        {
        }
    }
}
