using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCRelated
{
    class Printers:RelatedCommon
    {
        public string CopyRelosution { get; set; }
        public uint CopySpeen { get; set; }
        public uint MaxSpeedCopy { get; set; }

        public Printers(string type) : base(type)
        {
        }
    }
}
